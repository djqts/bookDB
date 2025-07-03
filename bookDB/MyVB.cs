using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace bookMS
{
    public partial class MyVB : Form
    {
        public MyVB()
        {
            InitializeComponent();
            LoadBorrowRecords();
        }

        //表显示
        private void LoadBorrowRecords()
        {
            dataGridView1.Rows.Clear();

            // 使用参数化查询防止SQL注入
            string sql = @"SELECT b.[no], b.[bid], bk.书名, b.借阅时间, b.是否逾期, b.罚款金额, b.罚款验证码
                           FROM Borrow b
                           JOIN Book bk ON b.bid = bk.书号
                           WHERE b.uid = @uid ";//AND b.归还时间 IS NULL";

            Dao dao = new Dao();
            SqlParameter param = new SqlParameter("@uid", Data.UID);

            try
            {
                using (IDataReader reader = dao.ExecuteReader(sql, param))
                {
                    while (reader.Read())
                    {
                        string borrowId = reader["no"].ToString();
                        string bookId = reader["bid"].ToString();
                        string bookName = reader["书名"].ToString();
                        string borrowTime = Convert.ToDateTime(reader["借阅时间"]).ToString("yyyy-MM-dd HH:mm:ss");
                        string overdue = reader["是否逾期"].ToString() == "1" ? "是" : "否";
                        string fine = reader["罚款金额"].ToString();
                        string code = reader["罚款验证码"].ToString();

                        dataGridView1.Rows.Add(borrowId, bookId, bookName, borrowTime, overdue, fine, code);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载借阅记录失败: {ex.Message}");
            }
            finally
            {
                dao.DaoClose();
            }
        }

        //归还
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("请选择要归还的图书");
                return;
            }

            string borrowNo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string bookId = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string bookName = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            // 使用事务确保数据一致性
            using (SqlConnection conn = new SqlConnection(Dao.connStr))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 更新归还时间（触发库存增加和罚款计算）
                    string updateSql = @"UPDATE Borrow 
                                        SET 归还时间 = GETDATE() 
                                        WHERE [no] = @no";

                    // 删除操作改为更新操作
                    using (SqlCommand cmd = new SqlCommand(updateSql, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@no", borrowNo);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show($"用户 '{Data.UID}' 成功归还书籍 '{bookName}'");
                    LoadBorrowRecords(); // 刷新列表
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"归还失败: {ex.Message}");
                }
            }
        }
        //返回
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            User user = new User();
            user.Show();
        }
        
        //续借
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("请选择要续借的图书");
                return;
            }

            string borrowNo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string bookId = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string bookName = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string borrowTime = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string overdue = dataGridView1.CurrentRow.Cells[4].Value.ToString(); 
            string code = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            // 检查是否逾期
            if (overdue == "是")
            {
                MessageBox.Show("该书已逾期，无法续借！请先归还并缴纳罚款");
                return;
            }

            // 使用事务确保数据一致性
            using (SqlConnection conn = new SqlConnection(Dao.connStr))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 步骤1: 归还当前借阅的图书
                    string returnSql = @"UPDATE Borrow 
                                        SET 归还时间 = GETDATE() 
                                        WHERE [no] = @no;";

                    using (SqlCommand returnCmd = new SqlCommand(returnSql, conn, transaction))
                    {
                        returnCmd.Parameters.AddWithValue("@no", borrowNo);
                        returnCmd.ExecuteNonQuery();
                    }

                    // 步骤2: 再次借出同一本图书
                    string borrowSql = @"INSERT INTO Borrow (uid, bid, 借阅时间,罚款验证码) 
                                        VALUES (@uid, @bid, GETDATE(), @code);";

                    using (SqlCommand borrowCmd = new SqlCommand(borrowSql, conn, transaction))
                    {
                        borrowCmd.Parameters.AddWithValue("@uid", Data.UID);
                        borrowCmd.Parameters.AddWithValue("@bid", bookId);
                        borrowCmd.Parameters.AddWithValue("@code", code);
                        borrowCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show($"《{bookName}》续借成功！新的借阅周期为30天");
                    LoadBorrowRecords(); // 刷新列表
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"续借失败: {ex.Message}");
                }
            }
        }

        //提交罚款
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("请选择要提交罚款的图书");
                return;
            }

            string borrowNo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string bookName = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string overdue = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string fine = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string code = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            // 检查是否逾期
            if (overdue == "是")
            {

                if (textBox1.Text == $"{code}")
                {
                    MessageBox.Show("验证码正确，已提交罚款！");
                    // 扣除罚款
                    string deductSql = @"UPDATE Borrow 
                                        SET 罚款金额 = @fine, 罚款验证码 = @code 
                                        WHERE [no] = @no";

                    using (SqlConnection conn = new SqlConnection(Dao.connStr))
                    {
                        conn.Open();
                        SqlTransaction transaction = conn.BeginTransaction();

                        try
                        {
                            using (SqlCommand deductCmd = new SqlCommand(deductSql, conn, transaction))
                            {
                                deductCmd.Parameters.AddWithValue("@no", borrowNo);
                                deductCmd.Parameters.AddWithValue("@code", textBox1.Text);
                                deductCmd.Parameters.AddWithValue("@fine", fine);
                                deductCmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show($"《{bookName}》提交罚款成功！已扣除{fine}元罚款");
                            LoadBorrowRecords(); // 刷新列表
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"提交罚款失败: {ex.Message}");
                        }
                    }
                    // 归还图书
                    string returnSql = @"UPDATE Borrow 
                                        SET 归还时间 = GETDATE(), 罚款金额 = @fine, 罚款验证码 = @code
                                        WHERE [no] = @no";

                    using (SqlConnection conn = new SqlConnection(Dao.connStr))
                    {
                        conn.Open();
                        SqlTransaction transaction = conn.BeginTransaction();

                        try
                        {
                            using (SqlCommand returnCmd = new SqlCommand(returnSql, conn, transaction))
                            {
                                returnCmd.Parameters.AddWithValue("@no", borrowNo);
                                returnCmd.Parameters.AddWithValue("@code", textBox1.Text);
                                returnCmd.Parameters.AddWithValue("@fine", fine);
                                returnCmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show($"《{bookName}》归还成功！已扣除{fine}元罚款");
                            LoadBorrowRecords(); // 刷新列表
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"归还失败: {ex.Message}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("验证码错误！");
                }
            }
        }

        //刷新
        private void button5_Click(object sender, EventArgs e)
        {
            LoadBorrowRecords();
        }

        //提示
        private void textBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请联系管理员获取罚款验证码！");
        }

    }
}
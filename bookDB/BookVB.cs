using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookMS
{
    public partial class BookVB : Form
    {
        public BookVB()
        {
            InitializeComponent();
            Table();
        }

        private void Table()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = "SELECT * FROM Book";
            IDataReader dt = dao.ExecuteReader(sql);
            string a0, a1, a2, a3;
            int a4;
            while (dt.Read())
            {
                a0 = dt.GetString(0);
                a1 = dt.GetString(1);
                a2 = dt.GetString(2);
                a3 = dt.GetString(3);
                a4 = dt.GetInt32(4);
                string[] row = { a0, a1, a2, a3, a4.ToString() };
                dataGridView1.Rows.Add(row);
            }
            dt.Close();
            dao.DaoClose();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                int num = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                string code = RandomString();

                if (num < 1)
                {
                    MessageBox.Show("该书已被借完！");
                    return;
                }

                string sql = "INSERT INTO Borrow(uid, bid, 罚款验证码) VALUES(@uid, @bid, @cd)";
                Dao dao = new Dao();
                SqlParameter[] parameters =
                {
            new SqlParameter("@uid", Data.UID),
            new SqlParameter("@bid", id),
            new SqlParameter("@cd",code)
        };

                int rowsAffected = dao.Execute(sql, parameters);
                if (rowsAffected > 1)
                {
                    MessageBox.Show($"用户 '{Data.UID}' 成功借阅书籍 '{id}'");
                    MessageBox.Show($"借阅有效期为30天，请在30天内归还书籍。");
                    Table(); // 刷新表格
                }
                else
                {
                    MessageBox.Show("借阅失败，请重试。");
                }

                this.Owner?.Show();
                dao.DaoClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //借阅记录页面
            this.Close();
            User record = new User();
            record.ShowDialog();
        }

        //验证码的生成
        private string RandomString(int length = 6)
        {
            const string chars = "0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

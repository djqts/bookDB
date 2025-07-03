using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookMS
{
    public partial class BorrowRecord : Form
    {
        public BorrowRecord()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string uid = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(uid))
            {
                MessageBox.Show("请输入用户ID！");
                return;
            }

            using (SqlConnection conn = new SqlConnection(Dao.connStr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetUserBorrowRecords", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // 添加参数
                    cmd.Parameters.AddWithValue("@uid", uid);

                    try
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // 绑定到 DataGridView 显示数据
                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("查询出错：" + ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin admin = new Admin();
            admin.Show();
        }
    }
}

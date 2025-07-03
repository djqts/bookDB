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
    public partial class Admin2 : Form
    {
        public Admin2()
        {
            InitializeComponent();
        }
        private void Admin2_Load(object sender, EventArgs e)
        {
            Table();
            label2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string id = label2.Text;
                DialogResult result = MessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM Book WHERE 书号 = '" + id + "';";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功！");
                        Table();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！" + sql);
                    }
                    dao.DaoClose();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请选择一行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //跳转到添加界面
            this.Hide();
            AddBook addBook = new AddBook();
            addBook.Show();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string author = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string publusher = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string inventory = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                //修改界面
                this.Hide();
                ModifyBook modifyBook = new ModifyBook(id, name, author, publusher, inventory);
                modifyBook.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        //书号查询
        private void SearchBookID()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = "SELECT * FROM Book WHERE 书号 LIKE '%" + textBox1.Text + "%'";//模糊查询
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
        private void button5_Click(object sender, EventArgs e)
        {
            SearchBookID();
        }


        //书号查询
        private void SearchBookName()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = "SELECT * FROM Book WHERE 书名 LIKE '%" + textBox2.Text + "%'";//模糊查询
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
        private void button6_Click(object sender, EventArgs e)
        {
            SearchBookName();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Table();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        //补充：并行查询

    }
}

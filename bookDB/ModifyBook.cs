using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookMS
{
    public partial class ModifyBook : Form

    {
        string ID = "";
        public ModifyBook(string ISBN, string bookName, string author, string publisher, string inventory)
        {
            InitializeComponent();
            ID = textBox1.Text = ISBN;
            textBox2.Text = bookName;
            textBox3.Text = author;
            textBox4.Text = publisher;
            textBox5.Text = inventory;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Book SET 书号 = '" + textBox1.Text + "', 书名 = '" + textBox2.Text + "', 作者 = '" + textBox3.Text + "', 出版社 = '" + textBox4.Text + "',库存 = '" + textBox5.Text + "' WHERE 书号 = '" + ID + "';";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
                //跳转到主界面
                this.Hide();
                Admin2 mainForm = new Admin2();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("修改失败！");
                this.Owner?.Show();
            }
        }
    }
}

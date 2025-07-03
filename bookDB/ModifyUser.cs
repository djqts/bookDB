using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bookMS
{
    public partial class ModifyUser : Form
    {
        public ModifyUser()
        {
            InitializeComponent();
        }

        string ID2 = "";
        public ModifyUser(string ID, string Name, string sex, string pwd)
        {
            InitializeComponent();
            ID2 = textBox1.Text = ID;
            textBox3.Text = Name;
            textBox2.Text = sex;
            textBox4.Text = pwd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Users SET id = '" + textBox1.Text + "', name = '" + textBox3.Text + "',sex = '" + textBox2.Text + "',psw = '" + textBox4.Text + "' WHERE id = '" + ID2 + "';";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
                //跳转到主界面
                this.Hide();
                UserManage mainForm = new UserManage();
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

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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void 图书查看和借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //借阅页面
            this.Hide();
            BookVB borrow = new BookVB();
            borrow.ShowDialog();
        }

        private void 当前借出图书和归还ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //借阅记录页面
            this.Hide();
            MyVB record = new MyVB();
            record.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}

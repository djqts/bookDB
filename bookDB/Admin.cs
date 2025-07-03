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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin2 a = new Admin2();
            a.ShowDialog();
        }

        private void 读者管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManage u = new UserManage();
            u.ShowDialog();
        }

        private void 借阅记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowRecord r = new BorrowRecord();
            r.ShowDialog();
        }

        private void 罚款管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View v = new View();
            v.ShowDialog();
        }
    }
}

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
            Table();
        }
        private void admin2_Load(object sender, EventArgs e)
        {
        }
        private void Table()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = "SELECT * FROM book";
            IDataReader dt = dao.ExecuteReader(sql);
            string a0,a1,a2,a3,a4,a5;
            while(dt.Read())
            {
                a0 = dt.GetString(0);
                a1 = dt.GetString(1);
                a2 = dt.GetString(2);
                a3 = dt.GetString(3);
                a4 = dt.GetString(4);
                a5 = dt.GetString(5);
                string[] row = { a0, a1, a2, a3, a4, a5 };
                dataGridView1.Rows.Add(row);
            }
            dt.Close();
            dao.DaoClose();

        }
    }
}

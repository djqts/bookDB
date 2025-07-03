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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            LoadBorrowRecords();
        }

        private void LoadBorrowRecords()
        {
            dataGridView1.Rows.Clear();

            string sql = "SELECT * FROM vw_BookInventory;";

            Dao dao = new Dao();

            try
            {
                using (IDataReader reader = dao.ExecuteReader(sql)) // 不需要参数
                {
                    while (reader.Read())
                    {
                        // 假设视图中有4列：书号, 书名, 当前库存, 总藏书量
                        string bookId = reader.GetString(0);
                        string bookName = reader.GetString(1);
                        int currentStock = reader.GetInt32(2);
                        int totalStock = reader.GetInt32(3);

                        dataGridView1.Rows.Add(bookId, bookName, currentStock, totalStock);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载图书库存失败：" + ex.Message);
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

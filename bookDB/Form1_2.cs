//using System;
//using System.Data;
//using System.Data.SqlClient;
//using System.Windows.Forms;

//namespace bookMS
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
//            {
//                MessageBox.Show("Please enter your name and password!");
//                return;
//            }

//            if (login())
//            {
//                MessageBox.Show("Welcome to bookMS!");
//            }
//            else
//            {
//                MessageBox.Show("Login failed!");
//            }
//        }

//        public bool login()
//        {
//            using (Dao dao = new Dao())
//            {
//                string role = radioButton1.Checked ? "user" : radioButton2.Checked ? "admin" : "";
//                if (string.IsNullOrEmpty(role))
//                {
//                    MessageBox.Show("Please select a role!");
//                    return false;
//                }

//                string sql = "SELECT * FROM user WHERE name=@name AND password=@password AND role=@role";
//                var parameters = new[]
//                {
//                    new SqlParameter("@name", textBox1.Text),
//                    new SqlParameter("@password", textBox2.Text),
//                    new SqlParameter("@role", role)
//                };

//                try
//                {
//                    IDataReader reader = dao.ExecuteReader(sql, parameters);
//                    bool result = reader.Read();
//                    reader.Close();

//                    if (result)
//                    {
//                        MessageBox.Show($"Login successful as {role}!");
//                    }

//                    return result;
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show($"An error occurred: {ex.Message}");
//                    return false;
//                }
//            }
//        }
//    }
//}




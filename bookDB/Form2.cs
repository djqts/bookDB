//using Microsoft.Data.SqlClient;
//using System.Data;


//namespace bookMS
//{
//    public partial class Form2 : Form
//    {
//        public Form2()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            if( (ReaderID.Text != "" && ReaderPwd.Text != "")||(AdminID.Text != ""&&AdminPwd.Text != ""))
//            {

//                MessageBox.Show("Welcome to bookMS!");
//                //login();
//            }
//            else
//            {
//                MessageBox.Show("Please enter your name and password!");
//            }
//        }
//        public bool login()
//        {
//            using (Dao dao = new Dao())
//            {
//                string role = P.Checked ? "user" : radioButton2.Checked ? "admin" : "";
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
//}

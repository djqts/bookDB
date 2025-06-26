using System.Data;

namespace bookMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "") 
            { 
                MessageBox.Show("Please enter your name and password!");
            }
            else
            {
                MessageBox.Show("Welcome to bookMS!");
                login();
            }
        }

        public void login()
        {
            //用户
            if (radioButton1.Checked == true)
            {
                Dao dao = new Dao();
                string sql = "select * from user where name='" + textBox1.Text + "' and password='" + textBox2.Text + "'";
                MessageBox.Show(sql);
                IDataReader reader = dao.ExecuteReader(sql);
                if (reader.Read())
                {
                    //将用户信息存入Data类
                    Data.UID = reader["id"].ToString();
                    Data.UName = reader["name"].ToString();

                    MessageBox.Show("Login successfully!");
                    //跳转到用户界面
                    User1 user = new User1();
                    this.Hide();
                    user.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Login failed!");
                }
                dao.DaoClose();
            }
            //管理员
            if (radioButton2.Checked == true)
            {
                Dao dao = new Dao();
                string sql = "select * from user where name='" + textBox1.Text + "' and password='" + textBox2.Text + "'";
                MessageBox.Show(sql);
                IDataReader reader = dao.ExecuteReader(sql);
                if (reader.Read())
                {
                    MessageBox.Show("Login successfully!");
                    //跳转到管理员界面
                    Admin admin = new Admin();
                    this.Hide();
                    admin.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Login failed!");
                }
                dao.DaoClose();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

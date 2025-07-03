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
            //�û�
            if (radioButton1.Checked == true)
            {
                Dao dao = new Dao();
                string sql = "select * from Users where id='" + textBox1.Text + "' and psw='" + textBox2.Text + "';";
                //MessageBox.Show(sql);
                IDataReader reader = dao.ExecuteReader(sql);
                if (reader.Read())
                {
                    //���û���Ϣ����Data��
                    Data.UID = reader["id"].ToString();
                    Data.UName = reader["name"].ToString();

                    MessageBox.Show("Login successfully!");
                    //��ת���û�����
                    User user = new User();
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
            //����Ա
            if (radioButton2.Checked == true)
            {
                Dao dao = new Dao();
                string sql = "select * from Admin where id='" + textBox1.Text + "' and pwd='" + textBox2.Text + "';";
                //MessageBox.Show(sql);
                IDataReader reader = dao.ExecuteReader(sql);
                if (reader.Read())
                {
                    MessageBox.Show("Login successfully!");
                    //��ת������Ա����
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
    }
}

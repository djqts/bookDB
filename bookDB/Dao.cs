using Microsoft.Data.SqlClient;

namespace bookMS
{
    // 定义一个内部类Dao，用于处理数据库操作
    internal class Dao
    {
        // 定义一个方法connect，用于建立并打开与数据库的连接
        SqlConnection sc;
        public SqlConnection connect()
        {
            // 定义连接字符串，指定数据源、初始目录和安全设置
            string connStr = "Data Source=LAPTOP-65KU8BHS;Initial Catalog=bookDB;Integrated Security=True";
            // 创建一个新的SqlConnection对象
            sc = new SqlConnection(connStr);
            // 打开数据库连接
            sc.Open();
            // 返回打开的数据库连接对象
            return sc;
        }

        // 定义一个方法command，用于创建SqlCommand对象
        public SqlCommand command(string sql)
        {
            // 使用传入的SQL字符串和connect方法返回的数据库连接创建SqlCommand对象
            SqlCommand cmd = new SqlCommand(sql, connect());
            // 返回SqlCommand对象
            return cmd;
        }

        // 定义一个方法Execte，用于执行读取操作的SQL语句
        public int Execute(string sql)
        {
            // 使用command方法创建SqlCommand对象
            SqlCommand cmd = command(sql);
            // 执行SQL语句并返回受影响的行数
            int rows = cmd.ExecuteNonQuery();
            // 返回受影响的行数
            return rows;
        }

        // 定义一个方法ExecteReader，用于执行返回结果集的SQL语句
        public SqlDataReader ExecuteReader(string sql)
        {
            // 使用command方法创建SqlCommand对象
            SqlCommand cmd = command(sql);
            // 执行SQL语句并返回结果集 SqlDataReader对象
            SqlDataReader reader = cmd.ExecuteReader();
            // 返回SqlDataReader对象
            return reader;
        }
        public void DaoClose()
        {
            sc.Close();
        }
    }
}

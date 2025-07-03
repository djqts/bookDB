using Microsoft.Data.SqlClient;
using System.Data;

public class SqlHelper
{
    // 数据库连接字符串
    private string connectionString;

    // 构造函数
    public SqlHelper(string connectionString)
    {
        this.connectionString = connectionString;
    }

    // 打开数据库连接
    private SqlConnection OpenConnection()
    {
        // 定义连接字符串，指定数据源、初始目录和安全设置
        string connStr = "Data Source=LAPTOP-65KU8BHS;Initial Catalog=bookDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        SqlConnection conn = new SqlConnection(connStr);

        if (conn.State != ConnectionState.Open)
        {
            conn.Open();
        }
        return conn;
    }

    // 关闭数据库连接
    private void CloseConnection(SqlConnection conn)
    {
        if (conn.State == ConnectionState.Open)
        {
            conn.Close();
        }
    }

    // 执行SQL查询，返回DataTable
    public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
    {
        DataTable dataTable = new DataTable();
        using (SqlConnection conn = OpenConnection())
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }
            CloseConnection(conn);
        }
        return dataTable;
    }

    // 执行SQL命令，返回影响的行数
    public int ExecuteCommand(string query, SqlParameter[] parameters = null)
    {
        int rowsAffected = 0;
        using (SqlConnection conn = OpenConnection())
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                rowsAffected = cmd.ExecuteNonQuery();
            }
            CloseConnection(conn);
        }
        return rowsAffected;
    }

    // 执行存储过程
    public int ExecuteStoredProcedure(string storedProcedureName, SqlParameter[] parameters = null)
    {
        int rowsAffected = 0;
        using (SqlConnection conn = OpenConnection())
        {
            using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                rowsAffected = cmd.ExecuteNonQuery();
            }
            CloseConnection(conn);
        }
        return rowsAffected;
    }

    // 使用事务执行多个操作
    public void ExecuteWithTransaction(Action<SqlConnection, SqlTransaction> action)
    {
        using (SqlConnection conn = OpenConnection())
        {
            SqlTransaction transaction = conn.BeginTransaction();
            try
            {
                action(conn, transaction);
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
            finally
            {
                CloseConnection(conn);
            }
        }
    }
}
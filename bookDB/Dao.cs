using Microsoft.Data.SqlClient;
using System.Data;

namespace bookMS
{
    internal class Dao : IDisposable
    {
        private SqlConnection _connection;
        private SqlTransaction _transaction;
        public static string connStr = "Data Source=LAPTOP-65KU8BHS;Initial Catalog=bookDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public SqlConnection Connect()
        {
            if (_connection == null || _connection.State != ConnectionState.Open)
            {
                _connection = new SqlConnection(connStr);
                _connection.Open();
            }
            return _connection;
        }

        public SqlCommand CreateCommand(string sql, params SqlParameter[] parameters)
        {
            var cmd = new SqlCommand(sql, Connect());
            cmd.Parameters.AddRange(parameters);

            if (_transaction != null)
                cmd.Transaction = _transaction;

            return cmd;
        }

        public int Execute(string sql, params SqlParameter[] parameters)
        {
            using (var cmd = CreateCommand(sql, parameters))
            {
                return cmd.ExecuteNonQuery();
            }
        }

        public SqlDataReader ExecuteReader(string sql, params SqlParameter[] parameters)
        {
            var cmd = CreateCommand(sql, parameters);
            return cmd.ExecuteReader();
        }

        public object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (var cmd = CreateCommand(sql, parameters))
            {
                return cmd.ExecuteScalar();
            }
        }

        public void BeginTransaction()
        {
            _transaction = Connect().BeginTransaction();
        }

        public void CommitTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Commit();
                _transaction = null;
            }
        }

        public void RollbackTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _transaction = null;
            }
        }

        public void DaoClose()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }

            if (_connection != null && _connection.State != ConnectionState.Closed)
            {
                _connection.Close();
                _connection.Dispose();
                _connection = null;
            }
        }

        public void Dispose()
        {
            DaoClose();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.DAL
{
    class DBHelper : IDisposable
    {
        string _connString = @"Data Source =SAIMA\SQLEXPRESS2012; Initial Catalog = loginDB; Integrated Security = True; Persist Security Info = True; ";
        SqlConnection _conn = null;
        public DBHelper()
        {
            _conn = new SqlConnection(_connString);
            _conn.Open();
        }
        public int ExecuteQuery(string sqlQuery)
        {
            SqlCommand command = new SqlCommand(sqlQuery, _conn);
            var count = command.ExecuteNonQuery();
            return count;
        }
        public Object ExecuteScalar(string sqlQuery)
        {
            SqlCommand command = new SqlCommand(sqlQuery, _conn);
             return command.ExecuteScalar();
        }
        public SqlDataReader ExecuteReader(string sqlQuery)
        {
            SqlCommand command = new SqlCommand(sqlQuery, _conn);
            return command.ExecuteReader();
        }

        public void Dispose()
        {
            if (_conn != null && _conn.State == System.Data.ConnectionState.Open)
                _conn.Close();
        }
    }
}

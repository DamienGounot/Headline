using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class DB
    {
        private static DB instance;

        public static DB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DB();
                }

                return instance;
            }
        }

        public SqlConnection connection;

        private DB()
        {
            string connectionString = @"Data Source=31.147.204.119\PISERVER,1433; Initial Catalog=TeamE6_DB; User=TeamE6_User; Password=^>gr@*+]";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public SqlDataReader GetDataReader(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            return command.ExecuteReader();
        }

        public object GetScalar(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            return command.ExecuteScalar();
        }

        public int ExecuteSql(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            return command.ExecuteNonQuery();
        }
    
}

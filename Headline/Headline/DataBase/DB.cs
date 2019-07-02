using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Headline.DataBase
{
    public class DB
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

        private string IsSetUsername(string username)
        {
            string sql = "SELECT * FROM Users WHERE Username='" + username + "'";
            return sql;
        }

        public bool CheckUserNotRegistered(string username)
        {
            SqlDataReader reader = DB.Instance.GetDataReader(
                DB.Instance.IsSetUsername(username));

            if (reader.Read()) // si user exist
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }

        }

        private string IsSetEmail(string email)
        {

            string querryMail = "SELECT * FROM Users WHERE email='" + email + "'";
            return querryMail;
        }

        public bool CheckEmailNotRegistered(string email)
        {
            SqlDataReader mailReader = DB.Instance.GetDataReader(DB.Instance.IsSetEmail(email));

            if (mailReader.Read())
            {
                mailReader.Close();
                return true;
            }
            else
            {

                mailReader.Close();
                return false;
            }
        }



        public void InsertNewUser(string username, string email, string password)
        {
            string space = " ";
            string insertQuerry = "INSERT INTO Users (username, email, password, favoriteKeyword, favoriteCountry) VALUES ('" + username + "','" + email + "','" + password + "','" + space + "','" + space + "')";
            SqlDataReader readerInsert = DB.Instance.GetDataReader(insertQuerry);
            readerInsert.Close();
        }

        public void UpdateUserPref(string username, string keyword, string country)
        {
            string sql = "UPDATE Users SET favoriteKeyword='" + keyword + "', favoriteCountry='" + country + "' WHERE Username='" + username + "'";
            SqlDataReader updatePref = DB.Instance.GetDataReader(sql);
            updatePref.Close();

        }

        public bool CheckLogin(string username, string password)
        {
            string sql = "SELECT * FROM Users WHERE Username='" + username + "' AND Password='" + password + "'";
            SqlDataReader reader = DB.Instance.GetDataReader(sql);

            if (reader.Read())
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }


        public string GetFavoriteCountry(string username)
        {
            string country;
            string sqlpref = "SELECT favoriteCountry FROM Users WHERE Username='" + username + "'";
            SqlDataReader retrievePref = DB.Instance.GetDataReader(sqlpref);
            retrievePref.Read();
            country = retrievePref.GetString(0);
            retrievePref.Close();
            return country;
        }

        public string GetFavoriteKeyword(string username)
        {
            string keyword;
            string sqlpref = "SELECT favoriteKeyword FROM Users WHERE Username='" + username + "'";
            SqlDataReader retrievePref = DB.Instance.GetDataReader(sqlpref);
            retrievePref.Read();
            keyword = retrievePref.GetString(0);
            retrievePref.Close();
            return keyword;
        }

    }

}

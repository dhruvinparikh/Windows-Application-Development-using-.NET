using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydroConsumerManagement
{
    class CLoginDB
    {
        public static List<CLogin> getAll()
        {
            List<CLogin> logins = new List<CLogin>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.CommandText = "select * from login";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = DBUtil.getSqlConnection();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CLogin login = new CLogin();
                login.Username = reader[0].ToString();
                login.Password = reader[1].ToString();
                logins.Add(login);
            }
            return logins;
        }

        public static void updatePassword(CLogin login)
        {
            SqlCommand sqlCommand = new SqlCommand("update login set password = @id where username = @fn", DBUtil.getSqlConnection());
            sqlCommand.Parameters.AddWithValue("@id", login.Password);
            sqlCommand.Parameters.AddWithValue("@fn", login.Username);
            sqlCommand.ExecuteNonQuery();
        }

        public static void add(CLogin login)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into login values (@id,@fn)", DBUtil.getSqlConnection());
            sqlCommand.Parameters.AddWithValue("@id", login.Username);
            sqlCommand.Parameters.AddWithValue("@fn", login.Password);
            sqlCommand.ExecuteNonQuery();
        }
    }
}

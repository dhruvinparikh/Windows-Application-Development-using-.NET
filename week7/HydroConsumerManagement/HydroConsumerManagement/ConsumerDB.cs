using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydroConsumerManagement
{
    class ConsumerDB
    {
        public static void add(Consumer consumer)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into consumer values (@id,@fn,@ln,@cn,@ba,@d,@p)", DBUtil.getSqlConnection());
            sqlCommand.Parameters.AddWithValue("@id", consumer.ConsumerID);
            sqlCommand.Parameters.AddWithValue("@fn", consumer.FirstName);
            sqlCommand.Parameters.AddWithValue("@ln", consumer.LastName);
            sqlCommand.Parameters.AddWithValue("@cn", consumer.City);
            sqlCommand.Parameters.AddWithValue("@ba", consumer.BillAmount);
            sqlCommand.Parameters.AddWithValue("@d", consumer.DueDate);
            sqlCommand.Parameters.AddWithValue("@p", 0);
            sqlCommand.ExecuteNonQuery();
        }

        public static SqlDataAdapter getConsumerID(String id)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from consumer where consumerid like '" + id + "%'", DBUtil.getSqlConnection());
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            return sda;
        }

        public static SqlDataAdapter getConsumerFirstNameLike(String strName)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from consumer where firstname like '" + strName + "%'", DBUtil.getSqlConnection());
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            return sda;
        }

        public static SqlDataAdapter getConsumerFirstName(String strName)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from consumer where firstname = '" + strName + "'", DBUtil.getSqlConnection());
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            return sda;
        }

        public static SqlDataAdapter getConsumerLastNameLike(String strName)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from consumer where lastname like '" + strName + "%'", DBUtil.getSqlConnection());
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            return sda;
        }

        public static SqlDataAdapter getConsumerLastName(String strName)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from consumer where lastname = '" + strName + "'", DBUtil.getSqlConnection());
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            return sda;
        }

        public static SqlDataAdapter getConsumerCityLike(String strName)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from consumer where city like '" + strName + "%'", DBUtil.getSqlConnection());
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            return sda;
        }

        public static SqlDataAdapter getConsumerCity(String strName)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from consumer where city = '" + strName + "'", DBUtil.getSqlConnection());
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            return sda;
        }

        public static SqlDataAdapter getDefaulter(DateTime date)
        {
            SqlCommand cmd = new SqlCommand("select * from consumer where duedate < @d and paid = 0", DBUtil.getSqlConnection());
            cmd.Parameters.AddWithValue("@d", date);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            return sda;
        }

        public static SqlDataAdapter getRegular(DateTime date)
        {
            SqlCommand cmd = new SqlCommand("select * from consumer where duedate >= @d and (paid = 1 or paid = 0)", DBUtil.getSqlConnection());
            cmd.Parameters.AddWithValue("@d", date);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            return sda;
        }

        public static SqlDataAdapter getBAGT(Double billAmount)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from consumer where billamount > " + billAmount, DBUtil.getSqlConnection());
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            return sda;
        }

        public static SqlDataAdapter getBALT(Double billAmount)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from consumer where billamount < " + billAmount, DBUtil.getSqlConnection());
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            return sda;
        }

        public static SqlDataAdapter getBAGTE(Double billAmount)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from consumer where billamount >= " + billAmount, DBUtil.getSqlConnection());
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            return sda;
        }

        public static SqlDataAdapter getBALTE(Double billAmount)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from consumer where billamount <= " + billAmount, DBUtil.getSqlConnection());
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            return sda;
        }

        public static SqlDataAdapter getBAE(Double billAmount)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from consumer where billamount = " + billAmount, DBUtil.getSqlConnection());
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            return sda;
        }

        public static SqlDataAdapter getAll()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from consumer", DBUtil.getSqlConnection());
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            return sda;
        }

        public static SqlDataAdapter deleteID(String id)
        {
            SqlDataAdapter sda = new SqlDataAdapter("delete from consumer where consumerID = '" + id + "'", DBUtil.getSqlConnection());
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            return sda;
        }
    }
}

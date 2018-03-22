using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTFirstNameLastName
{
    class PaymentDB
    {
        public static void add(PaymentClass p)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into payment values (@id,@fn,@ln,@cn,@ba,@d)", DBUtil.getSqlConnection());
            sqlCommand.Parameters.AddWithValue("@id", p.Billing);
            sqlCommand.Parameters.AddWithValue("@fn", p.CreditCardType);
            sqlCommand.Parameters.AddWithValue("@ln", p.CreditCardNumber);
            sqlCommand.Parameters.AddWithValue("@cn", p.ExpirationMonth);
            sqlCommand.Parameters.AddWithValue("@ba", p.ExpirationYear.ToString());
            sqlCommand.Parameters.AddWithValue("@d", p.DefaultBillingPeriod);
            sqlCommand.ExecuteNonQuery();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTFirstNameLastName
{
    public class PaymentClass
    {
        String billing;
        String creditCardType;
        String creditCardNumber;
        int expirationYear;
        String expirationMonth;
        char defaultBillingPeriod;

        public string Billing { get => billing; set => billing = value; }
        public string CreditCardType { get => creditCardType; set => creditCardType = value; }
        public string CreditCardNumber { get => creditCardNumber; set => creditCardNumber = value; }
        public string ExpirationMonth { get => expirationMonth; set => expirationMonth = value; }
        public int ExpirationYear { get => expirationYear; set => expirationYear = value; }
        public char DefaultBillingPeriod { get => defaultBillingPeriod; set => defaultBillingPeriod = value; }
    }
}

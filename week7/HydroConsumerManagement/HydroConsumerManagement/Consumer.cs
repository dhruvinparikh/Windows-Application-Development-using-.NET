using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydroConsumerManagement
{
    class Consumer
    {
        private long consumerID;
        private String firstName;
        private String lastName;
        private String city;
        private double billAmount;
        private DateTime dueDate;

        public Consumer():this(0, "", "", "", 0, new DateTime().Date)
        {
           
        }

        public Consumer(long consumerID,String firstName,String lastName,String city,double billAmount,DateTime dueDate)
        {
            this.consumerID = consumerID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;
            this.billAmount = billAmount;
            this.dueDate = dueDate;
        }
        
        public void setConsumerID(long consumerID)
        {

            if (consumerID < 10000000000L || consumerID > 99999999999L)
            {
                throw new ConsumerIDException();
            }
            else
            {
                this.consumerID = consumerID;
            }
        }
        public long ConsumerID {get => consumerID; set => consumerID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string City { get => city; set => city = value; }
        public double BillAmount { get => billAmount; set => billAmount = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }
    }
}

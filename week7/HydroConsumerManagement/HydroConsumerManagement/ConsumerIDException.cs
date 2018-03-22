using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydroConsumerManagement
{
    class ConsumerIDException : Exception
    {
        public ConsumerIDException()
            :this("Consumer ID must be 11 digits")
        {   
        }

        public ConsumerIDException(String message) :base(message)
        {
           
        }
    }
}

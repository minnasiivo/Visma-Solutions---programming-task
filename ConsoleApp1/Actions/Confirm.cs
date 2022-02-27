using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Confirm
    {
        string source;
        string paymentNumber;

        public Confirm(string confirm, string paymentNumber)
        {
            this.source = confirm;
            this.paymentNumber = paymentNumber;
        }

        public void returnConfirm()
        {
            Console.WriteLine("Action source for confirm is:" + this.source);
            Console.WriteLine("And payment number is:" + this.paymentNumber);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Sign
    {
        string source;
        Guid documentid;

        public Sign(string source, Guid documentid)
        {
            this.source = source;
            this.documentid = documentid;
        }

        public void returnSign()
        {
            Console.WriteLine("Action source for sign is: " + this.source);
            Console.WriteLine("And document ID is: " + this.documentid);
        }
    }
}

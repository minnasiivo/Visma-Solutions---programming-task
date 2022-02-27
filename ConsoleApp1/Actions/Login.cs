using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Login
    {
        string source;

        public Login(string source)
        {
            this.source = source;
        }
        public void returnLogin()
        {
            Console.WriteLine("Action source for login is:" +  this.source);
        }
    }
}

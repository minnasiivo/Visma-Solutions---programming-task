using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace ConsoleApp1
{
    class Uri
    {

        public string uri { get; set; }

        public Uri(string uri)
        {
            this.uri = uri;
        }

        public void useUri(string uri) 
        {
           

            uri = this.uri;
             
            if (uri.StartsWith("visma-identity")){
                validateActionPath(uri);
            }
            else
            {
               Console.WriteLine("invalid URI scheme");
            }

        }

        private void validateActionPath(string uri)
        {


            if (uri.Contains("login")) {
                string source;
                source = getBetween(uri, "=");
                Login login = new Login(source);
                login.returnLogin();
            
            }else if (uri.Contains("confirm"))
            {
                string source;
                string paymentNumber;
                source = getSource(uri, "=", "&");
                paymentNumber = getBetween(uri, "number=");
                Confirm confirm = new Confirm(source, paymentNumber);
                confirm.returnConfirm();

            }
            else if (uri.Contains("sign"))
            {
                string source;
                Guid documentID;
                source = getSource(uri, "=", "&");
               string documentIDstring = getBetween(uri, "id=");
              
                documentID = Guid.Parse(documentIDstring);
                Sign sign = new Sign(source, documentID);
                sign.returnSign();

            }
            else
            {
                Console.WriteLine("invalid Action path");
            }


        }


        public string getBetween(string uri, string stringStart)
        {
            int Start;
            Start = uri.IndexOf(stringStart, 0);
            int sourceLenght = uri.Length - Start- stringStart.Length;
        return uri.Substring(uri.Length-sourceLenght);
        }

        public string getSource(string uri, string startswith, string endswith)
        {
            int StartIndex = uri.IndexOf(startswith, 0) + startswith.Length;
            int EndIndex = uri.IndexOf(endswith, StartIndex);
            string result = uri.Substring(StartIndex, EndIndex - StartIndex);
            return result;

        }

       

    }
}

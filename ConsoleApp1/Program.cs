using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // this is a console application, that first asks the URI
            // then checks that the scheme is right.
            // After that validates the action
            // Then it writes to console the parameters for that action


            Console.WriteLine("Enter URI here");

           string userURI = Console.ReadLine();

        Uri newUri = new Uri(userURI);

            if (userURI != null)
            {
                newUri.useUri(userURI);
            }
      
        }
    }
}

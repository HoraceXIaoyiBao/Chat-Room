using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            client c = new client("127.0.0.1",1234);
            while (true)
            {
                Console.WriteLine("Client:");
                string message;
                message =   Console.ReadLine();
                if (message == "e") break;
                c.Connection(message);
            }
        }
    }
}

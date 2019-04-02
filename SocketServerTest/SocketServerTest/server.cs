using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace SocketServerTest
{
    class server
    {
        Socket listen;

        public void startserver()
        {
            Console.WriteLine("JOY");

             listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress ipadd = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipep = new IPEndPoint(ipadd, 1234);
            listen.Bind(ipep);
            listen.Listen(0);

            Console.WriteLine("the server has already been started");
          //  sf.ConsolePanel.Text= "the server has already been started";
           
        }

        public void startlisten()
        {
            while (true)
            {
                Socket con = listen.Accept();
                //Console.WriteLine("The server Accept");

                byte[] readBuff = new byte[1024];
                int count = con.Receive(readBuff);
                string str = System.Text.Encoding.UTF8.GetString(readBuff, 0, count);

                Console.WriteLine("Client:" + str+"\n");
                string receive;
                Console.WriteLine("Server:");
                receive =Console.ReadLine();
                
                byte[] bytes = System.Text.Encoding.Default.GetBytes(receive);
                con.Send(bytes);
            }
        }
    }

}

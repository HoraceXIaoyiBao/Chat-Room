using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace SocketServerTest
{
    class client
    {
        Socket socket;

        const int BUFFER_SIZE = 1024;
        byte[] readBuff = new byte[BUFFER_SIZE];

        public void Connection()
        {
            this.socket=new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            string hosting = "127.0.0.1";
            int port = 1234;
            socket.Connect(hosting, port);

            string str = "this is Joy lx sb";
            byte[] bytes = System.Text.Encoding.Default.GetBytes(str);
            socket.Send(bytes);

            int count = socket.Receive(readBuff);

            str = System.Text.Encoding.UTF8.GetString(readBuff, 0, count);
            Console.WriteLine("the client receive: "+ str);
            socket.Close();

        }


  
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Client
{
    class client
    {
        Socket socket;

        private string destinationIPaddress;
        private int destinationPort;

        const int BUFFER_SIZE = 1024;
        byte[] readBuff = new byte[BUFFER_SIZE];

        public client(string destinationIPaddress,int destinationPort)
        {
            this.destinationIPaddress = destinationIPaddress;
            this.destinationPort = destinationPort;
        }


        public void Connection(string hosting, int port)
        {
            this.socket=new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socket.Connect(hosting, port);

            Thread threadConnect = new Thread(receiveMsg);
            threadConnect.IsBackground = true;
            threadConnect.Start();


           

        }
        public void receiveMsg()
        {
            int count = socket.Receive(readBuff);

           string  str = System.Text.Encoding.UTF8.GetString(readBuff, 0, count);
            Console.WriteLine("Server:" + str);
            socket.Close();
        }
        public void sendMsg(string contents)
        {
            string str = contents;
            //Console.WriteLine("Client :"+str);
            byte[] bytes = System.Text.Encoding.Default.GetBytes(str);
            Console.WriteLine("message sent!");
            socket.Send(bytes);

           
        }


  
    }


}

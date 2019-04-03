using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;

namespace SocketServerTest
{
    class server
    {


        Thread threadWatch = null;//负责监听客户端请求的线程
  
        Socket socketWatch = null;//负责监听服务端的套接字

        //储存服务器上所有的通信套接字
        Dictionary<string, Socket> dictSocket = new Dictionary<string, Socket>();

        //储存服务器上所有的通信线程
        Dictionary<string, Socket> dictThread = new Dictionary<string, Socket>();


       // Socket listen;

        public void startWatch()
        {
            Console.WriteLine("JOY");

            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress ipadd = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipep = new IPEndPoint(ipadd, 1234);
            socketWatch.Bind(ipep);

            socketWatch.Listen(10);//监听队列

            threadWatch = new Thread(startListen);
            threadWatch.IsBackground = true;//设为后台线程
            threadWatch.Start();

            Console.WriteLine("the server has already been started");
          //  sf.ConsolePanel.Text= "the server has already been started";
           
        }

        public void startListen()
        {
            while (true)
            {
                //如果没有连接请求， 当前线程会卡在accept这里，直到有请求
                Socket con = socketWatch.Accept();

                //Console.WriteLine("The server Accept");

                //若有消息，声明一个新的线程去负责接收消息
                Thread threadCommunication = new Thread(ReceiveMessage);
                threadCommunication.IsBackground = true;
                threadCommunication.Start(con);


            }
        }

        public void ReceiveMessage(object socketClientPara)
        {
            Socket con = socketClientPara as Socket;
            byte[] readBuff = new byte[1024];
            int count = con.Receive(readBuff);
            string str = System.Text.Encoding.UTF8.GetString(readBuff, 0, count);

            Console.WriteLine("Client:" + str + "\n");
            //string receive;
            //Console.WriteLine("Server:");
            //receive = Console.ReadLine();

            //byte[] bytes = System.Text.Encoding.Default.GetBytes(receive);
            //con.Send(bytes);
        }
    }

}

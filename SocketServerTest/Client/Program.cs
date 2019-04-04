using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientForm cf = new ClientForm();

            Application.Run(cf);
        }
    }
}

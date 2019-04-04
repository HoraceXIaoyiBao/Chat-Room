using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : Form
    {

        client c;
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ButtConnet_Click(object sender, EventArgs e)
        {
            string destinationIP = DestinationIP.Text;
            int destinationEndPort;
               bool result= int.TryParse(  DestinationEndPort.Text ,out  destinationEndPort);
            c =new client(destinationIP, destinationEndPort);
            c.Connection(destinationIP, destinationEndPort);
            string chatname = Chatname.Text;
            c.sendMsg(chatname);

        }

        private void ButtSend_Click(object sender, EventArgs e)
        {
            string contents = SendContents.Text;
            c.sendMsg(contents);
            SendContents.Text = "";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketServerTest
{
  
    public partial class ServerForm : Form
    {
        server s;
        public ServerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             s = new server(this);
            s.startWatch();
            ConsolePanel.Text = "server started";
            button1.Enabled = false;
          //  s.startListen();
        }

       
    }
}

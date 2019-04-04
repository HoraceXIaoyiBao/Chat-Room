namespace Client
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SendContents = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DestinationIP = new System.Windows.Forms.TextBox();
            this.DestinationEndPort = new System.Windows.Forms.TextBox();
            this.ButtConnet = new System.Windows.Forms.Button();
            this.ButtSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Chatname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendContents
            // 
            this.SendContents.Location = new System.Drawing.Point(257, 286);
            this.SendContents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SendContents.Multiline = true;
            this.SendContents.Name = "SendContents";
            this.SendContents.Size = new System.Drawing.Size(367, 122);
            this.SendContents.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 32);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(604, 231);
            this.textBox2.TabIndex = 1;
            // 
            // DestinationIP
            // 
            this.DestinationIP.Location = new System.Drawing.Point(20, 286);
            this.DestinationIP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DestinationIP.Name = "DestinationIP";
            this.DestinationIP.Size = new System.Drawing.Size(209, 25);
            this.DestinationIP.TabIndex = 3;
            // 
            // DestinationEndPort
            // 
            this.DestinationEndPort.Location = new System.Drawing.Point(20, 336);
            this.DestinationEndPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DestinationEndPort.Name = "DestinationEndPort";
            this.DestinationEndPort.Size = new System.Drawing.Size(209, 25);
            this.DestinationEndPort.TabIndex = 2;
            // 
            // ButtConnet
            // 
            this.ButtConnet.Location = new System.Drawing.Point(16, 415);
            this.ButtConnet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtConnet.Name = "ButtConnet";
            this.ButtConnet.Size = new System.Drawing.Size(211, 37);
            this.ButtConnet.TabIndex = 4;
            this.ButtConnet.Text = "Connect To Server";
            this.ButtConnet.UseVisualStyleBackColor = true;
            this.ButtConnet.Click += new System.EventHandler(this.ButtConnet_Click);
            // 
            // ButtSend
            // 
            this.ButtSend.Location = new System.Drawing.Point(483, 415);
            this.ButtSend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtSend.Name = "ButtSend";
            this.ButtSend.Size = new System.Drawing.Size(143, 37);
            this.ButtSend.TabIndex = 5;
            this.ButtSend.Text = "Send";
            this.ButtSend.UseVisualStyleBackColor = true;
            this.ButtSend.Click += new System.EventHandler(this.ButtSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chat Room";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "IP Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 365);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Chat Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Chatname
            // 
            this.Chatname.Location = new System.Drawing.Point(20, 384);
            this.Chatname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Chatname.Name = "Chatname";
            this.Chatname.Size = new System.Drawing.Size(209, 25);
            this.Chatname.TabIndex = 9;
            this.Chatname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 466);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Chatname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtSend);
            this.Controls.Add(this.ButtConnet);
            this.Controls.Add(this.DestinationIP);
            this.Controls.Add(this.DestinationEndPort);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SendContents);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SendContents;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox DestinationIP;
        private System.Windows.Forms.TextBox DestinationEndPort;
        private System.Windows.Forms.Button ButtConnet;
        private System.Windows.Forms.Button ButtSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Chatname;
    }
}
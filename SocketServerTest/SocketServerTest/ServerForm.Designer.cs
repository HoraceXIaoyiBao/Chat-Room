namespace SocketServerTest
{
    partial class ServerForm
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Receive = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConsoleLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ConsolePanel = new System.Windows.Forms.TextBox();
            this.ReceiveBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(305, 257);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 1;
            // 
            // Receive
            // 
            this.Receive.AutoSize = true;
            this.Receive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Receive.Location = new System.Drawing.Point(12, 12);
            this.Receive.Name = "Receive";
            this.Receive.Size = new System.Drawing.Size(74, 20);
            this.Receive.TabIndex = 2;
            this.Receive.Text = "Receive:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(118, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Send Back:";
            // 
            // ConsoleLabel
            // 
            this.ConsoleLabel.AutoSize = true;
            this.ConsoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ConsoleLabel.Location = new System.Drawing.Point(259, 291);
            this.ConsoleLabel.Name = "ConsoleLabel";
            this.ConsoleLabel.Size = new System.Drawing.Size(92, 26);
            this.ConsoleLabel.TabIndex = 5;
            this.ConsoleLabel.Text = "Console";
            this.ConsoleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(143, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.Location = new System.Drawing.Point(351, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Send Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ConsolePanel
            // 
            this.ConsolePanel.Location = new System.Drawing.Point(162, 337);
            this.ConsolePanel.MaximumSize = new System.Drawing.Size(300, 200);
            this.ConsolePanel.Multiline = true;
            this.ConsolePanel.Name = "ConsolePanel";
            this.ConsolePanel.Size = new System.Drawing.Size(300, 131);
            this.ConsolePanel.TabIndex = 8;
            // 
            // ReceiveBox
            // 
            this.ReceiveBox.FormattingEnabled = true;
            this.ReceiveBox.Location = new System.Drawing.Point(16, 51);
            this.ReceiveBox.Name = "ReceiveBox";
            this.ReceiveBox.Size = new System.Drawing.Size(573, 173);
            this.ReceiveBox.TabIndex = 9;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 561);
            this.Controls.Add(this.ReceiveBox);
            this.Controls.Add(this.ConsolePanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConsoleLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Receive);
            this.Controls.Add(this.textBox2);
            this.Name = "ServerForm";
            this.Text = "ServerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Receive;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label ConsoleLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox ConsolePanel;
        public System.Windows.Forms.ListBox ReceiveBox;
    }
}
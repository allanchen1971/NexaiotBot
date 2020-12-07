namespace TestBot
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_SYS = new System.Windows.Forms.TextBox();
            this.textBox_CPU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_IoTHubString = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_DeviceName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_Event = new System.Windows.Forms.Label();
            this.label_SentToIoTHub = new System.Windows.Forms.Label();
            this.button_End = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_SYS);
            this.panel1.Controls.Add(this.textBox_CPU);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(45, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 97);
            this.panel1.TabIndex = 1;
            // 
            // textBox_SYS
            // 
            this.textBox_SYS.Location = new System.Drawing.Point(135, 64);
            this.textBox_SYS.Name = "textBox_SYS";
            this.textBox_SYS.Size = new System.Drawing.Size(100, 20);
            this.textBox_SYS.TabIndex = 3;
            // 
            // textBox_CPU
            // 
            this.textBox_CPU.Location = new System.Drawing.Point(135, 19);
            this.textBox_CPU.Name = "textBox_CPU";
            this.textBox_CPU.Size = new System.Drawing.Size(100, 20);
            this.textBox_CPU.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SYS Temp :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU Temp :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_IoTHubString);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox_User);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_DeviceName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(45, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 132);
            this.panel2.TabIndex = 2;
            // 
            // textBox_IoTHubString
            // 
            this.textBox_IoTHubString.Location = new System.Drawing.Point(155, 61);
            this.textBox_IoTHubString.Name = "textBox_IoTHubString";
            this.textBox_IoTHubString.Size = new System.Drawing.Size(100, 20);
            this.textBox_IoTHubString.TabIndex = 9;
            this.textBox_IoTHubString.Text = "HostName=Bot-IOTHub.azure-devices.net;DeviceId=BotTest;SharedAccessKey=uIM96ob2Vf" +
    "RZrgXtvCiiN8GgWtedAsI2Yz/rZeMk6n8=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "IoTHub string :";
            // 
            // textBox_User
            // 
            this.textBox_User.Location = new System.Drawing.Point(155, 98);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(100, 20);
            this.textBox_User.TabIndex = 7;
            this.textBox_User.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "User  :";
            // 
            // textBox_DeviceName
            // 
            this.textBox_DeviceName.Location = new System.Drawing.Point(155, 22);
            this.textBox_DeviceName.Name = "textBox_DeviceName";
            this.textBox_DeviceName.Size = new System.Drawing.Size(100, 20);
            this.textBox_DeviceName.TabIndex = 5;
            this.textBox_DeviceName.Text = "BotTest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Device Name :";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_Event
            // 
            this.label_Event.AutoSize = true;
            this.label_Event.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Event.Location = new System.Drawing.Point(61, 369);
            this.label_Event.Name = "label_Event";
            this.label_Event.Size = new System.Drawing.Size(134, 20);
            this.label_Event.TabIndex = 3;
            this.label_Event.Text = "Got Command :";
            // 
            // label_SentToIoTHub
            // 
            this.label_SentToIoTHub.AutoSize = true;
            this.label_SentToIoTHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SentToIoTHub.Location = new System.Drawing.Point(61, 400);
            this.label_SentToIoTHub.Name = "label_SentToIoTHub";
            this.label_SentToIoTHub.Size = new System.Drawing.Size(57, 20);
            this.label_SentToIoTHub.TabIndex = 4;
            this.label_SentToIoTHub.Text = "Sent :";
            // 
            // button_End
            // 
            this.button_End.Location = new System.Drawing.Point(225, 276);
            this.button_End.Name = "button_End";
            this.button_End.Size = new System.Drawing.Size(75, 23);
            this.button_End.TabIndex = 5;
            this.button_End.Text = "End";
            this.button_End.UseVisualStyleBackColor = true;
            this.button_End.Click += new System.EventHandler(this.button_End_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "test(sent data)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_End);
            this.Controls.Add(this.label_SentToIoTHub);
            this.Controls.Add(this.label_Event);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_SYS;
        private System.Windows.Forms.TextBox textBox_CPU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_DeviceName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Event;
        private System.Windows.Forms.Label label_SentToIoTHub;
        private System.Windows.Forms.TextBox textBox_IoTHubString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_End;
        private System.Windows.Forms.Button button2;
    }
}


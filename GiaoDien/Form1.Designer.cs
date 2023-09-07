
namespace doan_vxl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_StopBit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Parity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_DataBit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_BaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Port = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.BieuDo = new ZedGraph.ZedGraphControl();
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.grp_Transmitter = new System.Windows.Forms.GroupBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.txt_Send = new System.Windows.Forms.TextBox();
            this.btnLED1 = new System.Windows.Forms.Button();
            this.btnLED2 = new System.Windows.Forms.Button();
            this.btnLED3 = new System.Windows.Forms.Button();
            this.btnLED4 = new System.Windows.Forms.Button();
            this.btnLED5 = new System.Windows.Forms.Button();
            this.btnLED6 = new System.Windows.Forms.Button();
            this.btnLED7 = new System.Windows.Forms.Button();
            this.btnLED0 = new System.Windows.Forms.Button();
            this.btnAllON = new System.Windows.Forms.Button();
            this.btnAllOFF = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.txtMinValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTBValue = new System.Windows.Forms.TextBox();
            this.txtCurrentData = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grp_Transmitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmb_StopBit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmb_Parity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_DataBit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_BaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_Port);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 571);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Serial Port";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Mặc định";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_StopBit
            // 
            this.cmb_StopBit.FormattingEnabled = true;
            this.cmb_StopBit.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cmb_StopBit.Location = new System.Drawing.Point(105, 141);
            this.cmb_StopBit.Name = "cmb_StopBit";
            this.cmb_StopBit.Size = new System.Drawing.Size(121, 24);
            this.cmb_StopBit.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Stop Bit";
            // 
            // cmb_Parity
            // 
            this.cmb_Parity.FormattingEnabled = true;
            this.cmb_Parity.Location = new System.Drawing.Point(105, 111);
            this.cmb_Parity.Name = "cmb_Parity";
            this.cmb_Parity.Size = new System.Drawing.Size(121, 24);
            this.cmb_Parity.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Parity ";
            // 
            // cmb_DataBit
            // 
            this.cmb_DataBit.FormattingEnabled = true;
            this.cmb_DataBit.Location = new System.Drawing.Point(105, 78);
            this.cmb_DataBit.Name = "cmb_DataBit";
            this.cmb_DataBit.Size = new System.Drawing.Size(121, 24);
            this.cmb_DataBit.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Bỉt";
            // 
            // cmb_BaudRate
            // 
            this.cmb_BaudRate.FormattingEnabled = true;
            this.cmb_BaudRate.Location = new System.Drawing.Point(105, 48);
            this.cmb_BaudRate.Name = "cmb_BaudRate";
            this.cmb_BaudRate.Size = new System.Drawing.Size(121, 24);
            this.cmb_BaudRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate";
            // 
            // cmb_Port
            // 
            this.cmb_Port.FormattingEnabled = true;
            this.cmb_Port.Location = new System.Drawing.Point(105, 18);
            this.cmb_Port.Name = "cmb_Port";
            this.cmb_Port.Size = new System.Drawing.Size(121, 24);
            this.cmb_Port.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Disconnect);
            this.groupBox2.Controls.Add(this.btn_Connect);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(8, 439);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Port Control";
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(144, 77);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(82, 26);
            this.btn_Disconnect.TabIndex = 2;
            this.btn_Disconnect.Text = "Ngắt";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(7, 77);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 26);
            this.btn_Connect.TabIndex = 1;
            this.btn_Connect.Text = "Kết nối";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 32);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(232, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCurrentData);
            this.groupBox3.Location = new System.Drawing.Point(258, 674);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 106);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receiver";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(418, 439);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 22;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // BieuDo
            // 
            this.BieuDo.Location = new System.Drawing.Point(4, -4);
            this.BieuDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BieuDo.Name = "BieuDo";
            this.BieuDo.ScrollGrace = 0D;
            this.BieuDo.ScrollMaxX = 0D;
            this.BieuDo.ScrollMaxY = 0D;
            this.BieuDo.ScrollMaxY2 = 0D;
            this.BieuDo.ScrollMinX = 0D;
            this.BieuDo.ScrollMinY = 0D;
            this.BieuDo.ScrollMinY2 = 0D;
            this.BieuDo.Size = new System.Drawing.Size(966, 434);
            this.BieuDo.TabIndex = 3;
            this.BieuDo.UseExtendedPrintDialog = true;
            // 
            // SerialPort1
            // 
            this.SerialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // grp_Transmitter
            // 
            this.grp_Transmitter.Controls.Add(this.btn_Send);
            this.grp_Transmitter.Controls.Add(this.txt_Send);
            this.grp_Transmitter.Location = new System.Drawing.Point(264, 515);
            this.grp_Transmitter.Name = "grp_Transmitter";
            this.grp_Transmitter.Size = new System.Drawing.Size(229, 99);
            this.grp_Transmitter.TabIndex = 4;
            this.grp_Transmitter.TabStop = false;
            this.grp_Transmitter.Text = "Transmitter";
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(65, 70);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(73, 29);
            this.btn_Send.TabIndex = 1;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txt_Send
            // 
            this.txt_Send.Location = new System.Drawing.Point(20, 21);
            this.txt_Send.Multiline = true;
            this.txt_Send.Name = "txt_Send";
            this.txt_Send.Size = new System.Drawing.Size(192, 43);
            this.txt_Send.TabIndex = 0;
            // 
            // btnLED1
            // 
            this.btnLED1.Location = new System.Drawing.Point(587, 466);
            this.btnLED1.Name = "btnLED1";
            this.btnLED1.Size = new System.Drawing.Size(59, 43);
            this.btnLED1.TabIndex = 6;
            this.btnLED1.Text = "LED1";
            this.btnLED1.UseVisualStyleBackColor = true;
            this.btnLED1.Click += new System.EventHandler(this.btnLED1_Click);
            // 
            // btnLED2
            // 
            this.btnLED2.Location = new System.Drawing.Point(652, 466);
            this.btnLED2.Name = "btnLED2";
            this.btnLED2.Size = new System.Drawing.Size(63, 43);
            this.btnLED2.TabIndex = 7;
            this.btnLED2.Text = "LED2";
            this.btnLED2.UseVisualStyleBackColor = true;
            this.btnLED2.Click += new System.EventHandler(this.btnLED2_Click);
            // 
            // btnLED3
            // 
            this.btnLED3.Location = new System.Drawing.Point(721, 466);
            this.btnLED3.Name = "btnLED3";
            this.btnLED3.Size = new System.Drawing.Size(59, 43);
            this.btnLED3.TabIndex = 8;
            this.btnLED3.Text = "LED3";
            this.btnLED3.UseVisualStyleBackColor = true;
            this.btnLED3.Click += new System.EventHandler(this.btnLED3_Click);
            // 
            // btnLED4
            // 
            this.btnLED4.Location = new System.Drawing.Point(518, 525);
            this.btnLED4.Name = "btnLED4";
            this.btnLED4.Size = new System.Drawing.Size(59, 42);
            this.btnLED4.TabIndex = 9;
            this.btnLED4.Text = "LED4";
            this.btnLED4.UseVisualStyleBackColor = true;
            this.btnLED4.Click += new System.EventHandler(this.btnLED4_Click);
            // 
            // btnLED5
            // 
            this.btnLED5.Location = new System.Drawing.Point(587, 525);
            this.btnLED5.Name = "btnLED5";
            this.btnLED5.Size = new System.Drawing.Size(59, 42);
            this.btnLED5.TabIndex = 10;
            this.btnLED5.Text = "LED5";
            this.btnLED5.UseVisualStyleBackColor = true;
            this.btnLED5.Click += new System.EventHandler(this.btnLED5_Click);
            // 
            // btnLED6
            // 
            this.btnLED6.Location = new System.Drawing.Point(652, 525);
            this.btnLED6.Name = "btnLED6";
            this.btnLED6.Size = new System.Drawing.Size(63, 42);
            this.btnLED6.TabIndex = 11;
            this.btnLED6.Text = "LED6";
            this.btnLED6.UseVisualStyleBackColor = true;
            this.btnLED6.Click += new System.EventHandler(this.btnLED6_Click);
            // 
            // btnLED7
            // 
            this.btnLED7.Location = new System.Drawing.Point(721, 525);
            this.btnLED7.Name = "btnLED7";
            this.btnLED7.Size = new System.Drawing.Size(59, 42);
            this.btnLED7.TabIndex = 12;
            this.btnLED7.Text = "LED7";
            this.btnLED7.UseVisualStyleBackColor = true;
            this.btnLED7.Click += new System.EventHandler(this.btnLED7_Click);
            // 
            // btnLED0
            // 
            this.btnLED0.Location = new System.Drawing.Point(518, 466);
            this.btnLED0.Name = "btnLED0";
            this.btnLED0.Size = new System.Drawing.Size(63, 43);
            this.btnLED0.TabIndex = 13;
            this.btnLED0.Text = "LED0";
            this.btnLED0.UseVisualStyleBackColor = true;
            this.btnLED0.Click += new System.EventHandler(this.btnLED0_Click);
            // 
            // btnAllON
            // 
            this.btnAllON.Location = new System.Drawing.Point(823, 466);
            this.btnAllON.Name = "btnAllON";
            this.btnAllON.Size = new System.Drawing.Size(99, 91);
            this.btnAllON.TabIndex = 14;
            this.btnAllON.Text = "All ON";
            this.btnAllON.UseVisualStyleBackColor = true;
            this.btnAllON.Click += new System.EventHandler(this.btnAllON_Click);
            // 
            // btnAllOFF
            // 
            this.btnAllOFF.Location = new System.Drawing.Point(823, 586);
            this.btnAllOFF.Name = "btnAllOFF";
            this.btnAllOFF.Size = new System.Drawing.Size(99, 91);
            this.btnAllOFF.TabIndex = 15;
            this.btnAllOFF.Text = "All OFF";
            this.btnAllOFF.UseVisualStyleBackColor = true;
            this.btnAllOFF.Click += new System.EventHandler(this.btnAllOFF_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 598);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Giá trị MAX";
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(610, 595);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(161, 22);
            this.txtMaxValue.TabIndex = 17;
            // 
            // txtMinValue
            // 
            this.txtMinValue.Location = new System.Drawing.Point(610, 647);
            this.txtMinValue.Name = "txtMinValue";
            this.txtMinValue.Size = new System.Drawing.Size(161, 22);
            this.txtMinValue.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(515, 650);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Giá trị MIN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(515, 706);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Giá trị TB";
            // 
            // txtTBValue
            // 
            this.txtTBValue.Location = new System.Drawing.Point(610, 700);
            this.txtTBValue.Name = "txtTBValue";
            this.txtTBValue.Size = new System.Drawing.Size(161, 22);
            this.txtTBValue.TabIndex = 21;
            // 
            // txtCurrentData
            // 
            this.txtCurrentData.Location = new System.Drawing.Point(20, 40);
            this.txtCurrentData.Name = "txtCurrentData";
            this.txtCurrentData.Size = new System.Drawing.Size(192, 22);
            this.txtCurrentData.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(961, 779);
            this.Controls.Add(this.txtTBValue);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMinValue);
            this.Controls.Add(this.txtMaxValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAllOFF);
            this.Controls.Add(this.btnAllON);
            this.Controls.Add(this.btnLED0);
            this.Controls.Add(this.btnLED7);
            this.Controls.Add(this.btnLED6);
            this.Controls.Add(this.btnLED5);
            this.Controls.Add(this.btnLED4);
            this.Controls.Add(this.btnLED3);
            this.Controls.Add(this.btnLED2);
            this.Controls.Add(this.btnLED1);
            this.Controls.Add(this.grp_Transmitter);
            this.Controls.Add(this.BieuDo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grp_Transmitter.ResumeLayout(false);
            this.grp_Transmitter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Port;
        private System.Windows.Forms.ComboBox cmb_StopBit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Parity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_DataBit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_BaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.GroupBox groupBox3;
        private ZedGraph.ZedGraphControl BieuDo;
        private System.IO.Ports.SerialPort SerialPort1;
        private System.Windows.Forms.GroupBox grp_Transmitter;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_Send;
        private System.Windows.Forms.Button btnLED1;
        private System.Windows.Forms.Button btnLED2;
        private System.Windows.Forms.Button btnLED3;
        private System.Windows.Forms.Button btnLED4;
        private System.Windows.Forms.Button btnLED5;
        private System.Windows.Forms.Button btnLED6;
        private System.Windows.Forms.Button btnLED7;
        private System.Windows.Forms.Button btnLED0;
        private System.Windows.Forms.Button btnAllON;
        private System.Windows.Forms.Button btnAllOFF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.TextBox txtMinValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTBValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox txtCurrentData;
    }
}


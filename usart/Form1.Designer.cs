﻿namespace usart
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBaud = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBit = new System.Windows.Forms.TextBox();
            this.Terminal = new System.Windows.Forms.TextBox();
            this.textBinary = new System.Windows.Forms.TextBox();
            this.terminalClear = new System.Windows.Forms.Button();
            this.TerminalEnter = new System.Windows.Forms.Button();
            this.textWrite = new System.Windows.Forms.TextBox();
            this.binaryClear = new System.Windows.Forms.Button();
            this.COM = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTerminal = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.RTerminal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabTerminal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 38400;
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboPort
            // 
            this.comboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPort.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.comboPort.FormattingEnabled = true;
            this.comboPort.Location = new System.Drawing.Point(46, 23);
            this.comboPort.Margin = new System.Windows.Forms.Padding(2, 4, 20, 4);
            this.comboPort.Name = "comboPort";
            this.comboPort.Size = new System.Drawing.Size(114, 24);
            this.comboPort.TabIndex = 10;
            this.comboPort.DropDown += new System.EventHandler(this.comboPort_DropDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.label2.Location = new System.Drawing.Point(314, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 8, 2, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "BaudRate :";
            // 
            // textBaud
            // 
            this.textBaud.Font = new System.Drawing.Font("微軟正黑體", 9.25F);
            this.textBaud.Location = new System.Drawing.Point(387, 23);
            this.textBaud.Margin = new System.Windows.Forms.Padding(2, 4, 20, 4);
            this.textBaud.Name = "textBaud";
            this.textBaud.Size = new System.Drawing.Size(96, 24);
            this.textBaud.TabIndex = 4;
            this.textBaud.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBaud_KeyUp);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.label3.Location = new System.Drawing.Point(523, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 8, 2, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "DataBit :";
            // 
            // textBit
            // 
            this.textBit.Font = new System.Drawing.Font("微軟正黑體", 9.25F);
            this.textBit.Location = new System.Drawing.Point(582, 23);
            this.textBit.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBit.Name = "textBit";
            this.textBit.Size = new System.Drawing.Size(90, 24);
            this.textBit.TabIndex = 5;
            this.textBit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBit_KeyUp);
            // 
            // Terminal
            // 
            this.Terminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Terminal.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.Terminal.Location = new System.Drawing.Point(4, 20);
            this.Terminal.Margin = new System.Windows.Forms.Padding(1, 1, 1, 5);
            this.Terminal.Multiline = true;
            this.Terminal.Name = "Terminal";
            this.Terminal.ReadOnly = true;
            this.Terminal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Terminal.Size = new System.Drawing.Size(508, 383);
            this.Terminal.TabIndex = 6;
            // 
            // textBinary
            // 
            this.textBinary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBinary.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBinary.Location = new System.Drawing.Point(4, 18);
            this.textBinary.Margin = new System.Windows.Forms.Padding(1, 1, 1, 5);
            this.textBinary.Multiline = true;
            this.textBinary.Name = "textBinary";
            this.textBinary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBinary.Size = new System.Drawing.Size(371, 385);
            this.textBinary.TabIndex = 7;
            // 
            // terminalClear
            // 
            this.terminalClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.terminalClear.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.terminalClear.Location = new System.Drawing.Point(439, 409);
            this.terminalClear.Margin = new System.Windows.Forms.Padding(10, 1, 1, 1);
            this.terminalClear.MinimumSize = new System.Drawing.Size(73, 24);
            this.terminalClear.Name = "terminalClear";
            this.terminalClear.Size = new System.Drawing.Size(73, 24);
            this.terminalClear.TabIndex = 2;
            this.terminalClear.Text = "Clear";
            this.terminalClear.UseVisualStyleBackColor = true;
            this.terminalClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // TerminalEnter
            // 
            this.TerminalEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TerminalEnter.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.TerminalEnter.Location = new System.Drawing.Point(351, 409);
            this.TerminalEnter.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.TerminalEnter.MinimumSize = new System.Drawing.Size(73, 24);
            this.TerminalEnter.Name = "TerminalEnter";
            this.TerminalEnter.Size = new System.Drawing.Size(73, 24);
            this.TerminalEnter.TabIndex = 1;
            this.TerminalEnter.Text = "Enter";
            this.TerminalEnter.UseVisualStyleBackColor = true;
            this.TerminalEnter.Click += new System.EventHandler(this.button2_Click);
            // 
            // textWrite
            // 
            this.textWrite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textWrite.Font = new System.Drawing.Font("微軟正黑體", 9.25F);
            this.textWrite.Location = new System.Drawing.Point(4, 409);
            this.textWrite.Margin = new System.Windows.Forms.Padding(1, 1, 5, 1);
            this.textWrite.MinimumSize = new System.Drawing.Size(150, 24);
            this.textWrite.Name = "textWrite";
            this.textWrite.Size = new System.Drawing.Size(337, 24);
            this.textWrite.TabIndex = 0;
            this.textWrite.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textWrite_KeyUp);
            // 
            // binaryClear
            // 
            this.binaryClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.binaryClear.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.binaryClear.Location = new System.Drawing.Point(302, 408);
            this.binaryClear.Margin = new System.Windows.Forms.Padding(2);
            this.binaryClear.MinimumSize = new System.Drawing.Size(73, 24);
            this.binaryClear.Name = "binaryClear";
            this.binaryClear.Size = new System.Drawing.Size(73, 24);
            this.binaryClear.TabIndex = 3;
            this.binaryClear.Text = "clear";
            this.binaryClear.UseVisualStyleBackColor = true;
            this.binaryClear.Click += new System.EventHandler(this.binaryClear_Click);
            // 
            // COM
            // 
            this.COM.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.COM.ForeColor = System.Drawing.Color.Red;
            this.COM.Location = new System.Drawing.Point(200, 21);
            this.COM.Margin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.COM.Name = "COM";
            this.COM.Size = new System.Drawing.Size(74, 28);
            this.COM.TabIndex = 6;
            this.COM.Text = "OFF";
            this.COM.UseVisualStyleBackColor = true;
            this.COM.Click += new System.EventHandler(this.COM_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTerminal);
            this.tabControl1.Controls.Add(this.tabSetting);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 552);
            this.tabControl1.TabIndex = 11;
            // 
            // tabTerminal
            // 
            this.tabTerminal.Controls.Add(this.splitContainer1);
            this.tabTerminal.Controls.Add(this.groupBox2);
            this.tabTerminal.Controls.Add(this.flowLayoutPanel1);
            this.tabTerminal.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.tabTerminal.Location = new System.Drawing.Point(4, 25);
            this.tabTerminal.Margin = new System.Windows.Forms.Padding(5);
            this.tabTerminal.Name = "tabTerminal";
            this.tabTerminal.Size = new System.Drawing.Size(912, 523);
            this.tabTerminal.TabIndex = 0;
            this.tabTerminal.Text = "Terminal";
            this.tabTerminal.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(7, 74);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(899, 444);
            this.splitContainer1.SplitterDistance = 516;
            this.splitContainer1.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Terminal);
            this.groupBox3.Controls.Add(this.terminalClear);
            this.groupBox3.Controls.Add(this.TerminalEnter);
            this.groupBox3.Controls.Add(this.textWrite);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 444);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Terminal";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.binaryClear);
            this.groupBox1.Controls.Add(this.textBinary);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 444);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ASAHMI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBit);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBaud);
            this.groupBox2.Controls.Add(this.comboPort);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.COM);
            this.groupBox2.Location = new System.Drawing.Point(7, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.groupBox2.Size = new System.Drawing.Size(680, 64);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Port Setting";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // tabSetting
            // 
            this.tabSetting.Controls.Add(this.RTerminal);
            this.tabSetting.Controls.Add(this.label4);
            this.tabSetting.Location = new System.Drawing.Point(4, 25);
            this.tabSetting.Margin = new System.Windows.Forms.Padding(4);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Padding = new System.Windows.Forms.Padding(4);
            this.tabSetting.Size = new System.Drawing.Size(1041, 518);
            this.tabSetting.TabIndex = 1;
            this.tabSetting.Text = "Setting";
            this.tabSetting.UseVisualStyleBackColor = true;
            this.tabSetting.Enter += new System.EventHandler(this.tabSetting_Enter);
            // 
            // RTerminal
            // 
            this.RTerminal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RTerminal.FormattingEnabled = true;
            this.RTerminal.Items.AddRange(new object[] {
            "ASAHMI",
            "HEX解碼"});
            this.RTerminal.Location = new System.Drawing.Point(123, 26);
            this.RTerminal.Name = "RTerminal";
            this.RTerminal.Size = new System.Drawing.Size(121, 24);
            this.RTerminal.TabIndex = 1;
            this.RTerminal.SelectedIndexChanged += new System.EventHandler(this.RTerminal_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "右側終端顯示 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 552);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(745, 380);
            this.Name = "Form1";
            this.Text = "Agent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabTerminal.ResumeLayout(false);
            this.tabTerminal.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabSetting.ResumeLayout(false);
            this.tabSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBaud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBit;
        private System.Windows.Forms.TextBox Terminal;
        private System.Windows.Forms.TextBox textBinary;
        private System.Windows.Forms.Button terminalClear;
        private System.Windows.Forms.Button TerminalEnter;
        private System.Windows.Forms.TextBox textWrite;
        private System.Windows.Forms.Button binaryClear;
        private System.Windows.Forms.Button COM;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTerminal;
        private System.Windows.Forms.TabPage tabSetting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox RTerminal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}


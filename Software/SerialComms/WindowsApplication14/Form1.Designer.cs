namespace WindowsApplication14
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
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnHyperTerm = new System.Windows.Forms.Button();
            this.rtbOutgoing = new System.Windows.Forms.RichTextBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblRIStatus = new System.Windows.Forms.Label();
            this.lblDSRStatus = new System.Windows.Forms.Label();
            this.lblCTSStatus = new System.Windows.Forms.Label();
            this.lblBreakStatus = new System.Windows.Forms.Label();
            this.cboHandShaking = new System.Windows.Forms.ComboBox();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.cboDataBits = new System.Windows.Forms.ComboBox();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.rtbIncoming = new System.Windows.Forms.RichTextBox();
            this.btnGetSerialPorts = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdClosePort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(254, 97);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(100, 20);
            this.txtCommand.TabIndex = 35;
            // 
            // btnHyperTerm
            // 
            this.btnHyperTerm.Location = new System.Drawing.Point(267, 61);
            this.btnHyperTerm.Name = "btnHyperTerm";
            this.btnHyperTerm.Size = new System.Drawing.Size(75, 23);
            this.btnHyperTerm.TabIndex = 34;
            this.btnHyperTerm.Text = "HyperTerm";
            this.btnHyperTerm.UseVisualStyleBackColor = true;
            this.btnHyperTerm.Click += new System.EventHandler(this.btnHyperTerm_Click);
            // 
            // rtbOutgoing
            // 
            this.rtbOutgoing.Location = new System.Drawing.Point(9, 50);
            this.rtbOutgoing.Name = "rtbOutgoing";
            this.rtbOutgoing.Size = new System.Drawing.Size(260, 134);
            this.rtbOutgoing.TabIndex = 33;
            this.rtbOutgoing.Text = "E:004DFC";
            this.rtbOutgoing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbOutgoing_KeyPress);
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(112, 49);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(75, 23);
            this.btnHello.TabIndex = 32;
            this.btnHello.Text = "Send Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // cmdOpen
            // 
            this.cmdOpen.Location = new System.Drawing.Point(15, 79);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(75, 23);
            this.cmdOpen.TabIndex = 31;
            this.cmdOpen.Text = "Open";
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.cmdPortOpen_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(53, 116);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 30;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            // 
            // lblRIStatus
            // 
            this.lblRIStatus.AutoSize = true;
            this.lblRIStatus.Location = new System.Drawing.Point(291, 16);
            this.lblRIStatus.Name = "lblRIStatus";
            this.lblRIStatus.Size = new System.Drawing.Size(18, 13);
            this.lblRIStatus.TabIndex = 29;
            this.lblRIStatus.Text = "RI";
            this.lblRIStatus.Visible = false;
            // 
            // lblDSRStatus
            // 
            this.lblDSRStatus.AutoSize = true;
            this.lblDSRStatus.Location = new System.Drawing.Point(233, 16);
            this.lblDSRStatus.Name = "lblDSRStatus";
            this.lblDSRStatus.Size = new System.Drawing.Size(30, 13);
            this.lblDSRStatus.TabIndex = 28;
            this.lblDSRStatus.Text = "DSR";
            this.lblDSRStatus.Visible = false;
            // 
            // lblCTSStatus
            // 
            this.lblCTSStatus.AutoSize = true;
            this.lblCTSStatus.Location = new System.Drawing.Point(182, 16);
            this.lblCTSStatus.Name = "lblCTSStatus";
            this.lblCTSStatus.Size = new System.Drawing.Size(28, 13);
            this.lblCTSStatus.TabIndex = 27;
            this.lblCTSStatus.Text = "CTS";
            this.lblCTSStatus.Visible = false;
            // 
            // lblBreakStatus
            // 
            this.lblBreakStatus.AutoSize = true;
            this.lblBreakStatus.Location = new System.Drawing.Point(127, 16);
            this.lblBreakStatus.Name = "lblBreakStatus";
            this.lblBreakStatus.Size = new System.Drawing.Size(35, 13);
            this.lblBreakStatus.TabIndex = 26;
            this.lblBreakStatus.Text = "Break";
            this.lblBreakStatus.Visible = false;
            // 
            // cboHandShaking
            // 
            this.cboHandShaking.FormattingEnabled = true;
            this.cboHandShaking.Location = new System.Drawing.Point(242, 160);
            this.cboHandShaking.Name = "cboHandShaking";
            this.cboHandShaking.Size = new System.Drawing.Size(121, 21);
            this.cboHandShaking.TabIndex = 25;
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(242, 133);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(121, 21);
            this.cboParity.TabIndex = 24;
            // 
            // cboStopBits
            // 
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Location = new System.Drawing.Point(242, 106);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(121, 21);
            this.cboStopBits.TabIndex = 23;
            // 
            // cboDataBits
            // 
            this.cboDataBits.FormattingEnabled = true;
            this.cboDataBits.Location = new System.Drawing.Point(242, 79);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(121, 21);
            this.cboDataBits.TabIndex = 22;
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Location = new System.Drawing.Point(242, 52);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cboBaudRate.TabIndex = 21;
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(242, 25);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(121, 21);
            this.cboPorts.TabIndex = 20;
            // 
            // rtbIncoming
            // 
            this.rtbIncoming.Location = new System.Drawing.Point(6, 224);
            this.rtbIncoming.Name = "rtbIncoming";
            this.rtbIncoming.Size = new System.Drawing.Size(260, 95);
            this.rtbIncoming.TabIndex = 19;
            this.rtbIncoming.Text = "";
            // 
            // btnGetSerialPorts
            // 
            this.btnGetSerialPorts.Location = new System.Drawing.Point(15, 25);
            this.btnGetSerialPorts.Name = "btnGetSerialPorts";
            this.btnGetSerialPorts.Size = new System.Drawing.Size(75, 23);
            this.btnGetSerialPorts.TabIndex = 18;
            this.btnGetSerialPorts.Text = "Load Ports";
            this.btnGetSerialPorts.UseVisualStyleBackColor = true;
            this.btnGetSerialPorts.Click += new System.EventHandler(this.btnGetSerialPorts_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdClosePort);
            this.groupBox1.Controls.Add(this.btnGetSerialPorts);
            this.groupBox1.Controls.Add(this.cboPorts);
            this.groupBox1.Controls.Add(this.cboBaudRate);
            this.groupBox1.Controls.Add(this.cboDataBits);
            this.groupBox1.Controls.Add(this.cboStopBits);
            this.groupBox1.Controls.Add(this.cmdOpen);
            this.groupBox1.Controls.Add(this.cboParity);
            this.groupBox1.Controls.Add(this.cboHandShaking);
            this.groupBox1.Location = new System.Drawing.Point(290, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 258);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Settings";
            // 
            // cmdClosePort
            // 
            this.cmdClosePort.Location = new System.Drawing.Point(112, 79);
            this.cmdClosePort.Name = "cmdClosePort";
            this.cmdClosePort.Size = new System.Drawing.Size(75, 23);
            this.cmdClosePort.TabIndex = 32;
            this.cmdClosePort.Text = "Closed";
            this.cmdClosePort.UseVisualStyleBackColor = true;
            this.cmdClosePort.Click += new System.EventHandler(this.cmdClosePort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Inbound";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "outbound";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdSend);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rtbIncoming);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rtbOutgoing);
            this.groupBox2.Location = new System.Drawing.Point(2, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 420);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCommand);
            this.groupBox3.Controls.Add(this.btnHyperTerm);
            this.groupBox3.Controls.Add(this.btnHello);
            this.groupBox3.Controls.Add(this.lblRIStatus);
            this.groupBox3.Controls.Add(this.btnTest);
            this.groupBox3.Controls.Add(this.lblDSRStatus);
            this.groupBox3.Controls.Add(this.lblBreakStatus);
            this.groupBox3.Controls.Add(this.lblCTSStatus);
            this.groupBox3.Location = new System.Drawing.Point(290, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 153);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // cmdSend
            // 
            this.cmdSend.Location = new System.Drawing.Point(185, 190);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(84, 27);
            this.cmdSend.TabIndex = 39;
            this.cmdSend.Text = "send";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 460);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnHyperTerm;
        private System.Windows.Forms.RichTextBox rtbOutgoing;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button cmdOpen;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblRIStatus;
        private System.Windows.Forms.Label lblDSRStatus;
        private System.Windows.Forms.Label lblCTSStatus;
        private System.Windows.Forms.Label lblBreakStatus;
        private System.Windows.Forms.ComboBox cboHandShaking;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.ComboBox cboDataBits;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.RichTextBox rtbIncoming;
        private System.Windows.Forms.Button btnGetSerialPorts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdClosePort;
        private System.Windows.Forms.Button cmdSend;
    }
}


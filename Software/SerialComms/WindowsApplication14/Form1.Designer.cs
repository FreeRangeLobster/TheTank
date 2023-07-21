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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.btnGetSerialPorts = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdClosePort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdCheckEventNow = new System.Windows.Forms.Button();
            this.cmdShowFullMemory = new System.Windows.Forms.Button();
            this.cmdShowEvents = new System.Windows.Forms.Button();
            this.cmdSend = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmdClearEventField = new System.Windows.Forms.Button();
            this.tbBinWithSpaces = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEventBin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbAddress = new System.Windows.Forms.ComboBox();
            this.tbEvent = new System.Windows.Forms.TextBox();
            this.cmdCalculateEvent = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMinute = new System.Windows.Forms.ComboBox();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbOutput = new System.Windows.Forms.ComboBox();
            this.richTextBoxTrace = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(144, 108);
            this.txtCommand.Margin = new System.Windows.Forms.Padding(4);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(132, 23);
            this.txtCommand.TabIndex = 35;
            this.txtCommand.TextChanged += new System.EventHandler(this.txtCommand_TextChanged);
            // 
            // btnHyperTerm
            // 
            this.btnHyperTerm.Location = new System.Drawing.Point(8, 116);
            this.btnHyperTerm.Margin = new System.Windows.Forms.Padding(4);
            this.btnHyperTerm.Name = "btnHyperTerm";
            this.btnHyperTerm.Size = new System.Drawing.Size(100, 28);
            this.btnHyperTerm.TabIndex = 34;
            this.btnHyperTerm.Text = "HyperTerm";
            this.btnHyperTerm.UseVisualStyleBackColor = true;
            this.btnHyperTerm.Click += new System.EventHandler(this.btnHyperTerm_Click);
            // 
            // rtbOutgoing
            // 
            this.rtbOutgoing.Location = new System.Drawing.Point(13, 137);
            this.rtbOutgoing.Margin = new System.Windows.Forms.Padding(4);
            this.rtbOutgoing.Name = "rtbOutgoing";
            this.rtbOutgoing.Size = new System.Drawing.Size(194, 73);
            this.rtbOutgoing.TabIndex = 33;
            this.rtbOutgoing.Text = "E:004DFC";
            this.rtbOutgoing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbOutgoing_KeyPress);
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(8, 85);
            this.btnHello.Margin = new System.Windows.Forms.Padding(4);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(100, 28);
            this.btnHello.TabIndex = 32;
            this.btnHello.Text = "Send Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // cmdOpen
            // 
            this.cmdOpen.Location = new System.Drawing.Point(8, 105);
            this.cmdOpen.Margin = new System.Windows.Forms.Padding(4);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(100, 28);
            this.cmdOpen.TabIndex = 31;
            this.cmdOpen.Text = "Open";
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.cmdPortOpen_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(8, 53);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 28);
            this.btnTest.TabIndex = 30;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            // 
            // lblRIStatus
            // 
            this.lblRIStatus.AutoSize = true;
            this.lblRIStatus.Location = new System.Drawing.Point(234, 20);
            this.lblRIStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRIStatus.Name = "lblRIStatus";
            this.lblRIStatus.Size = new System.Drawing.Size(21, 16);
            this.lblRIStatus.TabIndex = 29;
            this.lblRIStatus.Text = "RI";
            this.lblRIStatus.Visible = false;
            // 
            // lblDSRStatus
            // 
            this.lblDSRStatus.AutoSize = true;
            this.lblDSRStatus.Location = new System.Drawing.Point(168, 20);
            this.lblDSRStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDSRStatus.Name = "lblDSRStatus";
            this.lblDSRStatus.Size = new System.Drawing.Size(34, 16);
            this.lblDSRStatus.TabIndex = 28;
            this.lblDSRStatus.Text = "DSR";
            this.lblDSRStatus.Visible = false;
            // 
            // lblCTSStatus
            // 
            this.lblCTSStatus.AutoSize = true;
            this.lblCTSStatus.Location = new System.Drawing.Point(111, 20);
            this.lblCTSStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCTSStatus.Name = "lblCTSStatus";
            this.lblCTSStatus.Size = new System.Drawing.Size(35, 16);
            this.lblCTSStatus.TabIndex = 27;
            this.lblCTSStatus.Text = "CTS";
            this.lblCTSStatus.Visible = false;
            // 
            // lblBreakStatus
            // 
            this.lblBreakStatus.AutoSize = true;
            this.lblBreakStatus.Location = new System.Drawing.Point(28, 30);
            this.lblBreakStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBreakStatus.Name = "lblBreakStatus";
            this.lblBreakStatus.Size = new System.Drawing.Size(44, 16);
            this.lblBreakStatus.TabIndex = 26;
            this.lblBreakStatus.Text = "Break";
            this.lblBreakStatus.Visible = false;
            // 
            // cboHandShaking
            // 
            this.cboHandShaking.FormattingEnabled = true;
            this.cboHandShaking.Location = new System.Drawing.Point(116, 141);
            this.cboHandShaking.Margin = new System.Windows.Forms.Padding(4);
            this.cboHandShaking.Name = "cboHandShaking";
            this.cboHandShaking.Size = new System.Drawing.Size(160, 24);
            this.cboHandShaking.TabIndex = 25;
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(116, 116);
            this.cboParity.Margin = new System.Windows.Forms.Padding(4);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(160, 24);
            this.cboParity.TabIndex = 24;
            // 
            // cboStopBits
            // 
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Location = new System.Drawing.Point(116, 91);
            this.cboStopBits.Margin = new System.Windows.Forms.Padding(4);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(160, 24);
            this.cboStopBits.TabIndex = 23;
            // 
            // cboDataBits
            // 
            this.cboDataBits.FormattingEnabled = true;
            this.cboDataBits.Location = new System.Drawing.Point(116, 66);
            this.cboDataBits.Margin = new System.Windows.Forms.Padding(4);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(160, 24);
            this.cboDataBits.TabIndex = 22;
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Location = new System.Drawing.Point(116, 41);
            this.cboBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(160, 24);
            this.cboBaudRate.TabIndex = 21;
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(116, 14);
            this.cboPorts.Margin = new System.Windows.Forms.Padding(4);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(160, 24);
            this.cboPorts.TabIndex = 20;
            // 
            // btnGetSerialPorts
            // 
            this.btnGetSerialPorts.Location = new System.Drawing.Point(8, 24);
            this.btnGetSerialPorts.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetSerialPorts.Name = "btnGetSerialPorts";
            this.btnGetSerialPorts.Size = new System.Drawing.Size(100, 28);
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
            this.groupBox1.Location = new System.Drawing.Point(976, 175);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(287, 184);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Settings";
            // 
            // cmdClosePort
            // 
            this.cmdClosePort.Location = new System.Drawing.Point(8, 141);
            this.cmdClosePort.Margin = new System.Windows.Forms.Padding(4);
            this.cmdClosePort.Name = "cmdClosePort";
            this.cmdClosePort.Size = new System.Drawing.Size(100, 28);
            this.cmdClosePort.TabIndex = 32;
            this.cmdClosePort.Text = "Closed";
            this.cmdClosePort.UseVisualStyleBackColor = true;
            this.cmdClosePort.Click += new System.EventHandler(this.cmdClosePort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Outbound";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdCheckEventNow);
            this.groupBox2.Controls.Add(this.cmdShowFullMemory);
            this.groupBox2.Controls.Add(this.cmdShowEvents);
            this.groupBox2.Controls.Add(this.cmdSend);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rtbOutgoing);
            this.groupBox2.Location = new System.Drawing.Point(3, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(305, 348);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // cmdCheckEventNow
            // 
            this.cmdCheckEventNow.Location = new System.Drawing.Point(8, 78);
            this.cmdCheckEventNow.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCheckEventNow.Name = "cmdCheckEventNow";
            this.cmdCheckEventNow.Size = new System.Drawing.Size(139, 23);
            this.cmdCheckEventNow.TabIndex = 42;
            this.cmdCheckEventNow.Text = "Check Event NOW";
            this.cmdCheckEventNow.UseVisualStyleBackColor = true;
            this.cmdCheckEventNow.Click += new System.EventHandler(this.cmdCheckEventNow_Click);
            // 
            // cmdShowFullMemory
            // 
            this.cmdShowFullMemory.Location = new System.Drawing.Point(8, 19);
            this.cmdShowFullMemory.Margin = new System.Windows.Forms.Padding(4);
            this.cmdShowFullMemory.Name = "cmdShowFullMemory";
            this.cmdShowFullMemory.Size = new System.Drawing.Size(139, 23);
            this.cmdShowFullMemory.TabIndex = 41;
            this.cmdShowFullMemory.Text = "Show Full Memory";
            this.cmdShowFullMemory.UseVisualStyleBackColor = true;
            this.cmdShowFullMemory.Click += new System.EventHandler(this.cmdShowFullMemory_Click);
            // 
            // cmdShowEvents
            // 
            this.cmdShowEvents.Location = new System.Drawing.Point(7, 47);
            this.cmdShowEvents.Margin = new System.Windows.Forms.Padding(4);
            this.cmdShowEvents.Name = "cmdShowEvents";
            this.cmdShowEvents.Size = new System.Drawing.Size(139, 23);
            this.cmdShowEvents.TabIndex = 40;
            this.cmdShowEvents.Text = "Show All Events";
            this.cmdShowEvents.UseVisualStyleBackColor = true;
            this.cmdShowEvents.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // cmdSend
            // 
            this.cmdSend.Location = new System.Drawing.Point(215, 134);
            this.cmdSend.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(69, 76);
            this.cmdSend.TabIndex = 39;
            this.cmdSend.Text = "send";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
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
            this.groupBox3.Location = new System.Drawing.Point(976, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(285, 157);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3_ToDelete";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.cmdClearEventField);
            this.groupBox4.Controls.Add(this.tbBinWithSpaces);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.tbEventBin);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cbAddress);
            this.groupBox4.Controls.Add(this.tbEvent);
            this.groupBox4.Controls.Add(this.cmdCalculateEvent);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cbState);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cbMinute);
            this.groupBox4.Controls.Add(this.cbHour);
            this.groupBox4.Controls.Add(this.cbDay);
            this.groupBox4.Controls.Add(this.cbOutput);
            this.groupBox4.Location = new System.Drawing.Point(316, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(652, 348);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Compose Event";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 179);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 179);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 23);
            this.textBox1.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 182);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 16);
            this.label13.TabIndex = 45;
            this.label13.Text = "Full Event";
            // 
            // cmdClearEventField
            // 
            this.cmdClearEventField.Location = new System.Drawing.Point(485, 126);
            this.cmdClearEventField.Margin = new System.Windows.Forms.Padding(4);
            this.cmdClearEventField.Name = "cmdClearEventField";
            this.cmdClearEventField.Size = new System.Drawing.Size(146, 28);
            this.cmdClearEventField.TabIndex = 44;
            this.cmdClearEventField.Text = "Clear";
            this.cmdClearEventField.UseVisualStyleBackColor = true;
            this.cmdClearEventField.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbBinWithSpaces
            // 
            this.tbBinWithSpaces.Location = new System.Drawing.Point(96, 142);
            this.tbBinWithSpaces.Margin = new System.Windows.Forms.Padding(4);
            this.tbBinWithSpaces.Name = "tbBinWithSpaces";
            this.tbBinWithSpaces.Size = new System.Drawing.Size(344, 23);
            this.tbBinWithSpaces.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 146);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "Event[Bin]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 214);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(520, 128);
            this.label12.TabIndex = 41;
            this.label12.Text = resources.GetString("label12.Text");
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // tbEventBin
            // 
            this.tbEventBin.Location = new System.Drawing.Point(95, 112);
            this.tbEventBin.Margin = new System.Windows.Forms.Padding(4);
            this.tbEventBin.Name = "tbEventBin";
            this.tbEventBin.Size = new System.Drawing.Size(345, 23);
            this.tbEventBin.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 115);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 38;
            this.label10.Text = "Event[Bin]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 37;
            this.label9.Text = "Event[Hex]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Address";
            // 
            // cbAddress
            // 
            this.cbAddress.FormattingEnabled = true;
            this.cbAddress.Location = new System.Drawing.Point(16, 49);
            this.cbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(87, 24);
            this.cbAddress.TabIndex = 35;
            // 
            // tbEvent
            // 
            this.tbEvent.Location = new System.Drawing.Point(97, 82);
            this.tbEvent.Margin = new System.Windows.Forms.Padding(4);
            this.tbEvent.Name = "tbEvent";
            this.tbEvent.Size = new System.Drawing.Size(343, 23);
            this.tbEvent.TabIndex = 34;
            // 
            // cmdCalculateEvent
            // 
            this.cmdCalculateEvent.Location = new System.Drawing.Point(485, 85);
            this.cmdCalculateEvent.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCalculateEvent.Name = "cmdCalculateEvent";
            this.cmdCalculateEvent.Size = new System.Drawing.Size(146, 28);
            this.cmdCalculateEvent.TabIndex = 33;
            this.cmdCalculateEvent.Text = "Calculate Event";
            this.cmdCalculateEvent.UseVisualStyleBackColor = true;
            this.cmdCalculateEvent.Click += new System.EventHandler(this.cmdCalculateEvent_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(560, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "State";
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(540, 49);
            this.cbState.Margin = new System.Windows.Forms.Padding(4);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(91, 24);
            this.cbState.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Minute";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Output";
            // 
            // cbMinute
            // 
            this.cbMinute.FormattingEnabled = true;
            this.cbMinute.Location = new System.Drawing.Point(444, 49);
            this.cbMinute.Margin = new System.Windows.Forms.Padding(4);
            this.cbMinute.Name = "cbMinute";
            this.cbMinute.Size = new System.Drawing.Size(87, 24);
            this.cbMinute.TabIndex = 3;
            // 
            // cbHour
            // 
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Location = new System.Drawing.Point(324, 49);
            this.cbHour.Margin = new System.Windows.Forms.Padding(4);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(111, 24);
            this.cbHour.TabIndex = 2;
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(208, 49);
            this.cbDay.Margin = new System.Windows.Forms.Padding(4);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(107, 24);
            this.cbDay.TabIndex = 1;
            // 
            // cbOutput
            // 
            this.cbOutput.FormattingEnabled = true;
            this.cbOutput.Location = new System.Drawing.Point(112, 49);
            this.cbOutput.Margin = new System.Windows.Forms.Padding(4);
            this.cbOutput.Name = "cbOutput";
            this.cbOutput.Size = new System.Drawing.Size(87, 24);
            this.cbOutput.TabIndex = 0;
            // 
            // richTextBoxTrace
            // 
            this.richTextBoxTrace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTrace.Location = new System.Drawing.Point(7, 23);
            this.richTextBoxTrace.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxTrace.Name = "richTextBoxTrace";
            this.richTextBoxTrace.Size = new System.Drawing.Size(1240, 214);
            this.richTextBoxTrace.TabIndex = 44;
            this.richTextBoxTrace.Text = "";
            this.richTextBoxTrace.DoubleClick += new System.EventHandler(this.richTextBoxTrace_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.richTextBoxTrace);
            this.groupBox5.Location = new System.Drawing.Point(3, 360);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1258, 257);
            this.groupBox5.TabIndex = 45;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Trace";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 637);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnGetSerialPorts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdClosePort;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbAddress;
        private System.Windows.Forms.TextBox tbEvent;
        private System.Windows.Forms.Button cmdCalculateEvent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMinute;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbOutput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEventBin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbBinWithSpaces;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cmdClearEventField;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox richTextBoxTrace;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button cmdShowEvents;
        private System.Windows.Forms.Button cmdShowFullMemory;
        private System.Windows.Forms.Button cmdCheckEventNow;
    }
}


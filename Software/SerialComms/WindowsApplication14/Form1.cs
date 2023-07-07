using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;

namespace WindowsApplication14
{
    public partial class Form1 : Form
    {
        SerialPort ComPort = new SerialPort();

        internal delegate void SerialDataReceivedEventHandlerDelegate(object sender, SerialDataReceivedEventArgs e);
        internal delegate void SerialPinChangedEventHandlerDelegate(object sender, SerialPinChangedEventArgs e);
        private SerialPinChangedEventHandler SerialPinChangedEventHandler1;
        delegate void SetTextCallback(string text);
        string InputData = String.Empty;





        public Form1()
        {
            InitializeComponent();
            SerialPinChangedEventHandler1 = new SerialPinChangedEventHandler(PinChanged);
            ComPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_1);
            LoadEventVAriables();
        }


        private void LoadEventVAriables()
        {
            //| Address  0,1  | Event 0| 
            //|-------|---------|
            //Output =(1) 01
            //Day = Tuesday 001
            //Hour=23 1 0111
            //Minute=30 11 11 0
            //State= 0

            //Summary: 01 001 1 0111 11 11 00
            //binary   0100 1101 1111 1100 
            //hex 0x4DFC
            //Dec 19964

            cbAddress.Items.AddRange(new string[] {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10" });
            cbAddress.SelectedIndex = 0;

            cbOutput.Items.AddRange(new string[] { "0", "1", "2", "3" });
            cbOutput.SelectedIndex = 1;

            cbDay.Items.AddRange(new string[] { "0 Sunday", "1 Monday", "2 Tuesday", "3 Wednesday", "4 Thursday", "5 Friday", "6 Saturday", "7 All" });
            cbDay.SelectedIndex =0;

            cbHour.Items.AddRange(new string[] { "1", "2" , "3", "4" , "5", "6" , "7", "8", "9" , "10", "11" , "12",
                                                "13", "14" , "15", "16" , "17", "18" , "19", "20", "21" , "22", "23" , "0", });
            cbHour.SelectedIndex = 22;

            cbMinute.Items.AddRange(new string[] {"0", "2", "4", "6", "8", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "20","22", "24", "26", "28", "30",
                                                   "32", "34", "36", "38", "40", "42", "44", "46", "48", "50", "52", "54", "66", "58", });
            cbMinute.SelectedIndex = 20;

            cbState.Items.AddRange(new string[] { "0", "1" });
            cbState.SelectedIndex = 0;
        }


        private void cmdCalculateEvent_Click(object sender, EventArgs e)
        {
            string slastError = string.Empty;
            string sBinValue= string.Empty;
            string sbinValueSeparated = string.Empty;
            tbEvent.Text = sEvent(cbAddress.Text,cbOutput.Text,cbDay.Text,cbHour.Text,cbMinute.Text,cbState.Text, out sBinValue, out sbinValueSeparated, out slastError);
            tbEventBin.Text = sBinValue;
            tbBinWithSpaces.Text  = sbinValueSeparated;
        }


        string sEvent(string sAddress, string sOutput, string sDay, string sHour, string sMinute, string sState,out string sBinValue,out string sBinValueSeparated,out string sLastError)
        {
            sLastError = string.Empty;
            string sHexValue = string.Empty;
            sBinValue = string.Empty;
            sBinValueSeparated = string.Empty;

            uint HighByteSide = 0;
            uint LowByteSide = 0;
            uint fullEvent = 0;

            uint nAddress = 0;
            uint nOutput = 0;
            uint nDay = 0;
            uint nHour = 0;
            uint nMinute = 0;
            uint nState = 0;

            //|  2bit        | 3 bit     | 5  bit    |   5  bit     |   1 bit   |
            //|--------------|-----------|-----------|--------------|-----------|
            //| Output(0-3)  |  Day(0-7) | Hour(0-24)|  Min*2(0-60) | State(0-1)|


            if (sDay.Length>1)
            {
                sDay = sDay.Substring(0, 1);
            }

            //Output Convert string to number
            if (uint.TryParse(sOutput, out nOutput)==false)
            {                
                sLastError = " unable to parse sOutput";
                return "";
            }

            //Day Convert string to number 
            if (uint.TryParse(sDay, out nDay) == false)
            {
                sLastError = " unable to parse Day";
                return "";
            }

            //Hour Convert string to number 
            if (uint.TryParse(sHour, out nHour) == false)
            {
                sLastError = " unable to parse sHour";
                return "";
            }

            //Min Convert string to number
            if (uint.TryParse(sMinute, out nMinute)==false)
            {
                sLastError = " unable to parse sMinute";
                return "";
            }


            nMinute = nMinute / 2;

            //State
            if (uint.TryParse(sState, out nState) == false)
            {
                sLastError = " unable to parse sState";
                return "";
            }

            //Build the number from 
            
            nOutput = nOutput << 14;
           
            nMinute = nMinute << 1;
            nHour = nHour << 6;

            nDay = nDay << 11;

            fullEvent = nOutput | nDay | nHour | nMinute | nState;

            sBinValue = Convert.ToString(fullEvent, 2).PadLeft(16, '0');
            sHexValue = Convert.ToString(fullEvent, 16).PadLeft(4, '0').ToUpper();

            sBinValueSeparated = sBinValue.Insert(2, " ");
            sBinValueSeparated = sBinValueSeparated.Insert(2+1+3, " ");
            sBinValueSeparated = sBinValueSeparated.Insert(2 + 1 + 3 + 1 + 5, " ");
            sBinValueSeparated = sBinValueSeparated.Insert(2 + 1 + 3 + 1 + 5 + 1 + 5, " ");

            return sHexValue;
        }


        internal void PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            SerialPinChange SerialPinChange1 = 0;
            bool signalState = false;

            SerialPinChange1 = e.EventType;
            lblCTSStatus.BackColor = Color.Green;
            lblDSRStatus.BackColor = Color.Green;
            lblRIStatus.BackColor = Color.Green;
            lblBreakStatus.BackColor = Color.Green;
            switch (SerialPinChange1)
            {
                case SerialPinChange.Break:
                    lblBreakStatus.BackColor = Color.Red;
                    //MessageBox.Show("Break is Set");
                    break;
                case SerialPinChange.CDChanged:
                    signalState = ComPort.CtsHolding;
                    //  MessageBox.Show("CD = " + signalState.ToString());
                    break;
                case SerialPinChange.CtsChanged:
                    signalState = ComPort.CDHolding;
                    lblCTSStatus.BackColor = Color.Red;
                    //MessageBox.Show("CTS = " + signalState.ToString());
                    break;
                case SerialPinChange.DsrChanged:
                    signalState = ComPort.DsrHolding;
                    lblDSRStatus.BackColor = Color.Red;
                    // MessageBox.Show("DSR = " + signalState.ToString());
                    break;
                case SerialPinChange.Ring:
                    lblRIStatus.BackColor = Color.Red;
                    //MessageBox.Show("Ring Detected");
                    break;
            }
        }


        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            InputData = ComPort.ReadExisting();
            if (InputData != String.Empty)
            {
                this.BeginInvoke(new SetTextCallback(SetText), new object[] { InputData });
            }
        }
        private void SetText(string text)
        {
            this.rtbIncoming.Text += text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetSerialPorts_Click(object sender, EventArgs e)
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;

            //Com Ports
            ArrayComPortsNames = SerialPort.GetPortNames();
            do
            {
                index += 1;
                cboPorts.Items.Add(ArrayComPortsNames[index]);


            } while (!((ArrayComPortsNames[index] == ComPortName) || (index == ArrayComPortsNames.GetUpperBound(0))));
            Array.Sort(ArrayComPortsNames);

            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                ComPortName = ArrayComPortsNames[0];
            }
            //get first item print in text
            cboPorts.Text = ArrayComPortsNames[0];
            //Baud Rate
            cboBaudRate.Items.Add(300);
            cboBaudRate.Items.Add(600);
            cboBaudRate.Items.Add(1200);
            cboBaudRate.Items.Add(2400);
            cboBaudRate.Items.Add(9600);
            cboBaudRate.Items.Add(14400);
            cboBaudRate.Items.Add(19200);
            cboBaudRate.Items.Add(38400);
            cboBaudRate.Items.Add(57600);
            cboBaudRate.Items.Add(115200);
            cboBaudRate.Items.ToString();
            //get first item print in text
            cboBaudRate.Text = cboBaudRate.Items[9].ToString();
            //Data Bits
            cboDataBits.Items.Add(7);
            cboDataBits.Items.Add(8);
            //get the first item print it in the text 
            cboDataBits.Text = cboDataBits.Items[1].ToString();

            //Stop Bits
            cboStopBits.Items.Add("One");
            cboStopBits.Items.Add("OnePointFive");
            cboStopBits.Items.Add("Two");
            //get the first item print in the text
            cboStopBits.Text = cboStopBits.Items[0].ToString();
            //Parity 
            cboParity.Items.Add("None");
            cboParity.Items.Add("Even");
            cboParity.Items.Add("Mark");
            cboParity.Items.Add("Odd");
            cboParity.Items.Add("Space");
            //get the first item print in the text
            cboParity.Text = cboParity.Items[0].ToString();
            //Handshake
            cboHandShaking.Items.Add("None");
            cboHandShaking.Items.Add("XOnXOff");
            cboHandShaking.Items.Add("RequestToSend");
            cboHandShaking.Items.Add("RequestToSendXOnXOff");
            //get the first item print it in the text 
            cboHandShaking.Text = cboHandShaking.Items[0].ToString();

        }

        private void cmdPortOpen_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen == false)
            {
                cmdOpen.Text = "Open";
                ComPort.PortName = Convert.ToString(cboPorts.Text);
                ComPort.BaudRate = Convert.ToInt32(cboBaudRate.Text);
                ComPort.DataBits = Convert.ToInt16(cboDataBits.Text);
                ComPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboStopBits.Text);
                ComPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cboHandShaking.Text);
                ComPort.Parity = (Parity)Enum.Parse(typeof(Parity), cboParity.Text);
                ComPort.Open();
            }
        }

        private void cmdClosePort_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen == false)
            {
                cmdOpen.Text = "Closed";
                ComPort.Close();
            }
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            ComPort.Write("Hello World!");
        }

        private void btnHyperTerm_Click(object sender, EventArgs e)
        {
            string Command1 = txtCommand.Text;
            string CommandSent;
            int Length, j = 0;

            Length = Command1.Length;

            for (int i = 0; i < Length; i++)
            {
                CommandSent = Command1.Substring(j, 1);
                ComPort.Write(CommandSent);
                j++;
            }
        }

        private void rtbOutgoing_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)13) // enter key  
            //{
            //    ComPort.Write("\r\n");
            //    rtbOutgoing.Text = "";
            //}
            //else if (e.KeyChar < 32 || e.KeyChar > 126)
            //{
            //    e.Handled = true; // ignores anything else outside printable ASCII range  
            //}
            //else
            //{
            //    ComPort.Write(e.KeyChar.ToString());
            //}
        }

        private void cmdSend_Click(object sender, EventArgs e)
        {
            cmdSend.BackColor = Color.Transparent;
            if (ComPort.IsOpen)
            {
                ComPort.Write(rtbOutgoing.Text + "\n");
                cmdSend.BackColor = Color.LimeGreen;
            }
            else
            {
                cmdSend.BackColor = Color.Red;
            }
            
        }


    }
}
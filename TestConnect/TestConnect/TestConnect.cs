using System;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace TestConnect
{
    public partial class TestConnect : Form
    {

        SerialPort portLeft;
        SerialPort portRight;
        Timer timerConnection;
        Timer timerPackage;
        int packTotalSizeUSB;
        int packTotalSizeUART;

        delegate void SetTextLeftCallBack(string data);
        delegate void SetTextRightCallBack(string data);
        delegate void SetTextPackSize();
        delegate void SetLabelConnect();

        public TestConnect()
        {
            InitializeComponent();
        }

        private void InitializeTimers()
        {
            timerConnection = new Timer();
            timerConnection.Interval = 2000;
            timerConnection.Tick += Timer_Tick;
            timerConnection.Enabled = true;

            timerPackage = new Timer();
            timerPackage.Interval = 1000;
            timerPackage.Tick += TimerPackage_Tick;
            timerPackage.Enabled = true;
        }

        private void TimerPackage_Tick(object sender, EventArgs e)
        {
            this.SetTextPackageSize();
        }

        private void SetTextPackageSize()
        {
            if (txtBaudRateUSB.InvokeRequired)
            {
                SetTextPackSize set = new SetTextPackSize(SetTextPackageSize);
                this.Invoke(set);
            }
            else
            {             
                string logUSB = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond} - {packTotalSizeUSB}";
                string logUART = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond} - {packTotalSizeUART}";

                txtBaudRateUSB.AppendText(logUSB);
                txtBaudRateUSB.AppendText("\n");
               
                txtBaudRateUART.AppendText(logUART);
                txtBaudRateUART.AppendText("\n");

                packTotalSizeUSB = 0;
                packTotalSizeUART = 0;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.SetLabelConnected();
        }

        private void InitializePortLeft()
        {
            var ascii = Encoding.ASCII;
            byte[] bytes = ascii.GetBytes(new[] { (char)3 });

            portLeft = new SerialPort("COM5", 115200, Parity.None, 8, StopBits.One);
            portLeft.DtrEnable = true;
            //portLeft.RtsEnable = true;
            //portLeft.Handshake = Handshake.None;
            portLeft.DataReceived += PortLeft_DataReceived;            
            if (!portLeft.IsOpen)
            {
                portLeft.Open();
                lblLeftConnect.Text = "Connected";
            }
            portLeft.NewLine = Encoding.UTF8.GetString(bytes, 0, 1);
        }

        private void InitializePortRight()
        {
            var ascii = Encoding.ASCII;
            byte[] bytes = ascii.GetBytes(new[] { (char)3 });

            portRight = new SerialPort("COM3", 115200, Parity.None, 8, StopBits.One);
            portRight.DataReceived += PortRight_DataReceived;
            if (!portRight.IsOpen)
            {
                portRight.Open();
                lblRightConnect.Text = "Connected";
            }
            portRight.NewLine = Encoding.UTF8.GetString(bytes, 0, 1);
        }

        private void PortRight_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.SetTextRight(portRight.ReadLine());
        }

        private void SetTextRight(string data)
        {
            if (txtRight.InvokeRequired)
            {
                SetTextRightCallBack set = new SetTextRightCallBack(SetTextRight);
                this.Invoke(set, new object[] { data });
            }
            else
            {
                packTotalSizeUART += ASCIIEncoding.ASCII.GetByteCount(data) * 8;
                if (chkDataUART.Checked)
                {
                    txtRight.AppendText($"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond} - {data}");
                    txtRight.AppendText("\n");
                    txtRight.ScrollToCaret();
                }
            }
        }

        private void PortLeft_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            this.SetTextLeft(portLeft.ReadLine());
        }

        public void SetTextLeft(string data)
        {
            if (txtLeft.InvokeRequired)
            {
                SetTextLeftCallBack set = new SetTextLeftCallBack(SetTextLeft);
                this.Invoke(set, new object[] { data });
            }
            else
            {
                packTotalSizeUSB += ASCIIEncoding.ASCII.GetByteCount(data) * 8;

                if (chkDataUSB.Checked)
                {
                    txtLeft.AppendText($"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond} - {data}");
                    txtLeft.AppendText("\n");
                    txtLeft.ScrollToCaret();
                }
            }

        }

        private void TestConnect_Shown(object sender, EventArgs e)
        {
            InitializeTimers();
        }

        public void SetLabelConnected()
        {
            if (lblLeftConnect.InvokeRequired)
            {
                SetLabelConnect set = new SetLabelConnect(SetLabelConnected);
                this.Invoke(set);
            }
            else
            {
                if (chkLeft.Checked)
                {
                    if (portLeft != null && portLeft.IsOpen)
                    {
                        lblLeftConnect.Text = "Connected";
                    }
                    else
                    {
                        lblLeftConnect.Text = "Disconnected";
                        try
                        {
                            portLeft.Close();
                            portLeft.Open();
                        }
                        catch (Exception)
                        {
                            lblLeftConnect.Text = "Disconnected exception";
                        }
                    }
                }
                if (chkRight.Checked)
                {
                    if (portRight != null && portRight.IsOpen)
                    {
                        lblRightConnect.Text = "Connected";
                    }
                    else
                    {
                        lblRightConnect.Text = "Disconnected";
                        try
                        {
                            portRight.Close();
                            portRight.Open();
                        }
                        catch (Exception)
                        {
                            lblRightConnect.Text = "Disconnected exception";
                        }
                    }
                }
            }
        }

        private void btnStartLeft_Click(object sender, EventArgs e)
        {
            try
            {
                if (portLeft is null)
                    InitializePortLeft();
                else
                {
                    portLeft.DataReceived += PortLeft_DataReceived;
                    portLeft.Open();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnStopLeft_Click(object sender, EventArgs e)
        {
            try
            {
                System.Threading.Thread CloseDown = new System.Threading.Thread(new System.Threading.ThreadStart(CloseSerialPortLeft));
                CloseDown.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseSerialPortLeft()
        {
            try
            {
                portLeft.DataReceived -= PortLeft_DataReceived;
                portLeft.DiscardInBuffer();
                portLeft.DiscardOutBuffer();
                portLeft.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStartRight_Click(object sender, EventArgs e)
        {
            try
            {
                if (portRight is null)
                    InitializePortRight();
                else
                {
                    portRight.DataReceived += PortRight_DataReceived;
                    portRight.Open();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnStopRight_Click(object sender, EventArgs e)
        {
            System.Threading.Thread CloseDown = new System.Threading.Thread(new System.Threading.ThreadStart(CloseSerialPortRight));
            CloseDown.Start();
        }

        private void CloseSerialPortRight()
        {
            try
            {
                portRight.DataReceived -= PortRight_DataReceived;
                portRight.DiscardInBuffer();
                portRight.DiscardOutBuffer();
                portRight.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }       
    }
}



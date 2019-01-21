using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestConnect
{
    public partial class TestConnect : Form
    {

        SerialPort portLeft;
        SerialPort portRight;
        Timer timer;

        delegate void SetTextLeftCallBack(string data);
        delegate void SetTextRightCallBack(string data);
        delegate void SetLabelConnect();

        public TestConnect()
        {
            InitializeComponent();
            //InitializePorts();
            //timer = new Timer();
            //timer.Interval = 2000;
            //timer.Tick += Timer_Tick;
            //timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.SetLabelConnected();
        }

        private void InitializeText()
        {
            txtLeft.Width = this.Width / 2 - 15;
            txtLeft.Left = 0;
            txtLeft.Top = 50;
            txtLeft.Height = this.Height - 50;
            lblLeft.Left = 50; 

            txtRight.Width = this.Width / 2;
            txtRight.Left = txtLeft.Width;
            txtRight.Top = 50;
            txtRight.Height = this.Height - 50;
            lblRight.Left = txtLeft.Width + 50;
        }

        private void InitializePorts()
        {
            var ascii = Encoding.ASCII;
            byte[] bytes = ascii.GetBytes(new[] { (char)3 });
            byte[] bytes2 = ascii.GetBytes(new[] { (char)'\n' });

            portLeft = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);
            portLeft.DataReceived += PortLeft_DataReceived;
            if (!portLeft.IsOpen)
            {
                portLeft.Open();
                lblLeftConnect.Text = "Connected";
            }
            //portLeft.NewLine = Encoding.UTF8.GetString(bytes, 0, 1);

            portRight = new SerialPort("COM3", 115200, Parity.None, 8, StopBits.One);
            portRight.DataReceived += PortRight_DataReceived;
            if (!portRight.IsOpen)
            {
                portRight.Open();
                lblRightConnect.Text = "Connected";
            }
            //portRight.NewLine = Encoding.UTF8.GetString(bytes2, 0, 1);
        }

        private void PortRight_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.SetTextRight(portRight.ReadExisting());
            //this.SetTextRight(portRight.ReadLine());
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
                txtRight.AppendText($"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond} - {data}");
                txtRight.AppendText("\n");
                txtRight.ScrollToCaret();
            }
        }

        private void PortLeft_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.SetTextLeft(portLeft.ReadExisting());
            //this.SetTextLeft(portLeft.ReadLine());
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
                txtLeft.AppendText($"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond} - {data}");
                txtLeft.AppendText("\n");
                txtLeft.ScrollToCaret();
            }

        }

        private void TestConnect_Shown(object sender, EventArgs e)
        {
            InitializeText();
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
                if (portLeft.IsOpen)
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

                if (portRight.IsOpen)
                {
                    lblRightConnect.Text = "Connected desd";
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
}

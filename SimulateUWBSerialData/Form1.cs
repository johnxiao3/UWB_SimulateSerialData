using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SimulateUWBSerialData
{
    public partial class Form1 : Form
    {
        SerialPort _serialPort;
        int openclose = 0;

        double[] xbase = new double[] { 0, 50, 50 };
        double[] ybase = new double[] { 0, 0, 50 };
        double[] d_tag1 = new double[] { 0, 0, 0 };
        double theta0 = 0;
        double theta1 = 0; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            // Display each port name to the console.
            foreach (string port in ports)
            {
                //Console.WriteLine(port);
                comboSerialPorts.Items.Add(port);

            }
            //Console.ReadLine();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            if (openclose == 0)
            {
                String serialport = comboSerialPorts.Text;
                if (serialport == "")
                    return;
                int baudrate = Int32.Parse(comboBaudRate.Text);
                int databits = Int32.Parse(comboDataBits.Text);
                String parity = comboParity.Text;
                int stopbits = Int32.Parse(comboStopBits.Text);

                _serialPort = new SerialPort(serialport, baudrate, Parity.None, databits, StopBits.One);
                _serialPort.Handshake = Handshake.None;
                _serialPort.Open();
                btOpen.Text = "Close";
                openclose = 1;
            }
            else {
                _serialPort.Close();
                btOpen.Text = "Open";
                openclose = 0;
            }
        }

        private void btSimu1_Click(object sender, EventArgs e)
        {
            if (btSimu1.Text == "SendSimulateData1")
            {
                timerSim1.Start();
                btSimu1.Text = "Stope Send SImu Data1";
            }
            else {
                timerSim1.Stop();
                btSimu1.Text = "SendSimulateData1";
            }
        }

        private void timerSim1_Tick(object sender, EventArgs e)
        {
            double xcent = 25;
            double ycent = 25;
            double cirR = 10;
            double xtag = xcent + cirR * Math.Cos(theta0);
            double ytag = ycent + cirR * Math.Sin(theta0);
            double d1, d2, d3;
            d1 = Math.Sqrt(Math.Pow(xtag - xbase[0],2) + Math.Pow(ytag - ybase[0],2));
            d2 = Math.Sqrt(Math.Pow(xtag - xbase[1],2) + Math.Pow(ytag - ybase[1],2));
            d3 = Math.Sqrt(Math.Pow(xtag - xbase[2],2) + Math.Pow(ytag - ybase[2],2));

            String sendStr;
            sendStr = "0,"+d1.ToString("N2") + "," + d2.ToString("N2") + "," + d3.ToString("N2") + "\n";
            _serialPort.Write(sendStr);

            theta0 += 0.02;
            if (theta0 > 2 * 3.14)
                theta0 = 0;
        }

        private void timerSim11_Tick(object sender, EventArgs e)
        {
            double xcent = 10;
            double ycent = 10;
            double cirR = 10;
            double xtag = xcent + cirR * Math.Cos(theta1);
            double ytag = ycent + cirR * Math.Sin(theta1);
            double d1, d2, d3;
            d1 = Math.Sqrt(Math.Pow(xtag - xbase[0], 2) + Math.Pow(ytag - ybase[0], 2));
            d2 = Math.Sqrt(Math.Pow(xtag - xbase[1], 2) + Math.Pow(ytag - ybase[1], 2));
            d3 = Math.Sqrt(Math.Pow(xtag - xbase[2], 2) + Math.Pow(ytag - ybase[2], 2));

            String sendStr;
            sendStr = "1," + d1.ToString("N2") + "," + d2.ToString("N2") + "," + d3.ToString("N2") + "\n";
            _serialPort.Write(sendStr);

            theta1 += 0.02;
            if (theta1 > 2 * 3.14)
                theta1 = 0;
        }

        private void btSimu22_Click(object sender, EventArgs e)
        {
            if (btSimu22.Text == "SendSimulateData1")
            {
                timerSim11.Start();
                btSimu22.Text = "Stope Send SImu Data1";
            }
            else
            {
                timerSim11.Stop();
                btSimu22.Text = "SendSimulateData1";
            }
        }
    }
}


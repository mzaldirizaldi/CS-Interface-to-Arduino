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

namespace WPF_Training_Week_1_With_Potentiometer
{
    public partial class Form1 : Form
    {
        string unoDataIn, degree, degree2;
        sbyte indexOfA;
        sbyte indexOfB;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            button_unoOpen.Enabled = true;
            button_unoClose.Enabled = false;
            button_ledTurnOn.Enabled = false;
            button_ledTurnOff.Enabled = false;
            progressBar_uno.Value = 0;
            trackBar_degree.Value = 45;
            comboBox_unoBaudRate.Text = "9600";


        }

        private void comboBox_unoComPort_DropDown(object sender, EventArgs e)
        {
            string[] portLists = SerialPort.GetPortNames();
            comboBox_unoComPort.Items.Clear();
            comboBox_unoComPort.Items.AddRange(portLists);
        }

        private void button_unoOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_uno.PortName = comboBox_unoComPort.Text;
                serialPort_uno.BaudRate = Convert.ToInt32(comboBox_unoBaudRate.Text);
                serialPort_uno.Open();

                button_unoOpen.Enabled = false;
                button_unoClose.Enabled = true;
                button_ledTurnOn.Enabled = true;
                button_ledTurnOff.Enabled = true;
                progressBar_uno.Value = 100;
                MessageBox.Show("Connected to Arduino UNO", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void button_unoClose_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_uno.Close();
                button_unoOpen.Enabled = true;
                button_unoClose.Enabled = false;
                progressBar_uno.Value = 0;
                button_ledTurnOff.Enabled = false;
                button_ledTurnOn.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void button_ledTurnOn_Click(object sender, EventArgs e)
        {
            if (serialPort_uno.IsOpen)
            {
                try
                {
                    serialPort_uno.Write("ON#");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void serialPort_uno_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            unoDataIn = serialPort_uno.ReadLine();
            this.BeginInvoke(new EventHandler(ProcessData));
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            try
            {
                serialPort_uno.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_ledTurnOff_Click(object sender, EventArgs e)
        {
            if (serialPort_uno.IsOpen)
            {
                try
                {
                    serialPort_uno.Write("OFF#");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }


        private void ProcessData(object sender, EventArgs e)
        {
            try
            {

                indexOfA = Convert.ToSByte(unoDataIn.IndexOf("A"));
                degree = unoDataIn.Substring(0, indexOfA);
                trackBar_degree.Value = Convert.ToInt32(degree);
                serialPort_uno.Write(degree.ToString() + "\n");
                label_degree.Text = String.Format("DEGREE = " + degree + "°");
                if (unoDataIn.Length > 4)
                {
                    indexOfB = Convert.ToSByte(unoDataIn.IndexOf("B"));
                    degree2 = unoDataIn.Substring(3, indexOfB - 3);
                    textBox_degree.Text = degree2 +  "°";
                }
            }



            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}

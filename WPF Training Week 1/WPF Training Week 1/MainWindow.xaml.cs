using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO.Ports;

namespace WPF_Training_Week_1
{

    public partial class MainWindow : Window
    {
        System.IO.Ports.SerialPort SerialPort_uno = new System.IO.Ports.SerialPort();
        public MainWindow()
        {
            InitializeComponent();

        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            button_unoOpen.IsEnabled = true;
            button_unoClose.IsEnabled = false;
            progressBar_uno.Value = 0;
            comboBox_unoBaudRate.Text = "9600";
        }

        private void comboBox_unoBaudRate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox_unoComPort_DropDown(object sender,EventArgs e)
        {
            string[] portLists = SerialPort.GetPortNames();
            comboBox_unoComPort.Items.Clear();
            comboBox_unoComPort.Items.Add(portLists);
        }

        private void button_unoOpen_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort_uno.PortName = comboBox_unoComPort.Text;
                SerialPort_uno.BaudRate = Convert.ToInt32(comboBox_unoComPort.Text);
                SerialPort_uno.Open();
                SerialPort_uno.Write("#");

                button_unoOpen.IsEnabled = false;
                button_unoClose.IsEnabled = false;
                button_ledTurnOn.IsEnabled = true;
                button_ledTurnOff.IsEnabled = true;
                progressBar_uno.Value = 100;
                MessageBox.Show("Connected to Arduino UNO", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
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
                SerialPort_uno.Close();

                button_unoOpen.IsEnabled = true;
                button_unoClose.IsEnabled = false;
                progressBar_uno.Value = 0;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void comboBox_unoComPort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_ledTurnOn_Click(object sender, EventArgs e)
        {
            if (SerialPort_uno.IsOpen)
            {
                try
                {
                    SerialPort_uno.Write("uON#");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void button_ledTurnOff_Click(object sender, EventArgs e)
        {
            if (SerialPort_uno.IsOpen)
            {
                try
                {
                    SerialPort_uno.Write("uOFF#");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void MainWindow_Closing(object sender, SessionEndingCancelEventArgs e)
        {
            if (SerialPort_uno.IsOpen)
            {
                try
                {
                    SerialPort_uno.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}

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
        string serialDataIn;
        sbyte indexOfB;
        sbyte indexOfA;
        string degree, degree2;


        private readonly string[] portLists = SerialPort.GetPortNames();
        System.IO.Ports.SerialPort SerialPort_uno = new System.IO.Ports.SerialPort();
        public MainWindow()
        {
            InitializeComponent();
            populatecombobox_ComPort();
            button_unoOpen.IsEnabled = true;
            button_unoClose.IsEnabled = false;
            progressBar_uno.Value = 0;
            comboBox_unoBaudRate.Text = "115200";
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {


        }

        private void comboBox_unoBaudRate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void populatecombobox_ComPort()
        {
            comboBox_unoComPort.ItemsSource = portLists;
            comboBox_unoComPort.SelectedIndex = 0;
        }

        private void button_unoOpen_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort_uno.PortName = comboBox_unoComPort.Text;
                SerialPort_uno.BaudRate = 115200;
                SerialPort_uno.Open();
                SerialPort_uno.Write("#");

                button_unoOpen.IsEnabled = false;
                button_unoClose.IsEnabled = true;
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

        private void button_ledTurnOn_Click(object sender, EventArgs e)
        {
            if (SerialPort_uno.IsOpen)
            {
                try
                {
                    SerialPort_uno.Write("ON#");
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
                    SerialPort_uno.Write("#OFF");
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void slider_degree_Scroll(object sender, EventArgs e)
        {

        }

        private void slider_degree_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (SerialPort_uno.IsOpen)
            {
                double double_degree = slider_degree.Value;

                SerialPort_uno.Write(double_degree.ToString() + "\n");
                textBlock_degree.Text = string.Format("DEGREE = (0)", double_degree);
                textBox_degree.Text = double_degree.ToString();
            }
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            if (SerialPort_uno.IsOpen)
            {
                string str_degree = textBox_degree.Text;

                SerialPort_uno.Write(str_degree + "\n");
                textBlock_degree.Text = "DEGREE = " + str_degree;
                slider_degree.Value = Convert.ToDouble(str_degree);
            }
        }
    }
}

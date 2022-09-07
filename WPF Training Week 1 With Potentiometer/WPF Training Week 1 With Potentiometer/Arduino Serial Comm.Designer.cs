namespace WPF_Training_Week_1_With_Potentiometer
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
            this.components = new System.ComponentModel.Container();
            this.groupBox_comPortSettings = new System.Windows.Forms.GroupBox();
            this.progressBar_uno = new System.Windows.Forms.ProgressBar();
            this.button_unoClose = new System.Windows.Forms.Button();
            this.button_unoOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_unoBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBox_unoComPort = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_ledTurnOff = new System.Windows.Forms.Button();
            this.button_ledTurnOn = new System.Windows.Forms.Button();
            this.serialPort_uno = new System.IO.Ports.SerialPort(this.components);
            this.groupBox_servoControl = new System.Windows.Forms.GroupBox();
            this.textBox_degree = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_degree = new System.Windows.Forms.Label();
            this.trackBar_degree = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_comPortSettings.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox_servoControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_degree)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_comPortSettings
            // 
            this.groupBox_comPortSettings.Controls.Add(this.progressBar_uno);
            this.groupBox_comPortSettings.Controls.Add(this.button_unoClose);
            this.groupBox_comPortSettings.Controls.Add(this.button_unoOpen);
            this.groupBox_comPortSettings.Controls.Add(this.label2);
            this.groupBox_comPortSettings.Controls.Add(this.label1);
            this.groupBox_comPortSettings.Controls.Add(this.comboBox_unoBaudRate);
            this.groupBox_comPortSettings.Controls.Add(this.comboBox_unoComPort);
            this.groupBox_comPortSettings.Location = new System.Drawing.Point(12, 12);
            this.groupBox_comPortSettings.Name = "groupBox_comPortSettings";
            this.groupBox_comPortSettings.Size = new System.Drawing.Size(329, 216);
            this.groupBox_comPortSettings.TabIndex = 0;
            this.groupBox_comPortSettings.TabStop = false;
            this.groupBox_comPortSettings.Text = "COM PORT SETTINGS";
            // 
            // progressBar_uno
            // 
            this.progressBar_uno.Location = new System.Drawing.Point(6, 180);
            this.progressBar_uno.Name = "progressBar_uno";
            this.progressBar_uno.Size = new System.Drawing.Size(317, 23);
            this.progressBar_uno.TabIndex = 6;
            // 
            // button_unoClose
            // 
            this.button_unoClose.Location = new System.Drawing.Point(166, 129);
            this.button_unoClose.Name = "button_unoClose";
            this.button_unoClose.Size = new System.Drawing.Size(114, 39);
            this.button_unoClose.TabIndex = 5;
            this.button_unoClose.Text = "CLOSE";
            this.button_unoClose.UseVisualStyleBackColor = true;
            this.button_unoClose.Click += new System.EventHandler(this.button_unoClose_Click);
            // 
            // button_unoOpen
            // 
            this.button_unoOpen.Location = new System.Drawing.Point(35, 129);
            this.button_unoOpen.Name = "button_unoOpen";
            this.button_unoOpen.Size = new System.Drawing.Size(114, 39);
            this.button_unoOpen.TabIndex = 4;
            this.button_unoOpen.Text = "OPEN";
            this.button_unoOpen.UseVisualStyleBackColor = true;
            this.button_unoOpen.Click += new System.EventHandler(this.button_unoOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "BAUD RATE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM PORT:";
            // 
            // comboBox_unoBaudRate
            // 
            this.comboBox_unoBaudRate.FormattingEnabled = true;
            this.comboBox_unoBaudRate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboBox_unoBaudRate.Location = new System.Drawing.Point(135, 91);
            this.comboBox_unoBaudRate.Name = "comboBox_unoBaudRate";
            this.comboBox_unoBaudRate.Size = new System.Drawing.Size(145, 24);
            this.comboBox_unoBaudRate.TabIndex = 1;
            // 
            // comboBox_unoComPort
            // 
            this.comboBox_unoComPort.FormattingEnabled = true;
            this.comboBox_unoComPort.Location = new System.Drawing.Point(135, 49);
            this.comboBox_unoComPort.Name = "comboBox_unoComPort";
            this.comboBox_unoComPort.Size = new System.Drawing.Size(145, 24);
            this.comboBox_unoComPort.TabIndex = 0;
            this.comboBox_unoComPort.DropDown += new System.EventHandler(this.comboBox_unoComPort_DropDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_ledTurnOff);
            this.groupBox3.Controls.Add(this.button_ledTurnOn);
            this.groupBox3.Location = new System.Drawing.Point(12, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 204);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LED CONTROL";
            // 
            // button_ledTurnOff
            // 
            this.button_ledTurnOff.Location = new System.Drawing.Point(166, 85);
            this.button_ledTurnOff.Name = "button_ledTurnOff";
            this.button_ledTurnOff.Size = new System.Drawing.Size(118, 50);
            this.button_ledTurnOff.TabIndex = 1;
            this.button_ledTurnOff.Text = "TURN OFF";
            this.button_ledTurnOff.UseVisualStyleBackColor = true;
            // 
            // button_ledTurnOn
            // 
            this.button_ledTurnOn.Location = new System.Drawing.Point(31, 85);
            this.button_ledTurnOn.Name = "button_ledTurnOn";
            this.button_ledTurnOn.Size = new System.Drawing.Size(118, 50);
            this.button_ledTurnOn.TabIndex = 0;
            this.button_ledTurnOn.Text = "TURN ON";
            this.button_ledTurnOn.UseVisualStyleBackColor = true;
            this.button_ledTurnOn.Click += new System.EventHandler(this.button_ledTurnOn_Click);
            // 
            // serialPort_uno
            // 
            this.serialPort_uno.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_uno_DataReceived_1);
            // 
            // groupBox_servoControl
            // 
            this.groupBox_servoControl.Controls.Add(this.label4);
            this.groupBox_servoControl.Controls.Add(this.textBox_degree);
            this.groupBox_servoControl.Controls.Add(this.label3);
            this.groupBox_servoControl.Controls.Add(this.label5);
            this.groupBox_servoControl.Controls.Add(this.label_degree);
            this.groupBox_servoControl.Controls.Add(this.trackBar_degree);
            this.groupBox_servoControl.Location = new System.Drawing.Point(348, 18);
            this.groupBox_servoControl.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_servoControl.Name = "groupBox_servoControl";
            this.groupBox_servoControl.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_servoControl.Size = new System.Drawing.Size(439, 419);
            this.groupBox_servoControl.TabIndex = 5;
            this.groupBox_servoControl.TabStop = false;
            this.groupBox_servoControl.Text = "SERVO CONTROL";
            // 
            // textBox_degree
            // 
            this.textBox_degree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_degree.Location = new System.Drawing.Point(196, 231);
            this.textBox_degree.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_degree.Name = "textBox_degree";
            this.textBox_degree.ReadOnly = true;
            this.textBox_degree.Size = new System.Drawing.Size(53, 22);
            this.textBox_degree.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "85°";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "45°";
            // 
            // label_degree
            // 
            this.label_degree.AutoSize = true;
            this.label_degree.Location = new System.Drawing.Point(183, 33);
            this.label_degree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_degree.Name = "label_degree";
            this.label_degree.Size = new System.Drawing.Size(74, 16);
            this.label_degree.TabIndex = 1;
            this.label_degree.Text = "DEGREE =";
            // 
            // trackBar_degree
            // 
            this.trackBar_degree.Location = new System.Drawing.Point(63, 53);
            this.trackBar_degree.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar_degree.Maximum = 86;
            this.trackBar_degree.Minimum = 45;
            this.trackBar_degree.Name = "trackBar_degree";
            this.trackBar_degree.Size = new System.Drawing.Size(301, 56);
            this.trackBar_degree.TabIndex = 0;
            this.trackBar_degree.Value = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "SENT AT:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_servoControl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_comPortSettings);
            this.Name = "Form1";
            this.Text = "Arduino Serial Comm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_comPortSettings.ResumeLayout(false);
            this.groupBox_comPortSettings.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox_servoControl.ResumeLayout(false);
            this.groupBox_servoControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_degree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_comPortSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_unoBaudRate;
        private System.Windows.Forms.ComboBox comboBox_unoComPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_unoClose;
        private System.Windows.Forms.Button button_unoOpen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_ledTurnOff;
        private System.Windows.Forms.Button button_ledTurnOn;
        private System.Windows.Forms.ProgressBar progressBar_uno;
        private System.IO.Ports.SerialPort serialPort_uno;
        private System.Windows.Forms.GroupBox groupBox_servoControl;
        private System.Windows.Forms.TextBox textBox_degree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_degree;
        private System.Windows.Forms.TrackBar trackBar_degree;
        private System.Windows.Forms.Label label4;
    }
}


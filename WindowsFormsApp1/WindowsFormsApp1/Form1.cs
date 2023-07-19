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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        string bfRecebe = string.Empty;
        public delegate void Fdelegate(string a);
        bool pwm1;
        int aux = 0;

        public Form1()
        {
            InitializeComponent();
            VarreCOMs();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            bfRecebe = serialPort1.ReadExisting();
            this.BeginInvoke(new Fdelegate(recebe_serial), new object[] { bfRecebe });
        }

        public void recebe_serial(string a)
        {

        }

        private void VarreCOMs()
        {
            #region Config_Port
            String[] valoresPort = SerialPort.GetPortNames();
            for(int i=0; i<valoresPort.Length; i++)
            {
                cbBoxPort.Items.Add(valoresPort[i]);
            }
            cbBoxPort.Text = "COM1";
            #endregion

            #region Config_Baud
            int[] valoresBaud = { 2400, 4800, 9600, 57600, 115200 };
            for (int i = 0; i < valoresBaud.Length; i++)
            {
                cbBoxBaud.Items.Add(valoresBaud[i].ToString());
            }
            cbBoxBaud.Text = "9600";
            #endregion
        }

        private void btPlant1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("a");
            lbPlant.Text = "1";
        }

        private void btPlant2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("b");
            lbPlant.Text = "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("c");
            lbPlant.Text = "3";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true) serialPort1.Close();
            else
            {
                serialPort1.PortName = cbBoxPort.Text;
                serialPort1.BaudRate = int.Parse(cbBoxBaud.Text);
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
            }
            try
            {
                serialPort1.Open();
                btConectar.Enabled = false;
                btDesconectar.Enabled = true;
                btSair.Enabled = false;
                cbBoxBaud.Enabled = false;
                cbBoxPort.Enabled = false;
                lbStatusConect.Text = "Conectado";
                lbPlant.Text = "0";
            }
            catch
            {
                MessageBox.Show("ERRO DE COMUNICAÇÃO COM A PORTA SERIAL");
                MessageBox.Show("Configure a Porta COM e o Baud Rate no Controle de Conexão Serial");
                btConectar.Enabled = true;
                btDesconectar.Enabled = false;
                btSair.Enabled = true;
                cbBoxBaud.Enabled = true;
                cbBoxPort.Enabled = true;
                lbStatusConect.Text = "Aguardando Conexão";
                lbPlant.Text = "0";
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                btConectar.Enabled = true;
                btDesconectar.Enabled = false;
                btSair.Enabled = true;
                cbBoxBaud.Enabled = true;
                cbBoxPort.Enabled = true;
                lbStatusConect.Text = "Desconectado";
                lbPlant.Text = "0";
            }
            catch
            {
                MessageBox.Show("ERRO DE COMUNICAÇÃO COM A PORTA SERIAL");
                MessageBox.Show("Configure a Porta COM e o Baud Rate no Controle de Conexão Serial");
                btConectar.Enabled = false;
                btDesconectar.Enabled = true;
                btSair.Enabled = false;
                cbBoxBaud.Enabled = false;
                cbBoxPort.Enabled = false;
                lbStatusConect.Text = "Aguardando Conexão";
                lbPlant.Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbBoxBaud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelUsers_Click(object sender, EventArgs e)
        {

        }

        private void manual_Click(object sender, EventArgs e)
        {
            serialPort1.Write("x");
            lbPlant.Text = "0";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            serialPort1.Write("z");
        }

        private void botaoRegaOFF_Click(object sender, EventArgs e)
        {
            serialPort1.Write("y");
        }

        private void botaoVentoON_Click(object sender, EventArgs e)
        {
            serialPort1.Write("d");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            serialPort1.Write("e");
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (trackBarPWM.Value < 11)
            {
                if (trackBarPWM.Value > aux)
                {
                    serialPort1.Write("f");
                    aux = trackBarPWM.Value;
                }

                if (trackBarPWM.Value < aux)
                {
                    serialPort1.Write("g");
                    aux = trackBarPWM.Value;
                }
            }
        }
    }
}

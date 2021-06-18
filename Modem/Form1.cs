using System;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace Modem
{
    public partial class Form1 : Form
    {
        private String messageText = "";

        private SerialPort serialPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
        
        bool commandMode = false;

        public Form1()
        {
            if (!serialPort.IsOpen)
            {
                InitializeComponent();
                serialPort.Open();
                serialPort.RtsEnable = true;
                //serialPort.Write("ATZ\r");    // resetowanie parametrów modemu
                serialPort.Write("ATE1\r");

            } 
            else
            {
                serialPort.Write("ATH\r");
                InitializeComponent();
                serialPort.Open();
                serialPort.RtsEnable = true;
                //serialPort.Write("ATZ\r");    // resetowanie parametrów modemu 
                serialPort.Write("ATE1\r");
            }


            Thread mesThread = new Thread(messageThread);
            mesThread.Start();

        }

        private void serialPortDataReceived()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {

                serialPort.Write("+");
                Thread.Sleep(100);
                serialPort.Write("+");
                Thread.Sleep(100);
                serialPort.Write("+");
                Thread.Sleep(100);
                serialPort.Write("ath\r");
            }
        }

        private void buttonAllow_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("ata\r");
            }
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            messageText = textBoxSendMessage.Text;
            if (serialPort.IsOpen)
            {
                // przechodzenie do trybu komend
                if (textBoxSendMessage.Text[0] == '+' && textBoxSendMessage.Text[1] == '+' && textBoxSendMessage.Text[2] == '+')
                {
                    commandMode = true;
                    serialPort.Write("+");
                    Thread.Sleep(100);
                    serialPort.Write("+");
                    Thread.Sleep(100);
                    serialPort.Write("+");
                    Thread.Sleep(100);
                }
                // jeżeli jesteśmy w trybie komend
                if (commandMode)
                {
                    // wpisywanie komend
                    serialPort.Write(messageText + "\r");
                    // jeżeli wpiszemy ato lub ATO, to powrót do trybu danych
                    if ((textBoxSendMessage.Text[0] == 'a' && textBoxSendMessage.Text[1] == 't' && textBoxSendMessage.Text[2] == 'o')
                        || (textBoxSendMessage.Text[0] == 'A' && textBoxSendMessage.Text[1] == 'T' && textBoxSendMessage.Text[2] == 'O'))
                    {
                        commandMode = false;
                    }
                }
                else
                {
                    // zwykła wiadomość (przesyłanie danych)
                    serialPort.Write(messageText);
                }
            }
            
            textBoxSendMessage.Text = "";
            // wyświetlanie odprawionej wiadomości
            textBoxMessageBox.AppendText(messageText + Environment.NewLine);
            messageText = "";
        }

        private void messageThread()
        {
            textBoxMessageBox.Text = "";
            while (true)
            {
                try
                {
                    string message = serialPort.ReadExisting();
                    if (message.Length > 0)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            textBoxMessageBox.AppendText(message);
                        }));
                    }
                }
                catch (TimeoutException) { }
            }
        }

        private void buttonCall_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("atd" + textBoxPhoneNumber.Text + "\r");
            }
        }

        private void textBoxMessageBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

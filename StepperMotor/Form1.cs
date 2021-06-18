using System;
using System.Windows.Forms;
using FTD2XX_NET;
using System.Threading;

namespace StepperMotor
{
    public partial class Form1 : Form
    {
        FTDI deviceFTDI; // definiowanie urządzenia
        FTDI.FT_STATUS status; // status urządzenia
       
        byte[] stopMotion = { 0x00}; // odłącenie zasilania
        // zaslanie dla silnika 1
        byte[] halfMotion = { 0x02, 0x06, 0x04, 0x05, 0x01, 0x09, 0x08, 0x0A }; // tablica zasilania sterowania półkrokowego 
        byte[] fullMotion = { 0x06, 0x05, 0x09, 0x0A }; // tablica zasilania sterowania pełnokrowego  
        byte[] waveMotion = { 0x02, 0x04, 0x01, 0x08 };// tablica zasilania sterowania falowego 
        // zaslanie dla silnika 2
        byte[] halfMotion2 = { 0x20, 0x60, 0x40, 0x50, 0x10, 0x90, 0x80, 0xA0 }; // tablica zasilania sterowania półkrokowego 
        byte[] fullMotion2 = { 0x60, 0x50, 0x90, 0xA0 };// tablica zasilania sterowania pełnokrowego  
        byte[] waveMotion2 = { 0x20, 0x40, 0x10, 0x80 };// tablica zasilania sterowania falowego 

        int idx1 = 0; //pozycja ineratora w tablicy zasilania (silnik 1)
        int idx2 = 0; //pozycja ineratora w tablicy zasilania (silnik 2)

        public Form1()
        {
            InitializeComponent();
            comboBoxEngine.Items.Add("half step");
            comboBoxEngine.Items.Add("full step");
            comboBoxEngine.Items.Add("wave step");

        }

        void stepMotion(byte[] tab, int steps, int time, int left, ref int idx)
        {
            int bytesToWrite = 1;
            uint bytesWritten = 0;
            for(int i = 0; i< steps; i++)
            {
                idx += left;
                if(idx > tab.Length-1)
                {
                    idx = 0;
                }
                if(idx < 0)
                {
                    idx = tab.Length - 1;
                }
                byte[] currentByte = { tab[idx] };
                deviceFTDI.Write(currentByte, bytesToWrite, ref bytesWritten);
                Thread.Sleep(time);
            }
        
        }


        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // liczba urządzen = 0
                UInt32 countDeviceFTDI = 0;
                
                deviceFTDI = new FTDI();
                // skanowanie urządzeń
                deviceFTDI.GetNumberOfDevices(ref countDeviceFTDI);
                FTDI.FT_DEVICE_INFO_NODE[] deviceList = new FTDI.FT_DEVICE_INFO_NODE[countDeviceFTDI];
                deviceFTDI.GetDeviceList(deviceList);
                // wybierany jest 1-y z listy urządzeń
                status = deviceFTDI.OpenBySerialNumber(deviceList[0].SerialNumber);
                // ustalienie trybu
                deviceFTDI.SetBitMode(0xff, 1);
                if(status == FTDI.FT_STATUS.FT_OK)
                {
                    textBox1.Text += "Connected" + Environment.NewLine;
                }
                else
                {
                    textBox1.Text += status.ToString() + Environment.NewLine;
                }
            }
            catch(Exception ex)
            {
                textBox1.Text += ex.Message + Environment.NewLine;
            }

        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {

            switch (comboBoxEngine.SelectedIndex)
            {
                case 0:
                    {//                tab                                                                                             left     idx
                        stepMotion(halfMotion, System.Convert.ToInt32(textBoxSteps.Text), System.Convert.ToInt32(textBoxStepTime.Text), 1, ref idx1);
                        break;
                    }
                case 1:
                    {
                        stepMotion(fullMotion, System.Convert.ToInt32(textBoxSteps.Text), System.Convert.ToInt32(textBoxStepTime.Text), 1, ref idx1);
                        break;
                    }
                case 2:
                    {
                        stepMotion(waveMotion, System.Convert.ToInt32(textBoxSteps.Text), System.Convert.ToInt32(textBoxStepTime.Text), 1, ref idx1);
                        break;
                    }
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            stepMotion(stopMotion, 1, 1, 1, ref idx2);
            deviceFTDI.Close();
            textBox1.Text += status.ToString()+ Environment.NewLine;
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {

            switch (comboBoxEngine.SelectedIndex)
            {
                case 0:
                    {
                        stepMotion(halfMotion, System.Convert.ToInt32(textBoxSteps.Text), System.Convert.ToInt32(textBoxStepTime.Text), -1, ref idx1);
                        break;
                    }
                case 1:
                    {
                        stepMotion(fullMotion, System.Convert.ToInt32(textBoxSteps.Text), System.Convert.ToInt32(textBoxStepTime.Text), -1, ref idx1);
                        break;
                    }
                case 2:
                    {
                        stepMotion(waveMotion, System.Convert.ToInt32(textBoxSteps.Text), System.Convert.ToInt32(textBoxStepTime.Text), -1, ref idx1);
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch (comboBoxEngine.SelectedIndex)
            {
                case 0:
                    {
                        stepMotion(halfMotion2, System.Convert.ToInt32(textBox2.Text), System.Convert.ToInt32(textBoxStepTime.Text), 1, ref idx2);
                        break;
                    }
                case 1:
                    {
                        stepMotion(fullMotion2, System.Convert.ToInt32(textBox2.Text), System.Convert.ToInt32(textBoxStepTime.Text), 1, ref idx2);
                        break;
                    }
                case 2:
                    {
                        stepMotion(waveMotion2, System.Convert.ToInt32(textBox2.Text), System.Convert.ToInt32(textBoxStepTime.Text), 1, ref idx2);
                        break;
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            switch (comboBoxEngine.SelectedIndex)
            {
                case 0:
                    {
                        stepMotion(halfMotion2, System.Convert.ToInt32(textBox2.Text), System.Convert.ToInt32(textBoxStepTime.Text), -1, ref idx2);
                        break;
                    }
                case 1:
                    {
                        stepMotion(fullMotion2, System.Convert.ToInt32(textBox2.Text), System.Convert.ToInt32(textBoxStepTime.Text), -1, ref idx2);
                        break;
                    }
                case 2:
                    {
                        stepMotion(waveMotion2, System.Convert.ToInt32(textBox2.Text), System.Convert.ToInt32(textBoxStepTime.Text), -1, ref idx2);
                        break;
                    }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] dataBuffer;
            uint numBytesToRead;
            uint numBytesRead = 0;
         //   status = deviceFTDI.Read()
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using WIA;
using System.Runtime.InteropServices;


namespace Scanner
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        int dpi;
        int weght;
        int height;
        int color;
        int brightness;
        int contrast;



        private WIA.DeviceManager deviceManager = new WIA.DeviceManager();
        public Form1()
        {
            InitializeComponent();
            //AllocConsole();
            /*Console.WriteLine("lol");
            string val = Console.ReadLine();
            Console.WriteLine(val);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // ustalienie parametrów skanowania
                loadSettings();
                WIA.DeviceInfo deviceInfo = null;
                deviceInfo = deviceManager.DeviceInfos[comboBoxListOfScanner.SelectedIndex + 1];

                var device = deviceInfo.Connect();
                Item scannerItem = device.Items[1];

                AdjustScannerSettings(scannerItem, dpi, 0, 0, 1250, 1700, brightness, contrast, color);


                // zachowanie pliku
                var imageFile = (ImageFile)scannerItem.Transfer(FormatID.wiaFormatJPEG);

                var path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\scan" + comboBoxFile.SelectedIndex;
                
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                imageFile.SaveFile(path);

                pictureBox1.ImageLocation = path;
            }
            catch (COMException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private static void SetItemIntProperty(IProperties properties, object propName, object propValue)
        {
            Property prop = properties.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }

        private void comboBoxListOfScanner_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            labelPath.Text = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\scan";
            try
            {
                for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
                {
                    if (deviceManager.DeviceInfos[i].Type == WiaDeviceType.ScannerDeviceType)
                    {
                        comboBoxListOfScanner.Items.Add(deviceManager.DeviceInfos[i].Properties["Name"].get_Value());
                    }
                }
                textBox1.Text = "150";
                trackBar1.Value = 5;
                trackBar2.Value = 5;
                comboBoxFile.Items.Add(".jpg");
                comboBoxFile.Items.Add(".png");
                comboBoxFile.Items.Add(".bmp");

            }
            catch (COMException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private static void AdjustScannerSettings(IItem scannnerItem, int scanResolutionDPI,
            int scanStartLeftPixel, int scanStartTopPixel, int scanWidthPixels, int scanHeightPixels,
            int brightnessPercents, int contrastPercents, int colorMode)
        {
            const string WIA_SCAN_COLOR_MODE = "6146";
            const string WIA_HORIZONTAL_SCAN_RESOLUTION_DPI = "6147";
            const string WIA_VERTICAL_SCAN_RESOLUTION_DPI = "6148";
            const string WIA_HORIZONTAL_SCAN_START_PIXEL = "6149";
            const string WIA_VERTICAL_SCAN_START_PIXEL = "6150";
            const string WIA_HORIZONTAL_SCAN_SIZE_PIXELS = "6151";
            const string WIA_VERTICAL_SCAN_SIZE_PIXELS = "6152";
            const string WIA_SCAN_BRIGHTNESS_PERCENTS = "6154";
            const string WIA_SCAN_CONTRAST_PERCENTS = "6155";
            SetItemIntProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetItemIntProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetItemIntProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_START_PIXEL, scanStartLeftPixel);
            SetItemIntProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_START_PIXEL, scanStartTopPixel);
            SetItemIntProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_SIZE_PIXELS, scanWidthPixels);
            SetItemIntProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_SIZE_PIXELS, scanHeightPixels);
            SetItemIntProperty(scannnerItem.Properties, WIA_SCAN_BRIGHTNESS_PERCENTS, brightnessPercents);
            SetItemIntProperty(scannnerItem.Properties, WIA_SCAN_CONTRAST_PERCENTS, contrastPercents);
            SetItemIntProperty(scannnerItem.Properties, WIA_SCAN_COLOR_MODE, colorMode);
        }

        private void loadSettings()
        {
            dpi = System.Convert.ToInt32(textBox1.Text);
            if(radioButtonBlackWhite.Checked)
            {
                color = 2;
            }
            if (radioButtonColor.Checked)
            {
                color = 1;
            }
            brightness = (trackBar1.Value - 5) * 20;
            contrast = (trackBar2.Value - 5) * 20;
        }

        private void buttonUI_Click(object sender, EventArgs e)
        {
            /*deviceInfo = deviceManager.DeviceInfos[comboBoxListOfScanner.SelectedIndex + 1];

            var device = deviceInfo.Connect();
            Item scannerItem = device.Items[1];
            var oWIACd = new WIA.CommonDialog();
            var oImageFile = oWIACd.showAcquireImage(scannerItem, color, dpi, WIA.FormatID.wiaFormatJPEG, true, false);*/

 

        }

        private void radioButtonBlackWhite_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void comboBoxFile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

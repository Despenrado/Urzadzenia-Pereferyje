using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using Accord.Video.FFMPEG;
using AForge.Imaging.Filters;


namespace USBCam
{
    public partial class MainWindow : Form
    {
        FilterInfoCollection deviceList;
        VideoCaptureDevice camera;
        VideoFileWriter fileWriterCam;
        int brightess = 0;
        int contrast = 0;
        int saturation = 0;
        bool isRecording = false;

        public MainWindow()
        {
            InitializeComponent();
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            // Zamykanie wszystkich połączń przed wyjsciem
            try
            {
                deviceList.Clear();
                camera.Stop();
                fileWriterCam.Close();
            }
            catch { }
        }
        private void button_searchDev_Click(object sender, EventArgs e)
        {
            cmbDevList1.Items.Clear();
            // pobranie spisu urządzeń
            deviceList = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo videoDevice in deviceList)
            {
                cmbDevList1.Items.Add(videoDevice.Name);
            }
        }

        private void CameraOne_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // inicjalizacja okienka widoka z kamery
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BrightnessCorrection br = new BrightnessCorrection(brightess);
            ContrastCorrection cr = new ContrastCorrection(contrast);
            SaturationCorrection sr = new SaturationCorrection(saturation);
            bitmap = br.Apply((Bitmap)bitmap.Clone());
            bitmap = cr.Apply((Bitmap)bitmap.Clone());
            bitmap = sr.Apply((Bitmap)bitmap.Clone());

            pbCam1.Image = bitmap;

            if (isRecording)
            {
                // zachomujemy kopię okienka z kamery
                fileWriterCam.WriteVideoFrame((Bitmap)bitmap.Clone());
            }
        }


        private void buttonSsCam1_Click(object sender, EventArgs e)
        {
            // przyznaczenie urządzenia z którym bedziemy pracować
            camera = new VideoCaptureDevice(deviceList[cmbDevList1.SelectedIndex].MonikerString);
            camera.NewFrame += new NewFrameEventHandler(CameraOne_NewFrame);
            // włacznie kamery
            camera.Start();
        }

        private void buttonCamOneStop_Click(object sender, EventArgs e)
        {
            // wyłącznie kamery
            camera.Stop();
        }


        private void buttonPictureCamOne_Click(object sender, EventArgs e)
        {
            buttonCamOneStop_Click(sender, e);
            Bitmap picture = (Bitmap)pbCam1.Image;
            saveFileDialog.Filter = "Bitmap Image|*.bmp";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();
            System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
            picture.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
            fs.Close();
            // żeby kamera ciąglie pokazywała widok
            camera.Start();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }



        private void buttonRecordingCamOne_Click(object sender, EventArgs e)
        {
            try
            {
                // początek nagrywania
                fileWriterCam = new VideoFileWriter();
                fileWriterCam.Open("video.avi", pbCam1.Image.Width, pbCam1.Image.Height, 30, VideoCodec.MPEG4);
                isRecording = true;
            }
            catch
            { }
        }
        private void buttonStopRecordingCamOne_Click(object sender, EventArgs e)
        {

        }
        private void TrackBarBrightness(object sender, EventArgs e)
        {
            try
            {
                if (camera.IsRunning)
                    brightess = trackBarBright1.Value;
            }
            catch { }

        }
        private void TrackBarContrast(object sender, EventArgs e)
        {
            try
            {
                if (camera.IsRunning)
                    contrast = trackBarContrast1.Value;
            }
            catch { }
        }

        private void TrackBarSaturation(object sender, EventArgs e)
        {
            try
            {
                if (camera.IsRunning)
                    saturation = trackBarSaturation1.Value;
            }
            catch
            { }
        }

        private void pbCam1_Click(object sender, EventArgs e)
        {

        }

        private void brightness1label_Click(object sender, EventArgs e)
        {

        }

        private void buttonStopRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (camera.IsRunning)
                {
                    isRecording = false;
                    fileWriterCam.Close();
                    saveFileDialog.Filter = "Avi Files (*.avi)|*.avi";
                    saveFileDialog.Title = "Save a Video File";
                    saveFileDialog.ShowDialog();
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                    fs.Close();
                }
            }
            catch { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Test
{
//    namespace System.Windows.Media
//   {
//        MediaPlayer
//    }
    public partial class Form1 : Form
    {
        
        private string fileName;
        private MyPlaySound myPlaySound = new MyPlaySound();
        private MyMCI myMCI = new MyMCI();
        private MyDirectSound myDirectSound = new MyDirectSound();
        private Thread thread;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "WMV|*.wmv|WAV|*.wav|MP3|*.mp3" })
            {
                if(openFile.ShowDialog() == DialogResult.OK)
                {
                    //string fileName = openFile.FileName;
                    //FileInfo fileInfo = new FileInfo(fileName);
                    //MediaFile mediaFile = new MediaFile() { FileName = Path.GetFileNameWithoutExtension(fileInfo.FullName), Path = fileInfo.FullName};
                    textBox.Text = openFile.FileName;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileName = textBox.Text;
            FileInfo fileInfo = new FileInfo(fileName);
            MediaFile mediaFile = new MediaFile() { FileName = Path.GetFileNameWithoutExtension(fileInfo.FullName), Path = fileInfo.FullName };
            if (mediaFile != null)
            {
                myPlaySound.loadPlaySound(fileName);

                axWindowsMediaPlayer1.URL = mediaFile.Path;
                axWindowsMediaPlayer1.Ctlcontrols.stop();


                myMCI.loadMCI(fileName);

                myDirectSound.loadDirectSound(fileName, this.Handle);
            }
        }

        private void button3_Click(object sender, EventArgs e)//StartButton WMP
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button4_Click(object sender, EventArgs e)//StopButton WMP
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void pauseButton_Click(object sender, EventArgs e)//PauseButton WMP
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void buttonStartSoundPlay_Click(object sender, EventArgs e)
        {
            myPlaySound.startPlaySound();
        }

        

        //[SecurityPermissionAttribute(SecurityAction.Demand, ControlThread = true)]
        private void buttonStopPlaySound_Click(object sender, EventArgs e)
        {
            myPlaySound.stopPlaySound();
        }

        private void buttonStart_Click(object sender, EventArgs e)//MCI
        {
            myMCI.startMCI();
        }

        private void buttonStopMCI_Click(object sender, EventArgs e)//MCI
        {
            myMCI.stopMCI(fileName);
        }

        private void buttonPauseMCI_Click(object sender, EventArgs e)
        {
            myMCI.pauseMCI();
        }

        private void buttonStartDirectSound_Click(object sender, EventArgs e)
        {
            myDirectSound.startDirectSound();
        }

        private void buttonStopDirectSound_Click(object sender, EventArgs e)
        {
            myDirectSound.stopDirectSound();
        }

        private void buttonPauseDerectSound_Click(object sender, EventArgs e)
        {
            myDirectSound.pasueDirectSound();
        }

        private void buttonRecordMCI_Click(object sender, EventArgs e)
        {
            myMCI.recordMCI();
        }

        private void buttonRecordDirectSound_Click(object sender, EventArgs e)
        {
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonStopRecordDirectDound_Click(object sender, EventArgs e)
        {
        }

        private void buttonStopRecordMCI_Click(object sender, EventArgs e)
        {
            myMCI.stopRecording();
        }
    }
}

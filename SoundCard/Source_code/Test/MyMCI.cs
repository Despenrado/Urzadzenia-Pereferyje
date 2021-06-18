using System;
using System.Text;

namespace Test
{
    class MyMCI
    {
        [System.Runtime.InteropServices.DllImport("winmm.dll")]
        private static extern int mciSendString(string strCommand,
        StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);
        [System.Runtime.InteropServices.DllImport("winmm.dll")]
        public static extern int mciGetErrorString(int errCode,
                      StringBuilder errMsg, int buflen);
        public void loadMCI(string fileName)
        {
            mciSendString("open waveaudio!" + fileName + " alias myaudio wait", null, 0, IntPtr.Zero);
        }
        public void startMCI()
        {
            mciSendString("play myaudio", null, 0, IntPtr.Zero);
        }

        public void stopMCI(string fileName)
        {
            loadMCI(fileName);
            mciSendString("stop myaudio", null, 0, IntPtr.Zero);
        }

        public void pauseMCI()
        {
            mciSendString("pause myaudio", null, 0, IntPtr.Zero);
        }

        public void recordMCI()
        {
            mciSendString("open new Type waveaudio alias recsound", null, 0, IntPtr.Zero);
            mciSendString("record recsound", null, 0, IntPtr.Zero);
        }

        public void stopRecording()
        {
            mciSendString("save recsound 123.wav", null, 0, IntPtr.Zero);
            mciSendString("close recsound ", null, 0, IntPtr.Zero);
        }
    }
}

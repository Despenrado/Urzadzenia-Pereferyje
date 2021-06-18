using System;
using System.Threading;
using System.Security.Permissions;
using System.Runtime.InteropServices;

namespace Test
{
    class MyPlaySound
    {
        [System.Runtime.InteropServices.DllImport("winmm.DLL", EntryPoint = "PlaySound", SetLastError = true, CharSet = CharSet.Unicode, ThrowOnUnmappableChar = true)]
        private static extern bool PlaySound(string szSound, System.IntPtr hMod, PlaySoundFlags flags);

        [System.Flags]
        public enum PlaySoundFlags : int
        {
            SND_SYNC = 0x0000,
            SND_ASYNC = 0x0001,
            SND_NODEFAULT = 0x0002,
            SND_LOOP = 0x0008,
            SND_NOSTOP = 0x0010,
            SND_NOWAIT = 0x00002000,
            SND_FILENAME = 0x00020000,
            SND_RESOURCE = 0x00040004
        }

        private string fileName;
        private Thread threadPlaySound;

        public void loadPlaySound(string filename)
        {
            this.fileName = filename;
        }

        private void run()
        {
            PlaySound(fileName, new System.IntPtr(), PlaySoundFlags.SND_SYNC);
        }

        public void startPlaySound()
        {
            threadPlaySound = new Thread(run);
            threadPlaySound.Start();
            run();
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, ControlThread = true)]
        public void stopPlaySound()
        {
            threadPlaySound.Abort();
            PlaySound("", new System.IntPtr(), PlaySoundFlags.SND_ASYNC);
            threadPlaySound.Abort();
        }
    }
}

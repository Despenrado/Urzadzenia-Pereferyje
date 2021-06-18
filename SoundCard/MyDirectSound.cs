using System;
using Microsoft.DirectX.DirectSound;
using System.IO;
using Buffer = Microsoft.DirectX.DirectSound.SecondaryBuffer;


namespace Test
{
    class MyDirectSound
    {
        private SecondaryBuffer sound;

       
        public void loadDirectSound(string fileName, IntPtr handle)
        {
            Device dSound = new Device();
            dSound = new Device();
            dSound.SetCooperativeLevel(handle, CooperativeLevel.Normal);
            BufferDescription bufferDescription = new BufferDescription();
            bufferDescription.ControlPan = false;
            bufferDescription.ControlVolume = false;
            bufferDescription.ControlFrequency = false;
            bufferDescription.ControlEffects = false;
            sound = new SecondaryBuffer(fileName, bufferDescription, dSound);
        }

       public void startDirectSound()
        {
            sound.Play(0, BufferPlayFlags.Default);
        }
        public void stopDirectSound()
        {
            sound.Stop();
            sound.SetCurrentPosition(0);
        }
        public void pasueDirectSound()
        {
            sound.Stop();
        }
    }
}

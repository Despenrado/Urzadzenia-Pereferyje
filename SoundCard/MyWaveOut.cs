using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;

namespace Test
{
    public enum MMRESULT
    {
        MMSYSERR_NOERROR = 0,
        MMSYSERR_ERROR = (MMSYSERR_NOERROR + 1),
        MMSYSERR_BADDEVICEID = (MMSYSERR_NOERROR + 2),
        MMSYSERR_NOTENABLED = (MMSYSERR_NOERROR + 3),
        MMSYSERR_ALLOCATED = (MMSYSERR_NOERROR + 4),
        MMSYSERR_INVALHANDLE = (MMSYSERR_NOERROR + 5),
        MMSYSERR_NODRIVER = (MMSYSERR_NOERROR + 6),
        MMSYSERR_NOMEM = (MMSYSERR_NOERROR + 7),
        MMSYSERR_NOTSUPPORTED = (MMSYSERR_NOERROR + 8),
        MMSYSERR_BADERRNUM = (MMSYSERR_NOERROR + 9),
        MMSYSERR_INVALFLAG = (MMSYSERR_NOERROR + 10),
        MMSYSERR_INVALPARAM = (MMSYSERR_NOERROR + 11),
        MMSYSERR_HANDLEBUSY = (MMSYSERR_NOERROR + 12),
        MMSYSERR_INVALIDALIAS = (MMSYSERR_NOERROR + 13),
        MMSYSERR_BADDB = (MMSYSERR_NOERROR + 14),
        MMSYSERR_KEYNOTFOUND = (MMSYSERR_NOERROR + 15),
        MMSYSERR_READERROR = (MMSYSERR_NOERROR + 16),
        MMSYSERR_WRITEERROR = (MMSYSERR_NOERROR + 17),
        MMSYSERR_DELETEERROR = (MMSYSERR_NOERROR + 18),
        MMSYSERR_VALNOTFOUND = (MMSYSERR_NOERROR + 19),
        MMSYSERR_NODRIVERCB = (MMSYSERR_NOERROR + 20),
        MMSYSERR_MOREDATA = (MMSYSERR_NOERROR + 21),
        MMSYSERR_LASTERROR = (MMSYSERR_NOERROR + 21)
    }

    public enum WAVEHDR_FLAG
    {
        WHDR_DONE = 0x00000001,
        WHDR_PREPARED = 0x00000002,
        WHDR_BEGINLOOP = 0x00000004,
        WHDR_ENDLOOP = 0x00000008,
        WHDR_INQUEUE = 0x00000010
    }

    public enum TIME_TYPE
    {
        TIME_MS = 0x0001,
        TIME_SAMPLES = 0x0002,
        TIME_BYTES = 0x0004,
        TIME_SMPTE = 0x0008,
        TIME_MIDI = 0x0010,
        TIME_TICKS = 0x0020
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WAVEFORMATEX
    {
        public ushort wFormatTag;
        public ushort nChannels;
        public uint nSamplesPerSec;
        public uint nAvgBytesPerSec;
        public ushort nBlockAlign;
        public ushort wBitsPerSample;
        public ushort cbSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WAVEHDR
    {
        public IntPtr lpData;
        public uint dwBufferLength;
        public uint dwBytesRecorded;
        public uint dwUser;
        public uint dwFlags;
        public uint dwLoops;
        public IntPtr lpNext;
        public uint reserved;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MMTIME
    {
        [FieldOffset(0)]
        public uint wType;
        [FieldOffset(4)]
        public uint ms;
        [FieldOffset(4)]
        public uint sample;
        [FieldOffset(4)]
        public uint cb;
        [FieldOffset(4)]
        public uint ticks;
        [FieldOffset(4)]
        public ushort hour;
        [FieldOffset(6)]
        public ushort min;
        [FieldOffset(8)]
        public ushort sec;
        [FieldOffset(10)]
        public ushort frame;
        [FieldOffset(12)]
        public ushort fps;
        [FieldOffset(14)]
        public ushort dummy;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ushort[] pad;
        [FieldOffset(4)]
        public uint songptrpos;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WAVEINCAPS
    {
        public ushort wMid;
        public ushort wPid;
        public uint vDriverVersion;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public char[] szPname;
        uint dwFormats;
        ushort wChannels;
        ushort wReserved1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WAVEOUTCAPS
    {
        public ushort wMid;
        public ushort wPid;
        public uint vDriverVersion;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public char[] szPname;
        public uint dwFormats;
        public ushort wChannels;
        public ushort wReserved1;
        public uint dwSupport;
    }

    public enum WaveOutMessage
    {
        Close = 0x3BC,
        Done = 0x3BD,
        Open = 0x3BB
    }


    class MyWaveOut
    {
        private const uint WAVE_MAPPER = unchecked((uint)(-1));

        private const uint CALLBACK_NULL = 0x00000000; /* no callback */
        private const uint CALLBACK_WINDOW = 0x00010000; /* dwCallback is a HWND */
        private const uint CALLBACK_TASK = 0x00020000; /* dwCallback is a HTASK */
        private const uint CALLBACK_FUNCTION = 0x00030000; /* dwCallback is a FARPROC */

        [DllImport("winmm.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern MMRESULT waveOutOpen(ref IntPtr hWaveOut, uint uDeviceID, ref WAVEFORMATEX lpFormat, WaveOutProc dwCallback, IntPtr dwInstance, uint dwFlags);

        [DllImport("winmm.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern MMRESULT waveOutClose(IntPtr hwo);

        [DllImport("winmm.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern MMRESULT waveOutPrepareHeader(IntPtr hWaveOut, IntPtr lpWaveOutHdr, int uSize);

        [DllImport("winmm.dll")]
        public static extern MMRESULT waveOutUnprepareHeader(IntPtr hWaveOut, IntPtr lpWaveOutHdr, uint cbwh);

        [DllImport("winmm.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern MMRESULT waveOutReset(IntPtr hwo);

        [DllImport("winmm.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern MMRESULT waveOutWrite(IntPtr hwo, IntPtr pwh, uint cbwh);

        //callbacks
        public delegate void WaveOutProc(IntPtr hdrvr, WaveOutMessage uMsg, int dwUser, IntPtr wavhdr, int dwParam2);

        private IntPtr WaveOutHandle;
        private IntPtr WaveHandlePtr;

        private WAVEFORMATEX WaveFormatEx;
        private byte[] WaveDataBuffer;

        private FileStream fs;
        private BinaryReader br;

        private WaveOutProc m_BufferProc;
        private int BufferSize = 0;
        //[System.Runtime.InteropServices.DllImport("winmm.dll")];
        /*public static extern int waveOutOpen(out IntPtr hWaveOut, int uDeviceID, WaveFormat lpFormat,
                                         WaveDelegate dwCallback, IntPtr dwInstance, int dwFlags);*/

        public MyWaveOut()
        {
            WaveOutHandle = IntPtr.Zero;
        }

        public void OpenFile(string FileName)
        {
            fs = new FileStream(FileName, FileMode.Open);
            br = new BinaryReader(fs, Encoding.ASCII);

            char[] readbuf;
            readbuf = br.ReadChars(4);

            if (readbuf.ToString() == "RIFF")
            {
            }
            br.ReadBytes(4);//空

            readbuf = br.ReadChars(4);
            if (readbuf.ToString() == "WAVE")
            {
            }

            readbuf = br.ReadChars(4);
            if (readbuf.ToString() == "fmt ")
            {
            }

            // 'fmt 'チャンクのサイズ読み取り
            int chank = br.ReadInt32();

            // ヘッダを読み取り waveformatex構造体に代入     
            byte[] WaveFormatExBuffer = br.ReadBytes(Marshal.SizeOf(typeof(WAVEFORMATEX)) - Marshal.SizeOf(typeof(ushort)) * 2);
            GCHandle gch = GCHandle.Alloc(WaveFormatExBuffer, GCHandleType.Pinned);
            WaveFormatEx = (WAVEFORMATEX)Marshal.PtrToStructure(gch.AddrOfPinnedObject(), typeof(WAVEFORMATEX));
            gch.Free();
            WaveFormatEx.cbSize = (ushort)Marshal.SizeOf(typeof(WAVEFORMATEX));

            readbuf = br.ReadChars(4);
            if (readbuf.ToString() == "fact")
            {
                br.ReadBytes(4);
                br.ReadBytes(1);
                br.ReadBytes(4);
            }

            if (readbuf.ToString() == "data")
            {
            }

            BufferSize = (int)WaveFormatEx.nSamplesPerSec * (int)WaveFormatEx.nBlockAlign;
            OpenWaveOutHandle();
            WaveHandlePtr = PrepareHeader();
        }

        public void CloseFile()
        {
            br.Close();
            fs.Close();

            Marshal.FreeHGlobal(WaveHandlePtr);

            if (WaveOutHandle != IntPtr.Zero)
            {
                waveOutReset(WaveOutHandle);
                waveOutUnprepareHeader(WaveOutHandle, WaveHandlePtr, (uint)Marshal.SizeOf(typeof(WAVEHDR)));
                waveOutClose(WaveOutHandle);
            }
        }

        public void Play()
        {
            MMRESULT rc = waveOutWrite(WaveOutHandle, WaveHandlePtr, (uint)Marshal.SizeOf(typeof(WAVEHDR)));
        }

        public void Stop()
        {
            if (WaveOutHandle != IntPtr.Zero)
            {
                MMRESULT mr = waveOutReset(WaveOutHandle);
                if (mr == MMRESULT.MMSYSERR_NOERROR)
                {
                }
                mr = waveOutClose(WaveOutHandle);
                if (mr == MMRESULT.MMSYSERR_NOERROR)
                {

                }
                WaveOutHandle = IntPtr.Zero;
            }
        }

        public void OpenWaveOutHandle()
        {
            if (WaveOutHandle != IntPtr.Zero)
            {
                MMRESULT mr = waveOutReset(WaveOutHandle);
                if (mr == MMRESULT.MMSYSERR_NOERROR)
                {
                }
                mr = waveOutClose(WaveOutHandle);
                if (mr == MMRESULT.MMSYSERR_NOERROR)
                {
                }
                WaveOutHandle = IntPtr.Zero;
            }

            m_BufferProc = new WaveOutProc(WaveOutProcCallback);
            MMRESULT rc = waveOutOpen(ref WaveOutHandle, WAVE_MAPPER, ref WaveFormatEx, m_BufferProc, IntPtr.Zero, CALLBACK_FUNCTION);
        }


        public IntPtr PrepareHeader()
        {
            WAVEHDR WaveHeader = new WAVEHDR();
            IntPtr WaveHdrPtr = new IntPtr();
            WaveHdrPtr = Marshal.AllocHGlobal(Marshal.SizeOf(WaveHeader));

            WaveDataBuffer = br.ReadBytes((int)BufferSize);

            IntPtr parray = Marshal.AllocCoTaskMem(WaveDataBuffer.Length);
            Marshal.Copy(WaveDataBuffer, 0, parray, WaveDataBuffer.Length);

            WaveHeader.lpData = parray;
            WaveHeader.dwBufferLength = (uint)WaveDataBuffer.Length;

            WaveHeader.dwFlags = 0;
            Marshal.StructureToPtr(WaveHeader, WaveHdrPtr, true);

            MMRESULT mmrc = waveOutPrepareHeader(WaveOutHandle, WaveHdrPtr, Marshal.SizeOf(typeof(WAVEHDR)));

            return WaveHdrPtr;
        }

        public void WaveOutProcCallback(IntPtr hdrvr, WaveOutMessage uMsg, int dwUser, IntPtr wavhdr, int dwParam2)
        {
            switch (uMsg)
            {
                case WaveOutMessage.Close:
                    break;
                case WaveOutMessage.Done:

                    WaveDataBuffer = br.ReadBytes((int)BufferSize);

                    if (0 < WaveDataBuffer.Length)
                    {
                        WAVEHDR wh = new WAVEHDR();

                        wh = (WAVEHDR)Marshal.PtrToStructure(wavhdr, typeof(WAVEHDR));


                        if (WaveDataBuffer.Length < BufferSize)
                        {
                            Marshal.FreeCoTaskMem(wh.lpData);
                            wh.lpData = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(byte)) * WaveDataBuffer.Length);
                            wh.dwBufferLength = (uint)WaveDataBuffer.Length;
                        }

                        Marshal.Copy(WaveDataBuffer, 0, wh.lpData, WaveDataBuffer.Length);
                        Marshal.StructureToPtr(wh, wavhdr, true);

                        MMRESULT rc = waveOutWrite(WaveOutHandle, (IntPtr)wavhdr, (uint)Marshal.SizeOf(typeof(WAVEHDR)));
                    }
                    break;
                case WaveOutMessage.Open:
                    break;
            }
        }
    }


}

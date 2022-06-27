using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyAudioPlayer
{
    class Player
    {
        private string Pcommand;
        private bool isOpen;

        [DllImport("winmm.dll")]

        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, int bla);

        public void Close()
        {
            Pcommand = "close MediaFile";
            mciSendString(Pcommand, null, 0, 0);
            isOpen = false;
        }

        public void Open(string sFileName)
        {
            Pcommand = "open \"" + sFileName + "\" type mpegvideo alias MediaFile";
            mciSendString(Pcommand, null, 0, 0);
            isOpen = true;
        }

        public void Play(bool loop)
        {
            if (isOpen)
            {
                Pcommand = "play MediaFile";
                if (loop)
                {
                    Pcommand += " REPEAT";
                }
                mciSendString(Pcommand, null, 0, 0);
            }
        }

        public void Pause()
        {
            Pcommand = "pause MediaFile";
            mciSendString(Pcommand, null, 0, 0);
        }

        public string Status()
        {
            int i = 128;
            StringBuilder stringBuilder = new StringBuilder(i);
            mciSendString("status MediaFile mode", stringBuilder, i, 0);
            return stringBuilder.ToString();
        }

        public int LeftVolume
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile left volume to ", value), null, 0, 0);
            }
        }

        public int RightVolume
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile right volume to ", value), null, 0, 0);
            }
        }

        public int MasterVolume
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile volume to ", value), null, 0, 0);
            }
        }

        public int Bass
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile bass to ", value), null, 0, 0);
            }
        }

        public int Treble
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile treble to ", value), null, 0, 0);
            }
        }
    }
}

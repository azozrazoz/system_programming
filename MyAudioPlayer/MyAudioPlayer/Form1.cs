using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAudioPlayer
{
    public partial class Form1 : Form
    {
        const uint WM_SETTEXT = 0x0C;
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hwnd, uint Msg, int wParam,
            [MarshalAs(UnmanagedType.LPStr)] string lParam);
        ArrayList nowPlayList = new ArrayList();
        private Player player = new Player();
        public Process CurrentProcess => Process.GetCurrentProcess();
        public Form1()
        {
            InitializeComponent();
            listBoxPlaylist.Items.Add(@"C:\Users\itstart.ITSTEP\Documents\Daft Punk - Get Lucky.mp3");

            SendMessage(CurrentProcess.MainWindowHandle, WM_SETTEXT, 0, "Запущен");
        }

        private void Open_Click(object sender, EventArgs e)
        {
            listBoxPlaylist.Items.Clear();
            openPlaylistDialog.ShowDialog();
            readPlayList readList = new readPlayList();
            readList.PlayListPath = openPlaylistDialog.FileName;
            nowPlayList = readList.PlayList;
            for (int i = 0; i < nowPlayList.Count; i++)
            {
                listBoxPlaylist.Items.Add(nowPlayList[i]);
            }
            listBoxPlaylist.SetSelected(0, true);
        }

        private void Play_Click(object sender, EventArgs e)
        {
            player.Play(false);
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            player.Pause();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            SendMessage(CurrentProcess.MainWindowHandle, WM_SETTEXT, 0, "Остановлен");
            player.Close();
        }

        private void listBoxPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.Close();
            player.Open(listBoxPlaylist.SelectedItem.ToString());
            player.Play(false);
        }
    }
}

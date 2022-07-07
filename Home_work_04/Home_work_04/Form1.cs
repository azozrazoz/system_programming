using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Home_work_04
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            winners.Clear();
            FinishBox.Text = "";
            
            for (int i = 0; i < 10; i++)
            {
                WaitCallback wc = new WaitCallback(StartRace);
                ThreadPool.QueueUserWorkItem(wc, i);
            }
        }
        List<ProgressBar> winners = new List<ProgressBar>();
        private void StartRace(object i)
        {
            Random rnd = new Random();
            List<ProgressBar> progressBars = new List<ProgressBar>()
            {
                progressBar1,
                progressBar2,
                progressBar3,
                progressBar4,
                progressBar5,
                progressBar6,
                progressBar7,
                progressBar8,
                progressBar9,
                progressBar10,
            };

            
            try
            {
                while (true)
                {
                    if (progressBars[(int)i].Value >= 100)
                    {
                        winners.Add(progressBars[(int)i]);
                        return;
                    }
                        

                    progressBars[(int)i].Value += rnd.Next(0, 20);
                    Thread.Sleep(500);
                    
                }
            }
            catch
            {
                progressBars[(int)i].Value = 100;
                winners.Add(progressBars[(int)i]);                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ProgressBar> progressBars = new List<ProgressBar>()
            {
                progressBar1,
                progressBar2,
                progressBar3,
                progressBar4,
                progressBar5,
                progressBar6,
                progressBar7,
                progressBar8,
                progressBar9,
                progressBar10,
            };

            foreach (var prog in progressBars)
            {
                prog.Value = 0;
            }
            foreach (var win in winners)
            {
                FinishBox.Text += $"{win.Name}\r\n";
            }
        }
    }
}

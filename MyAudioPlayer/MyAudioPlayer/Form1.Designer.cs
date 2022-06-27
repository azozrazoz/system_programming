
namespace MyAudioPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.listBoxPlaylist = new System.Windows.Forms.ListBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.LeftBar = new System.Windows.Forms.TrackBar();
            this.RightBar = new System.Windows.Forms.TrackBar();
            this.MaterBar = new System.Windows.Forms.TrackBar();
            this.BassBar = new System.Windows.Forms.TrackBar();
            this.TrebleBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.openPlaylistDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BassBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrebleBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(347, 12);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(428, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // listBoxPlaylist
            // 
            this.listBoxPlaylist.FormattingEnabled = true;
            this.listBoxPlaylist.Items.AddRange(new object[] {
            "ListBoxPlayList"});
            this.listBoxPlaylist.Location = new System.Drawing.Point(12, 41);
            this.listBoxPlaylist.Name = "listBoxPlaylist";
            this.listBoxPlaylist.Size = new System.Drawing.Size(491, 134);
            this.listBoxPlaylist.TabIndex = 3;
            this.listBoxPlaylist.SelectedIndexChanged += new System.EventHandler(this.listBoxPlaylist_SelectedIndexChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.Open_Click);
            // 
            // LeftBar
            // 
            this.LeftBar.Location = new System.Drawing.Point(30, 33);
            this.LeftBar.Name = "LeftBar";
            this.LeftBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.LeftBar.Size = new System.Drawing.Size(45, 178);
            this.LeftBar.TabIndex = 5;
            this.LeftBar.Value = 5;
            // 
            // RightBar
            // 
            this.RightBar.Location = new System.Drawing.Point(91, 33);
            this.RightBar.Name = "RightBar";
            this.RightBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RightBar.Size = new System.Drawing.Size(45, 178);
            this.RightBar.TabIndex = 6;
            this.RightBar.Value = 5;
            // 
            // MaterBar
            // 
            this.MaterBar.Location = new System.Drawing.Point(30, 33);
            this.MaterBar.Name = "MaterBar";
            this.MaterBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.MaterBar.Size = new System.Drawing.Size(45, 178);
            this.MaterBar.TabIndex = 7;
            this.MaterBar.Value = 5;
            // 
            // BassBar
            // 
            this.BassBar.Location = new System.Drawing.Point(49, 33);
            this.BassBar.Name = "BassBar";
            this.BassBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BassBar.Size = new System.Drawing.Size(45, 178);
            this.BassBar.TabIndex = 8;
            this.BassBar.Value = 5;
            // 
            // TrebleBar
            // 
            this.TrebleBar.Location = new System.Drawing.Point(126, 33);
            this.TrebleBar.Name = "TrebleBar";
            this.TrebleBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrebleBar.Size = new System.Drawing.Size(45, 178);
            this.TrebleBar.TabIndex = 9;
            this.TrebleBar.Value = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Right";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Master";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Bass";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Treble";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RightBar);
            this.groupBox1.Controls.Add(this.LeftBar);
            this.groupBox1.Location = new System.Drawing.Point(12, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 251);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Left/Right Volume";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.MaterBar);
            this.groupBox2.Location = new System.Drawing.Point(173, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 251);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main Volume";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.BassBar);
            this.groupBox3.Controls.Add(this.TrebleBar);
            this.groupBox3.Location = new System.Drawing.Point(286, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 251);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sound";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(266, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 18;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.Play_Click);
            // 
            // openPlaylistDialog
            // 
            this.openPlaylistDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.listBoxPlaylist);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Name = "Form1";
            this.Text = "Audio player";
            ((System.ComponentModel.ISupportInitialize)(this.LeftBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BassBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrebleBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox listBoxPlaylist;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TrackBar LeftBar;
        private System.Windows.Forms.TrackBar RightBar;
        private System.Windows.Forms.TrackBar MaterBar;
        private System.Windows.Forms.TrackBar BassBar;
        private System.Windows.Forms.TrackBar TrebleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.OpenFileDialog openPlaylistDialog;
    }
}


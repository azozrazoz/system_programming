
namespace Home_work_04
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.progressBar7 = new System.Windows.Forms.ProgressBar();
            this.progressBar8 = new System.Windows.Forms.ProgressBar();
            this.progressBar9 = new System.Windows.Forms.ProgressBar();
            this.progressBar10 = new System.Windows.Forms.ProgressBar();
            this.Start = new System.Windows.Forms.Button();
            this.FinishBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(297, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 41);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(297, 23);
            this.progressBar2.TabIndex = 1;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(12, 70);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(297, 23);
            this.progressBar3.TabIndex = 2;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(12, 99);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(297, 23);
            this.progressBar4.TabIndex = 3;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(12, 128);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(297, 23);
            this.progressBar5.TabIndex = 4;
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(12, 158);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(297, 23);
            this.progressBar6.TabIndex = 5;
            // 
            // progressBar7
            // 
            this.progressBar7.Location = new System.Drawing.Point(12, 188);
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(297, 23);
            this.progressBar7.TabIndex = 6;
            // 
            // progressBar8
            // 
            this.progressBar8.Location = new System.Drawing.Point(12, 218);
            this.progressBar8.Name = "progressBar8";
            this.progressBar8.Size = new System.Drawing.Size(297, 23);
            this.progressBar8.TabIndex = 7;
            // 
            // progressBar9
            // 
            this.progressBar9.Location = new System.Drawing.Point(12, 248);
            this.progressBar9.Name = "progressBar9";
            this.progressBar9.Size = new System.Drawing.Size(297, 23);
            this.progressBar9.TabIndex = 8;
            // 
            // progressBar10
            // 
            this.progressBar10.Location = new System.Drawing.Point(12, 278);
            this.progressBar10.Name = "progressBar10";
            this.progressBar10.Size = new System.Drawing.Size(297, 23);
            this.progressBar10.TabIndex = 9;
            // 
            // Start
            // 
            this.Start.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Start.Location = new System.Drawing.Point(0, 504);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(321, 29);
            this.Start.TabIndex = 10;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // FinishBox
            // 
            this.FinishBox.Enabled = false;
            this.FinishBox.Location = new System.Drawing.Point(13, 308);
            this.FinishBox.Multiline = true;
            this.FinishBox.Name = "FinishBox";
            this.FinishBox.Size = new System.Drawing.Size(296, 162);
            this.FinishBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FinishBox);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.progressBar10);
            this.Controls.Add(this.progressBar9);
            this.Controls.Add(this.progressBar8);
            this.Controls.Add(this.progressBar7);
            this.Controls.Add(this.progressBar6);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Horse racing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.ProgressBar progressBar7;
        private System.Windows.Forms.ProgressBar progressBar8;
        private System.Windows.Forms.ProgressBar progressBar9;
        private System.Windows.Forms.ProgressBar progressBar10;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox FinishBox;
        private System.Windows.Forms.Button button1;
    }
}



namespace Home_work_06
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
            this.OpenBanWords = new System.Windows.Forms.OpenFileDialog();
            this.Start = new System.Windows.Forms.Button();
            this.FolderForBanWords = new System.Windows.Forms.FolderBrowserDialog();
            this.ChooseFolder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbBanWords = new System.Windows.Forms.TextBox();
            this.tbMainPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenBanWords
            // 
            this.OpenBanWords.FileName = "openFileDialog1";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(236, 12);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // ChooseFolder
            // 
            this.ChooseFolder.Location = new System.Drawing.Point(115, 12);
            this.ChooseFolder.Name = "ChooseFolder";
            this.ChooseFolder.Size = new System.Drawing.Size(115, 23);
            this.ChooseFolder.TabIndex = 1;
            this.ChooseFolder.Text = "Choose Folder";
            this.ChooseFolder.UseVisualStyleBackColor = true;
            this.ChooseFolder.Click += new System.EventHandler(this.ChooseFolder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Load ban words";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbBanWords
            // 
            this.tbBanWords.Location = new System.Drawing.Point(12, 80);
            this.tbBanWords.Multiline = true;
            this.tbBanWords.Name = "tbBanWords";
            this.tbBanWords.Size = new System.Drawing.Size(299, 299);
            this.tbBanWords.TabIndex = 3;
            // 
            // tbMainPath
            // 
            this.tbMainPath.Location = new System.Drawing.Point(12, 54);
            this.tbMainPath.Name = "tbMainPath";
            this.tbMainPath.Size = new System.Drawing.Size(299, 20);
            this.tbMainPath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Путь к файлам";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMainPath);
            this.Controls.Add(this.tbBanWords);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ChooseFolder);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Ban words";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenBanWords;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.FolderBrowserDialog FolderForBanWords;
        private System.Windows.Forms.Button ChooseFolder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbBanWords;
        private System.Windows.Forms.TextBox tbMainPath;
        private System.Windows.Forms.Label label1;
    }
}


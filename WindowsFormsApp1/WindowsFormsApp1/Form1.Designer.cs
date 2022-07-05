
namespace WindowsFormsApp1
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
            this.SecondsInTime = new System.Windows.Forms.Button();
            this.DefaultTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SecondsInTime
            // 
            this.SecondsInTime.Location = new System.Drawing.Point(12, 12);
            this.SecondsInTime.Name = "SecondsInTime";
            this.SecondsInTime.Size = new System.Drawing.Size(163, 23);
            this.SecondsInTime.TabIndex = 0;
            this.SecondsInTime.Text = "Seconds in time";
            this.SecondsInTime.UseVisualStyleBackColor = true;
            this.SecondsInTime.Click += new System.EventHandler(this.SecondsInTime_Click);
            // 
            // DefaultTime
            // 
            this.DefaultTime.Location = new System.Drawing.Point(12, 41);
            this.DefaultTime.Name = "DefaultTime";
            this.DefaultTime.Size = new System.Drawing.Size(163, 23);
            this.DefaultTime.TabIndex = 1;
            this.DefaultTime.Text = "Default time";
            this.DefaultTime.UseVisualStyleBackColor = true;
            this.DefaultTime.Click += new System.EventHandler(this.DefaultTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 437);
            this.Controls.Add(this.DefaultTime);
            this.Controls.Add(this.SecondsInTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SecondsInTime;
        private System.Windows.Forms.Button DefaultTime;
    }
}


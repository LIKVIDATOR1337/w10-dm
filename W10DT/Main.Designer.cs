namespace W10DM
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.on = new System.Windows.Forms.Button();
            this.off = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.st = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // on
            // 
            this.on.Location = new System.Drawing.Point(12, 60);
            this.on.Name = "on";
            this.on.Size = new System.Drawing.Size(283, 23);
            this.on.TabIndex = 0;
            this.on.Text = "Enable";
            this.on.UseVisualStyleBackColor = true;
            this.on.Click += new System.EventHandler(this.on_Click);
            // 
            // off
            // 
            this.off.Location = new System.Drawing.Point(12, 89);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(283, 23);
            this.off.TabIndex = 1;
            this.off.Text = "Disable";
            this.off.UseVisualStyleBackColor = true;
            this.off.Click += new System.EventHandler(this.off_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Windows 10 Dark Theme Enabler\r\n        Coded by LIKVIDATOR\r\n";
            // 
            // st
            // 
            this.st.AutoSize = true;
            this.st.Location = new System.Drawing.Point(13, 41);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(0, 13);
            this.st.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 121);
            this.Controls.Add(this.st);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.off);
            this.Controls.Add(this.on);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "W10 Dark Theme Enabler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button on;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label st;
        private System.Windows.Forms.Timer timer;
    }
}


namespace WindowsForms002_TH
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inputNametextBox = new System.Windows.Forms.TextBox();
            this.downLoadPicture = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(61, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 335);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMoveForRectangle);
            // 
            // inputNametextBox
            // 
            this.inputNametextBox.Location = new System.Drawing.Point(549, 84);
            this.inputNametextBox.Name = "inputNametextBox";
            this.inputNametextBox.Size = new System.Drawing.Size(144, 20);
            this.inputNametextBox.TabIndex = 1;
            // 
            // downLoadPicture
            // 
            this.downLoadPicture.Location = new System.Drawing.Point(422, 43);
            this.downLoadPicture.Name = "downLoadPicture";
            this.downLoadPicture.Size = new System.Drawing.Size(121, 23);
            this.downLoadPicture.TabIndex = 2;
            this.downLoadPicture.Text = "DownLoad";
            this.downLoadPicture.UseVisualStyleBackColor = true;
            this.downLoadPicture.Click += new System.EventHandler(this.downLoadPicture_Click_1);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(422, 84);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(121, 23);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click_1);
            this.Save.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.downLoadPicture);
            this.Controls.Add(this.inputNametextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox inputNametextBox;
        private System.Windows.Forms.Button downLoadPicture;
        private System.Windows.Forms.Button Save;
    }
}


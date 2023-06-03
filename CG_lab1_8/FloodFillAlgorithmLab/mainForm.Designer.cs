namespace FloodFillAlgorithmLab
{
    partial class mainForm
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
            this.pbSource = new System.Windows.Forms.PictureBox();
            this.pbRes = new System.Windows.Forms.PictureBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.dOpen = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRes)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSource
            // 
            this.pbSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSource.Location = new System.Drawing.Point(12, 56);
            this.pbSource.Name = "pbSource";
            this.pbSource.Size = new System.Drawing.Size(402, 250);
            this.pbSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSource.TabIndex = 0;
            this.pbSource.TabStop = false;
            this.pbSource.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbSource_MouseClick);
            // 
            // pbRes
            // 
            this.pbRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbRes.Location = new System.Drawing.Point(12, 355);
            this.pbRes.Name = "pbRes";
            this.pbRes.Size = new System.Drawing.Size(402, 250);
            this.pbRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRes.TabIndex = 1;
            this.pbRes.TabStop = false;
            // 
            // btOpen
            // 
            this.btOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btOpen.Location = new System.Drawing.Point(14, 12);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(402, 38);
            this.btOpen.TabIndex = 2;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // dOpen
            // 
            this.dOpen.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Result";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.pbRes);
            this.Controls.Add(this.pbSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = "FloodFillAlgorithm";
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSource;
        private System.Windows.Forms.PictureBox pbRes;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.OpenFileDialog dOpen;
        private System.Windows.Forms.Label label1;
    }
}


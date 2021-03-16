namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.KSLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ASLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.YSLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ODLabel = new System.Windows.Forms.Label();
            this.hesaplaButton = new System.Windows.Forms.Button();
            this.ortLabel = new System.Windows.Forms.Label();
            this.harfnotLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KSLabel
            // 
            this.KSLabel.AutoSize = true;
            this.KSLabel.BackColor = System.Drawing.Color.DarkKhaki;
            this.KSLabel.Font = new System.Drawing.Font("Rosewood Std Regular", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KSLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.KSLabel.Location = new System.Drawing.Point(12, 25);
            this.KSLabel.Name = "KSLabel";
            this.KSLabel.Size = new System.Drawing.Size(160, 35);
            this.KSLabel.TabIndex = 0;
            this.KSLabel.Text = "Kısa Sınav";
            this.KSLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(191, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 45);
            this.textBox1.TabIndex = 1;
            // 
            // ASLabel
            // 
            this.ASLabel.AutoSize = true;
            this.ASLabel.BackColor = System.Drawing.Color.DarkKhaki;
            this.ASLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.ASLabel.Font = new System.Drawing.Font("Rosewood Std Regular", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ASLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ASLabel.Location = new System.Drawing.Point(12, 87);
            this.ASLabel.Name = "ASLabel";
            this.ASLabel.Size = new System.Drawing.Size(153, 35);
            this.ASLabel.TabIndex = 2;
            this.ASLabel.Text = "Ara Sınav";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(191, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 45);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(191, 212);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 45);
            this.textBox3.TabIndex = 7;
            // 
            // YSLabel
            // 
            this.YSLabel.BackColor = System.Drawing.Color.DarkKhaki;
            this.YSLabel.Font = new System.Drawing.Font("Rosewood Std Regular", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YSLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.YSLabel.Location = new System.Drawing.Point(13, 198);
            this.YSLabel.Name = "YSLabel";
            this.YSLabel.Size = new System.Drawing.Size(159, 74);
            this.YSLabel.TabIndex = 6;
            this.YSLabel.Text = "Yıl Sonu Sınavı";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(191, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(128, 45);
            this.textBox4.TabIndex = 5;
            // 
            // ODLabel
            // 
            this.ODLabel.AutoSize = true;
            this.ODLabel.BackColor = System.Drawing.Color.DarkKhaki;
            this.ODLabel.Font = new System.Drawing.Font("Rosewood Std Regular", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ODLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ODLabel.Location = new System.Drawing.Point(12, 145);
            this.ODLabel.Name = "ODLabel";
            this.ODLabel.Size = new System.Drawing.Size(82, 35);
            this.ODLabel.TabIndex = 4;
            this.ODLabel.Text = "Ödev";
            // 
            // hesaplaButton
            // 
            this.hesaplaButton.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hesaplaButton.Location = new System.Drawing.Point(458, 66);
            this.hesaplaButton.Name = "hesaplaButton";
            this.hesaplaButton.Size = new System.Drawing.Size(207, 64);
            this.hesaplaButton.TabIndex = 8;
            this.hesaplaButton.Text = "Hesapla";
            this.hesaplaButton.UseVisualStyleBackColor = true;
            this.hesaplaButton.Click += new System.EventHandler(this.hesaplaButton_Click);
            // 
            // ortLabel
            // 
            this.ortLabel.BackColor = System.Drawing.Color.Coral;
            this.ortLabel.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ortLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ortLabel.Location = new System.Drawing.Point(461, 146);
            this.ortLabel.Name = "ortLabel";
            this.ortLabel.Size = new System.Drawing.Size(204, 43);
            this.ortLabel.TabIndex = 9;
            this.ortLabel.Text = "label1";
            // 
            // harfnotLabel
            // 
            this.harfnotLabel.BackColor = System.Drawing.Color.Coral;
            this.harfnotLabel.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harfnotLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.harfnotLabel.Location = new System.Drawing.Point(461, 211);
            this.harfnotLabel.Name = "harfnotLabel";
            this.harfnotLabel.Size = new System.Drawing.Size(204, 46);
            this.harfnotLabel.TabIndex = 10;
            this.harfnotLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.harfnotLabel);
            this.Controls.Add(this.ortLabel);
            this.Controls.Add(this.hesaplaButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.YSLabel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.ODLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ASLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.KSLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KSLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ASLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label YSLabel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label ODLabel;
        private System.Windows.Forms.Button hesaplaButton;
        private System.Windows.Forms.Label ortLabel;
        private System.Windows.Forms.Label harfnotLabel;
    }
}


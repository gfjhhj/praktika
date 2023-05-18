namespace _17._02WF
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
            this.buttonWF = new System.Windows.Forms.Button();
            this.labelWF1 = new System.Windows.Forms.Label();
            this.pictureKrevetka = new System.Windows.Forms.PictureBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKrevetka)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonWF
            // 
            this.buttonWF.BackColor = System.Drawing.Color.IndianRed;
            this.buttonWF.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonWF.Location = new System.Drawing.Point(12, 102);
            this.buttonWF.Name = "buttonWF";
            this.buttonWF.Size = new System.Drawing.Size(268, 68);
            this.buttonWF.TabIndex = 0;
            this.buttonWF.Text = "Нажми чтобы посчитать";
            this.buttonWF.UseVisualStyleBackColor = false;
            this.buttonWF.Click += new System.EventHandler(this.buttonWF_Click);
            // 
            // labelWF1
            // 
            this.labelWF1.AutoSize = true;
            this.labelWF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWF1.Location = new System.Drawing.Point(84, 173);
            this.labelWF1.Name = "labelWF1";
            this.labelWF1.Size = new System.Drawing.Size(138, 18);
            this.labelWF1.TabIndex = 1;
            this.labelWF1.Text = "Здесь будет ответ";
            // 
            // pictureKrevetka
            // 
            this.pictureKrevetka.ImageLocation = "D:\\207 Забелина Хохлов\\Woda-6_ubt.jpeg";
            this.pictureKrevetka.InitialImage = null;
            this.pictureKrevetka.Location = new System.Drawing.Point(286, 6);
            this.pictureKrevetka.Name = "pictureKrevetka";
            this.pictureKrevetka.Size = new System.Drawing.Size(761, 519);
            this.pictureKrevetka.TabIndex = 2;
            this.pictureKrevetka.TabStop = false;
            this.pictureKrevetka.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(180, 6);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 3;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(180, 40);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 4;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(180, 76);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 20);
            this.textBoxC.TabIndex = 5;
            this.textBoxC.TextChanged += new System.EventHandler(this.textBoxC_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите первый коэффициент:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите второй коэффициент:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите третий коэффициент:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1388, 737);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.pictureKrevetka);
            this.Controls.Add(this.labelWF1);
            this.Controls.Add(this.buttonWF);
            this.Name = "Form1";
            this.Text = "17.02WF";
            ((System.ComponentModel.ISupportInitialize)(this.pictureKrevetka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWF;
        private System.Windows.Forms.Label labelWF1;
        private System.Windows.Forms.PictureBox pictureKrevetka;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


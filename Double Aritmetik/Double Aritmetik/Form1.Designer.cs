namespace Double_Aritmetik
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sayı1 = new Label();
            sayı2 = new Label();
            lbltoplam = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lbltoplamı = new Label();
            btn_hesapla = new Button();
            lblcarpımı = new Label();
            lblfark = new Label();
            lblfarkı = new Label();
            lblcarpım = new Label();
            lblbölümü = new Label();
            lblbölüm = new Label();
            SuspendLayout();
            // 
            // sayı1
            // 
            sayı1.AutoSize = true;
            sayı1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            sayı1.Location = new Point(268, 49);
            sayı1.Name = "sayı1";
            sayı1.Size = new Size(74, 28);
            sayı1.TabIndex = 0;
            sayı1.Text = "Sayı 1:";
            // 
            // sayı2
            // 
            sayı2.AutoSize = true;
            sayı2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            sayı2.Location = new Point(268, 110);
            sayı2.Name = "sayı2";
            sayı2.Size = new Size(74, 28);
            sayı2.TabIndex = 1;
            sayı2.Text = "Sayı 2:";
            // 
            // lbltoplam
            // 
            lbltoplam.AutoSize = true;
            lbltoplam.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbltoplam.Location = new Point(345, 203);
            lbltoplam.Name = "lbltoplam";
            lbltoplam.Size = new Size(86, 28);
            lbltoplam.TabIndex = 2;
            lbltoplam.Text = "Toplam:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(343, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(343, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // lbltoplamı
            // 
            lbltoplamı.AutoSize = true;
            lbltoplamı.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbltoplamı.Location = new Point(429, 203);
            lbltoplamı.Name = "lbltoplamı";
            lbltoplamı.Size = new Size(24, 28);
            lbltoplamı.TabIndex = 5;
            lbltoplamı.Text = "0";
            // 
            // btn_hesapla
            // 
            btn_hesapla.Location = new Point(343, 147);
            btn_hesapla.Name = "btn_hesapla";
            btn_hesapla.Size = new Size(116, 29);
            btn_hesapla.TabIndex = 6;
            btn_hesapla.Text = "Hesapla";
            btn_hesapla.UseVisualStyleBackColor = true;
            btn_hesapla.Click += button1_Click;
            // 
            // lblcarpımı
            // 
            lblcarpımı.AutoSize = true;
            lblcarpımı.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblcarpımı.Location = new Point(429, 284);
            lblcarpımı.Name = "lblcarpımı";
            lblcarpımı.Size = new Size(24, 28);
            lblcarpımı.TabIndex = 8;
            lblcarpımı.Text = "0";
            // 
            // lblfark
            // 
            lblfark.AutoSize = true;
            lblfark.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblfark.Location = new Point(345, 245);
            lblfark.Name = "lblfark";
            lblfark.Size = new Size(57, 28);
            lblfark.TabIndex = 7;
            lblfark.Text = "Fark:";
            // 
            // lblfarkı
            // 
            lblfarkı.AutoSize = true;
            lblfarkı.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblfarkı.Location = new Point(429, 245);
            lblfarkı.Name = "lblfarkı";
            lblfarkı.Size = new Size(24, 28);
            lblfarkı.TabIndex = 10;
            lblfarkı.Text = "0";
            // 
            // lblcarpım
            // 
            lblcarpım.AutoSize = true;
            lblcarpım.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblcarpım.Location = new Point(343, 284);
            lblcarpım.Name = "lblcarpım";
            lblcarpım.Size = new Size(84, 28);
            lblcarpım.TabIndex = 9;
            lblcarpım.Text = "Çarpım:";
            // 
            // lblbölümü
            // 
            lblbölümü.AutoSize = true;
            lblbölümü.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblbölümü.Location = new Point(429, 324);
            lblbölümü.Name = "lblbölümü";
            lblbölümü.Size = new Size(24, 28);
            lblbölümü.TabIndex = 12;
            lblbölümü.Text = "0";
            // 
            // lblbölüm
            // 
            lblbölüm.AutoSize = true;
            lblbölüm.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblbölüm.Location = new Point(345, 324);
            lblbölüm.Name = "lblbölüm";
            lblbölüm.Size = new Size(78, 28);
            lblbölüm.TabIndex = 11;
            lblbölüm.Text = "Bölüm:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(lblbölümü);
            Controls.Add(lblbölüm);
            Controls.Add(lblfarkı);
            Controls.Add(lblcarpım);
            Controls.Add(lblcarpımı);
            Controls.Add(lblfark);
            Controls.Add(btn_hesapla);
            Controls.Add(lbltoplamı);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbltoplam);
            Controls.Add(sayı2);
            Controls.Add(sayı1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sayı1;
        private Label sayı2;
        private Label lbltoplam;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lbltoplamı;
        private Button btn_hesapla;
        private Label lblcarpımı;
        private Label lblfark;
        private Label lblfarkı;
        private Label lblcarpım;
        private Label lblbölümü;
        private Label lblbölüm;
    }
}

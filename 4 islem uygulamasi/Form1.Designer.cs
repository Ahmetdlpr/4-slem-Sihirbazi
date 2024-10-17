namespace _4_islem_uygulamasi
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
            birincisayi = new TextBox();
            ikincisayi = new TextBox();
            Toplama = new Button();
            label1 = new Label();
            Cikarma = new Button();
            Carpma = new Button();
            Bolme = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Sonuc = new Label();
            SuspendLayout();
            // 
            // birincisayi
            // 
            birincisayi.Location = new Point(131, 137);
            birincisayi.Multiline = true;
            birincisayi.Name = "birincisayi";
            birincisayi.Size = new Size(279, 33);
            birincisayi.TabIndex = 0;
            // 
            // ikincisayi
            // 
            ikincisayi.Location = new Point(131, 261);
            ikincisayi.Multiline = true;
            ikincisayi.Name = "ikincisayi";
            ikincisayi.Size = new Size(279, 31);
            ikincisayi.TabIndex = 1;
            // 
            // Toplama
            // 
            Toplama.Font = new Font("Segoe UI", 20F);
            Toplama.Location = new Point(472, 123);
            Toplama.Name = "Toplama";
            Toplama.Size = new Size(60, 56);
            Toplama.TabIndex = 2;
            Toplama.Text = "+";
            Toplama.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(310, 24);
            label1.Name = "label1";
            label1.Size = new Size(166, 30);
            label1.TabIndex = 6;
            label1.Text = "4 İşlem sihirbazı";
            label1.Click += label1_Click;
            // 
            // Cikarma
            // 
            Cikarma.Font = new Font("Segoe UI", 20F);
            Cikarma.Location = new Point(581, 123);
            Cikarma.Name = "Cikarma";
            Cikarma.Size = new Size(60, 56);
            Cikarma.TabIndex = 7;
            Cikarma.Text = "-";
            Cikarma.UseVisualStyleBackColor = true;
            // 
            // Carpma
            // 
            Carpma.Font = new Font("Segoe UI", 20F);
            Carpma.Location = new Point(472, 252);
            Carpma.Name = "Carpma";
            Carpma.Size = new Size(60, 56);
            Carpma.TabIndex = 8;
            Carpma.Text = "x";
            Carpma.UseVisualStyleBackColor = true;
            // 
            // Bolme
            // 
            Bolme.Font = new Font("Segoe UI", 20F);
            Bolme.Location = new Point(581, 252);
            Bolme.Name = "Bolme";
            Bolme.Size = new Size(60, 56);
            Bolme.TabIndex = 9;
            Bolme.Text = "/";
            Bolme.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(175, 104);
            label2.Name = "label2";
            label2.Size = new Size(193, 30);
            label2.TabIndex = 10;
            label2.Text = "Birinci sayıyı giriniz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(184, 228);
            label3.Name = "label3";
            label3.Size = new Size(184, 30);
            label3.TabIndex = 11;
            label3.Text = "İkinci sayıyı giriniz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(310, 388);
            label4.Name = "label4";
            label4.Size = new Size(72, 30);
            label4.TabIndex = 12;
            label4.Text = "Sonuc";
            // 
            // Sonuc
            // 
            Sonuc.AutoSize = true;
            Sonuc.Font = new Font("Segoe UI", 13F);
            Sonuc.ForeColor = Color.ForestGreen;
            Sonuc.Location = new Point(404, 388);
            Sonuc.Name = "Sonuc";
            Sonuc.Size = new Size(72, 30);
            Sonuc.TabIndex = 13;
            Sonuc.Text = "Sonuc";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Sonuc);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Bolme);
            Controls.Add(Carpma);
            Controls.Add(Cikarma);
            Controls.Add(label1);
            Controls.Add(Toplama);
            Controls.Add(ikincisayi);
            Controls.Add(birincisayi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox birincisayi;
        private TextBox ikincisayi;
        private Button Toplama;
        private Label label1;
        private Button Cikarma;
        private Button Carpma;
        private Button Bolme;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Sonuc;
    }
}

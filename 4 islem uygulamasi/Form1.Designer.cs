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
            label4 = new Label();
            Sonuc = new Label();
            label1 = new Label();
            birincisayi = new TextBox();
            ikincisayi = new TextBox();
            Toplama = new Button();
            Cikarma = new Button();
            Carpma = new Button();
            Bolme = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(185, 16);
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
            Sonuc.Location = new Point(253, 16);
            Sonuc.Name = "Sonuc";
            Sonuc.Size = new Size(72, 30);
            Sonuc.TabIndex = 13;
            Sonuc.Text = "Sonuc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(305, 20);
            label1.Name = "label1";
            label1.Size = new Size(166, 30);
            label1.TabIndex = 15;
            label1.Text = "4 İşlem sihirbazı";
            // 
            // birincisayi
            // 
            birincisayi.Location = new Point(88, 78);
            birincisayi.Multiline = true;
            birincisayi.Name = "birincisayi";
            birincisayi.Size = new Size(279, 33);
            birincisayi.TabIndex = 12;
            // 
            // ikincisayi
            // 
            ikincisayi.Location = new Point(88, 202);
            ikincisayi.Multiline = true;
            ikincisayi.Name = "ikincisayi";
            ikincisayi.Size = new Size(279, 31);
            ikincisayi.TabIndex = 13;
            // 
            // Toplama
            // 
            Toplama.Font = new Font("Segoe UI", 20F);
            Toplama.Location = new Point(429, 64);
            Toplama.Name = "Toplama";
            Toplama.Size = new Size(60, 56);
            Toplama.TabIndex = 14;
            Toplama.Text = "+";
            Toplama.UseVisualStyleBackColor = true;
            // 
            // Cikarma
            // 
            Cikarma.Font = new Font("Segoe UI", 20F);
            Cikarma.Location = new Point(538, 64);
            Cikarma.Name = "Cikarma";
            Cikarma.Size = new Size(60, 56);
            Cikarma.TabIndex = 16;
            Cikarma.Text = "-";
            Cikarma.UseVisualStyleBackColor = true;
            // 
            // Carpma
            // 
            Carpma.Font = new Font("Segoe UI", 20F);
            Carpma.Location = new Point(429, 193);
            Carpma.Name = "Carpma";
            Carpma.Size = new Size(60, 56);
            Carpma.TabIndex = 17;
            Carpma.Text = "x";
            Carpma.UseVisualStyleBackColor = true;
            // 
            // Bolme
            // 
            Bolme.Font = new Font("Segoe UI", 20F);
            Bolme.Location = new Point(538, 193);
            Bolme.Name = "Bolme";
            Bolme.Size = new Size(60, 56);
            Bolme.TabIndex = 18;
            Bolme.Text = "/";
            Bolme.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(132, 45);
            label2.Name = "label2";
            label2.Size = new Size(193, 30);
            label2.TabIndex = 19;
            label2.Text = "Birinci sayıyı giriniz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(141, 169);
            label3.Name = "label3";
            label3.Size = new Size(184, 30);
            label3.TabIndex = 20;
            label3.Text = "İkinci sayıyı giriniz";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Bolme);
            panel1.Controls.Add(Carpma);
            panel1.Controls.Add(Cikarma);
            panel1.Controls.Add(Toplama);
            panel1.Controls.Add(ikincisayi);
            panel1.Controls.Add(birincisayi);
            panel1.Location = new Point(58, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 286);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(Sonuc);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(146, 373);
            panel2.Name = "panel2";
            panel2.Size = new Size(531, 56);
            panel2.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "4 İslem sihirbazı";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label Sonuc;
        private Label label1;
        private TextBox birincisayi;
        private TextBox ikincisayi;
        private Button Toplama;
        private Button Cikarma;
        private Button Carpma;
        private Button Bolme;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
    }
}

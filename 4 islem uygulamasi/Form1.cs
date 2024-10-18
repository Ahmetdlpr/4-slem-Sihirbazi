using System.Runtime.InteropServices;

namespace _4_islem_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Toplama_Click(object sender, EventArgs e)
        {
            int sayi1;
            int sayi2;

            sayi1 = Convert.ToInt32(birincisayi.Text);
            sayi2 = Convert.ToInt32(ikincisayi.Text);

            int toplam = sayi1 + sayi2;

            Sonuc.Text = toplam.ToString();
        }

        private void Cikarma_Click(object sender, EventArgs e)
        {
            int sayi1;
            int sayi2;

            sayi1 = Convert.ToInt32(birincisayi.Text);
            sayi2 = Convert.ToInt32(ikincisayi.Text);

        



            if (sayi1 > sayi2)
            {
                int kalan = sayi1 - sayi2;
                Sonuc.Text = kalan.ToString();

            }
            else if (sayi2 > sayi1)
            {
                int buyuk = sayi2;

                int yazdirilansonuc = buyuk - sayi1;
                Sonuc.Text = yazdirilansonuc.ToString();
            }
        }

        private void Carpma_Click(object sender, EventArgs e)
        {
            float sayi1;
            float sayi2;

            sayi1 = Convert.ToInt32(birincisayi.Text);
            sayi2 = Convert.ToInt32(ikincisayi.Text);

            float carpim = sayi1 * sayi2;

            Sonuc.Text = carpim.ToString();
        }

        private void Bolme_Click(object sender, EventArgs e)
        {
            float sayi1;
            float sayi2;

            sayi1 = Convert.ToInt32(birincisayi.Text);
            sayi2 = Convert.ToInt32(ikincisayi.Text);
            float bolum = sayi1 / sayi2;

            Sonuc.Text = bolum.ToString();


            if (sayi1 > sayi2)
            {
                float kalan = sayi1 / sayi2;
                Sonuc.Text = kalan.ToString();

            }
            else if (sayi2 > sayi1)
            {
                float  buyuk = sayi2;

                float yazdirilansonuc = buyuk / sayi1;
                Sonuc.Text = yazdirilansonuc.ToString();
            }


            { 

            }
        }
    }
}

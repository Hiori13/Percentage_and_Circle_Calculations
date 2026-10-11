namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, yuzde;
            sayi = Convert.ToInt16(textBox1.Text);
            yuzde = (sayi * 18) / 100;
            MessageBox.Show(yuzde.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int yaricap;
            double pi = 3.14, cevre, alan; // cevre ve alan ondalıklı çıkabilir!
            yaricap = Convert.ToInt16(textBox2.Text);
            cevre = 2 * pi * yaricap; 
            alan = pi * Math.Pow(yaricap, 2); //Math.Pow() kodu üs almada kullanılır ilk sayı taban 2. sayı kuvvet
            MessageBox.Show("Girilen Yarıçapa Göre Dairenin Çevresi:" + cevre + "\nGirilen Yarıçapa Göre Dairenin Alanı:" + alan);
            //  \n komutu messagebox komutunda alt satıra geçip yazdırmadır. Üst satırda çevre alt satırda alan yazıcak

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

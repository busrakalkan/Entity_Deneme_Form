using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityDenemeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        entityDenemeEntities1 db = new entityDenemeEntities1();
        string sifrele(string metin)

        {
            string anahtar = "busra";
            string sifreli_metin = "";
            int j = 0;

            //Metni karakter karakter sonuna kadar tara.

            for (int k = 0; k <= metin.Length - 1; k++)
            {
                sifreli_metin = sifreli_metin + Convert.ToChar((Convert.ToInt32(metin[k]) + Convert.ToInt32(anahtar[j])) % 255);

                //Şifreli metni, her bir karakterinin koduna anahtar kelimenin sıradaki karakterinin kodunu ekleyerek bul.

                //Neden Mod 255? Çünkü toplam 255 değerini aşabilir.

                j = j + 1;

                if (j == anahtar.Length)

                    j = 0;

                //Anahtar kelimenin indisi ayrı tutulmalı. Yoksa indisde değer aşımı olur.

            }

            return sifreli_metin;

        }
        string sifreCoz(string sifreliMetin)

        {
            string anahtar = "busra";

            string metin = "";

            int kod = 0;


            int j = 0;

            for (int k = 0; k <= sifreliMetin.Length - 1; k++)

            {

                kod = Convert.ToInt32(sifreliMetin[k]) - Convert.ToInt32(anahtar[j]);

                if (kod <= 0)

                    kod = kod + 255;

                else

                    kod = kod % 255;

                metin = metin + Convert.ToChar(kod);

                j = j + 1;

                if (j == anahtar.Length)

                    j = 0;

            }

            return metin;

        }
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            var isim = textBoxKullanıcıAdı.Text;
            
            var sifre = textBoxKullanıcıSifresi.Text;

            var deneme=db.tbl_kullanıcı.Where(w => w.kullanıcıAd == isim).FirstOrDefault();
            //textBoxKullanıcıAdı.Text = sifreCoz(deneme.kullanıcıSifre);
            if (deneme != null)
            {
                if (deneme.kullanıcıSifre.ToString() == sifre)
                {
                    Form2 frm2 = new Form2();
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sifre yanlıs");
                }

            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı");
            }

        }

        private void buttonSifre_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
    }
}

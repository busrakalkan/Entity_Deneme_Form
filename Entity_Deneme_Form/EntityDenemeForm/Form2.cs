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
    public partial class Form2 : Form
    {
        entityDenemeEntities1 db = new entityDenemeEntities1();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = db.tbl_kullanıcı.ToList();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(textBox1.Text);
            var kl = db.tbl_kullanıcı.Where(w => w.kullanıcıID == id).FirstOrDefault();
            var Ad = sifrele(kl.kullanıcıAd);
            var soyAd = sifrele(kl.kullanıcıSoyad);
            var sifre = sifrele(kl.kullanıcıSifre);
            var mail = sifrele(kl.kullanıcıEmail);
            kl.kullanıcıAd = Ad;
            kl.kullanıcıSoyad = soyAd;
            kl.kullanıcıSifre = sifre;
            kl.kullanıcıEmail = mail;
            db.SaveChanges();

            //textBox2.Text = sifreCoz();
            //textBox3.Text = sifrele(sifreCoz(kl.kullanıcıSifre));

        }
    }
}

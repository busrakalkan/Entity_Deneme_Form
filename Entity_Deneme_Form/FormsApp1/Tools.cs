using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApp1
{
    class Tools
    {
        #region sifrele
        public static string sifrele(string metin)
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
        #endregion

        #region sifreCöz
        public static string sifreCoz(string sifreliMetin)
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
        #endregion

    }
}

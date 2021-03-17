using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp1
{
    public partial class PopUpForm : BseClss
    {
        public int id;


        public PopUpForm()
        {
            InitializeComponent();
        }
        public PopUpForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }
       

        private void PopUpForm_Load_1(object sender, EventArgs e)
        {
            this.Location = new Point(460, 250);

            var kontrol = db.tbl_Kullanıcı.Where(w => w.kullanıcıID == id).FirstOrDefault();

            if (kontrol != null)
            {
                textBox1.Text = kontrol.kullanıcıAd;
                textBox2.Text = kontrol.kullanıcıSoyad;
                textBox3.Text = Tools.sifreCoz(kontrol.kullanıcıSifre);
                textBox4.Text = kontrol.kullanıcıEmail;
            }
            else MessageBox.Show("kullanıcı kulunamadı");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kontrol = db.tbl_Kullanıcı.Where(w => w.kullanıcıID == id).FirstOrDefault();
            if (kontrol.kullanıcıAd != textBox1.Text)
            {
                kontrol.kullanıcıAd= textBox1.Text;
                kontrol.kullanıcıSoyad= textBox2.Text;
                kontrol.kullanıcıSifre= Tools.sifrele(textBox3.Text);
                kontrol.kullanıcıEmail= textBox4.Text;
                db.SaveChanges();
                
            }else MessageBox.Show("Bu isimde bir kullanıcı var başka bir kullanıcı adı giriniz");

        }
    }
}

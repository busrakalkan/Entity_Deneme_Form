using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityDenemeForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
     
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            entityDenemeEntities1 db = new entityDenemeEntities1();
            var isim = textBoxIsim.Text;
            var mail = textBoxEmail.Text;
            var deneme = db.tbl_kullanıcı.Where(w => w.kullanıcıAd == isim).FirstOrDefault();
            if (deneme != null)
            {
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;
           
                string icerik = deneme.kullanıcıSifre.ToString();

                sc.Credentials = new NetworkCredential("bk@gmail.com", "password");

                MailMessage email = new MailMessage();
                email.From = new MailAddress("bk@gmail.com");

                email.To.Add("busrakalkan38@hotmail.com");

                email.Subject = "Şifre Bilgilendirme";
                email.IsBodyHtml = true;
                email.Body = icerik;
                sc.Send(email);
                
            }MessageBox.Show("kullanıcı bulunamadı");
        }
    }
}

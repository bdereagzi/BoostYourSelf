using BoostYourselfSonInch.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoostYourselfSonInch.UI
{
    public partial class KullaniciForm : Form
    {
        AppDbContext db = new AppDbContext();
        int kullaniciId;
        public KullaniciForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            kullaniciId = db.Kullanicilar.FirstOrDefault(x => x.Mail == txtKullaniciMail.Text).KullaniciId;
            if (!string.IsNullOrEmpty(txtKullaniciMail.Text) || !string.IsNullOrEmpty(txtSifre.Text))
            {
                var kontrol = db.Kullanicilar.Where(x => x.Mail == txtKullaniciMail.Text && x.Sifre == txtSifre.Text).FirstOrDefault();
                if (kontrol != null)
                {
                    AnaForm anaForm = new AnaForm(kullaniciId, db);
                    this.Hide();
                    anaForm.ShowDialog();
                }
                else if (string.IsNullOrEmpty(txtKullaniciMail.Text))
                {
                    MessageBox.Show("Kullanıcı maili boş bırakılmaz!");
                }
                else if (string.IsNullOrEmpty(txtSifre.Text))
                {
                    MessageBox.Show("Şifre boş bırakılamaz!");
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılmaz!");
            }


        }

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitForm kayitForm = new KayitForm(db);
            kayitForm.ShowDialog();
        }
    }
}

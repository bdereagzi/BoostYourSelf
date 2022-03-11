using BoostYourselfSonInch.Data;
using BoostYourselfSonInch.Model;
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
    public partial class KayitForm : Form
    {
        private readonly AppDbContext db;

        public KayitForm(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {

            Kullanici kullanici = new Kullanici();
            List<string> mailListesi = new List<string>()
            {
                "@gmail.com",
                "@yahoo.com",
                "@outlook.com",
                "@hotmail.com",
                "@yandex.com",
                "@icloud.com"
            };
            string sifreKontrolu = txtSifreKontrolu.Text;
            var mailKontrolu = db.Kullanicilar.Where(x => x.Mail == txtMail.Text).FirstOrDefault();
            if (!string.IsNullOrEmpty(txtAd.Text) || !string.IsNullOrEmpty(txtSoyad.Text) || !string.IsNullOrEmpty(txtKullaniciAdi.Text) || !string.IsNullOrEmpty(txtMail.Text) || !string.IsNullOrEmpty(txtSifre.Text))
            {
                kullanici.Ad = txtAd.Text.Trim();
                kullanici.Soyad = txtSoyad.Text.Trim();
                kullanici.KullaniciAdi = txtKullaniciAdi.Text.Trim();
                foreach (var item in mailListesi)
                {
                    if (txtMail.Text.Contains(item))
                    {
                        kullanici.Mail = txtMail.Text.Trim();
                        break;
                    }
                    else if (mailListesi.Count > 6)
                    {
                        MessageBox.Show("Bu bir mail adresi değildir!");
                        return;
                    }
                }
                if (txtSifre.Text == sifreKontrolu && sifreRenkKontrol == true && mailKontrolu == null)
                {
                    kullanici.Sifre = txtSifre.Text.Trim();
                }
                else if (mailKontrolu != null)
                {
                    MessageBox.Show("Bu mail adresi kullanılıyor!");
                    return;
                }
                else if (txtSifre.Text == sifreKontrolu && sifreRenkKontrol == false)
                {
                    MessageBox.Show("Şifreniz güçlü değildir. Lütfen en az 6 karakter ve 1 tane büyük harf,küçük harf,sayı ve özel karakter giriniz!");
                    return;
                }
                else
                {
                    MessageBox.Show("Şifreler eşleşmiyor!");
                    return;
                }
                kullanici.DogumTarihi = dtpDogumTarihi.Value;
                kullanici.Boy = (int)nudBoy.Value;
                kullanici.Kilo = (int)nudKilo.Value;
            }
            else
            {
                MessageBox.Show("Bu alanlar boş geçilemez");
            }
            db.Kullanicilar.Add(kullanici);
            db.SaveChanges();
            MessageBox.Show("Kayıt başarılı");
            this.Close();
            if (txtSifre.Text == "")
            {
                sifreTekrarkontrol = true;
            }
        }

        private void txtSifreKontrolu_TextChanged(object sender, EventArgs e)
        {
            if (sifreTekrarkontrol == true || txtSifreKontrolu.Text == "")
            {
                txtSifreKontrolu.BackColor = Color.Red;
            }
            else if (sifreTekrarKontrol == txtSifreKontrolu.Text)
            {
                txtSifreKontrolu.BackColor = Color.Green;
            }

        }

        private void KayitForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.DataSource = Enum.GetNames(typeof(Cinsiyet)).ToList();
            txtSifre.PasswordChar = '*';
        }
        bool sifreRenkKontrol = false;
        bool sifreTekrarkontrol = false;
        string sifreTekrarKontrol = "";
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            string sifreBuyukHarf = "ABCDEFGHIJKLMNOPRSTUVWXYZ";
            string sifreSayi = "0123456789";
            string sifreKucukHarf = "abcdefghıijklmnoprstuvwxyz";
            string sifreOzelKarakter = "!'£^#+$%&/*?\\-_|@~¨´,;.:`";
            bool a = false;
            bool l = false;
            bool p = false;
            bool r = false;
            if (sifreRenkKontrol == false)
            {
                txtSifre.BackColor = Color.Red;
                foreach (char item in txtSifre.Text.Distinct())
                {
                    if (sifreBuyukHarf.Contains(item))
                    {
                        txtSifre.BackColor = Color.AliceBlue;
                        a = true;
                    }
                    else if (sifreKucukHarf.Contains(item))
                    {
                        txtSifre.BackColor = Color.Beige;
                        l = true;
                    }
                    else if (sifreSayi.Contains(item))
                    {
                        txtSifre.BackColor = Color.Brown;
                        p = true;
                    }
                    else if (sifreOzelKarakter.Contains(item))
                    {
                        txtSifre.BackColor = Color.DarkOrange;
                        r = true;
                    }
                }
                if (txtSifre.Text.Length > 6 && a == true && l == true && p == true && r == true)
                {
                    sifreRenkKontrol = true;
                    txtSifre.BackColor = Color.Green;
                    sifreTekrarKontrol = txtSifre.Text;
                }
            }
            else if (txtSifre.Text.Length < 6 && a == false && l == false && p == false && r == false)
            {
                txtSifre.BackColor = Color.Red;
                sifreRenkKontrol = false;
            }
            if (sifreTekrarKontrol != txtSifre.Text)
            {
                txtSifreKontrolu.BackColor = Color.Red;
            }
            else if (sifreTekrarKontrol == txtSifre.Text && !string.IsNullOrEmpty(txtSifreKontrolu.Text))
            {
                txtSifreKontrolu.BackColor = Color.Green;
            }
        }

        private void txtSifreKontrolu_TextChanged_1(object sender, EventArgs e)
        {

            if (sifreTekrarkontrol == true || txtSifreKontrolu.Text == "")
            {
                txtSifreKontrolu.BackColor = Color.Red;
            }
            else if (sifreTekrarKontrol == txtSifreKontrolu.Text)
            {
                txtSifreKontrolu.BackColor = Color.Green;
            }
        }
    }
}

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
    public partial class Ayarlar : Form
    {
        private readonly int kullaniciId;
        private readonly AppDbContext db;
        Kullanici kullanici;
        public Ayarlar()
        {
            InitializeComponent();
        }
        public Ayarlar(int kullaniciId, AppDbContext db)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            this.db = db;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            kullanici.Ad = txtAd.Text;
            kullanici.Soyad = txtSoyad.Text;
            kullanici.KullaniciAdi = txtKullaniciAdi.Text;
            kullanici.Mail = txtMail.Text;
            kullanici.Sifre = txtSifre.Text;
            kullanici.DogumTarihi = dtpDogumTarihi.Value;
            kullanici.Boy = (int)nudBoy.Value;
            kullanici.Kilo = (int)nudKilo.Value;
            db.SaveChanges();
            MessageBox.Show("Guncelleme Yapıldı");
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            kullanici = db.Kullanicilar.Where(x => x.KullaniciId == kullaniciId).Select(x => x).FirstOrDefault();
            txtAd.Text = kullanici.Ad;
            txtSoyad.Text = kullanici.Soyad;
            txtKullaniciAdi.Text = kullanici.KullaniciAdi;
            txtMail.Text = kullanici.Mail;
            txtSifre.Text = kullanici.Sifre;
            dtpDogumTarihi.Value = kullanici.DogumTarihi;
            nudBoy.Value = kullanici.Boy;
            nudKilo.Value = kullanici.Kilo;
            //cmbCinsiyet.DataSource = kullanici.Cinsiyet;
        }
    }
}

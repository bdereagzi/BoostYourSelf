using BoostYourselfSonInch.Data;
using BoostYourselfSonInch.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoostYourselfSonInch.UI
{
    public partial class IstatistikForm : Form
    {
        private readonly int kullaniciId;
        private readonly AppDbContext db;
        Kullanici kullanici;
        Ogun kahvalti, ogle, araOgun, aksam;
        decimal kavaltiKalori = 0, ogleKalori = 0, araogunKalori = 0, aksamKalori = 0, kahvaltiToplamKalori = 0, ogleToplamKalori = 0, araToplamKalori = 0, aksamToplamKalori = 0, kahvaltiKullancilarToplamKalori = 0, ogleKullanicilarToplamKalori = 0, araKullanicilarToplamKalori = 0, aksamKullanicilarToplamKalori = 0;
        int zaman = 0;
        string text, text2, text3, text4, text5, text6, text7, text8 = "";
        public IstatistikForm()
        {
            InitializeComponent();
        }
        public IstatistikForm(int kullaniciId, AppDbContext db)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            this.db = db;
            kullanici = db.Kullanicilar.Where(x => x.KullaniciId == kullaniciId).Select(x => x).FirstOrDefault();
        }

        private void cmbOgunler3_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Besin> besinler = new List<Besin>();
            List<Ogun> ogunler = new List<Ogun>();
            if (cmbOgunler3.SelectedIndex == 0)
            {
                ogunler = db.Ogunler.Where(x => x.Ogunler == Ogunler.Kahvalti).ToList();
            }
            else if (cmbOgunler3.SelectedIndex == 1)
            {
                ogunler = db.Ogunler.Where(x => x.Ogunler == Ogunler.Ogle).ToList();
            }
            else if (cmbOgunler3.SelectedIndex == 2)
            {
                ogunler = db.Ogunler.Where(x => x.Ogunler == Ogunler.AraOgun).ToList();
            }
            else if (cmbOgunler3.SelectedIndex == 3)
            {
                ogunler = db.Ogunler.Where(x => x.Ogunler == Ogunler.Aksam).ToList();
            }
            foreach (var ogun in ogunler)
            {
                foreach (var besin in ogun.Besinler)
                {
                    besinler.Add(besin);
                }
            }
            var liste = besinler.GroupBy(x => x.YiyecekAdi).Select(y => new
            {
                BesinAdi = y.Key,
                Miktar = y.Sum(z => z.Miktar),
                Porsiyon = y.Select(z => z.Porsiyonlar).FirstOrDefault()
            }).OrderByDescending(a => a.Miktar).ToList();

            dgvOgunlerinYemekleri.DataSource = liste;
        }
        private void IstatistikForm_Load(object sender, EventArgs e)
        {
            cmbOgunler.DataSource = Enum.GetNames(typeof(Ogunler));
            cmbOgunler2.DataSource = Enum.GetNames(typeof(Ogunler));
            cmbOgunler3.DataSource = Enum.GetNames(typeof(Ogunler));
            cmbRaporKategoriler.DataSource = db.Kategoriler.Select(x => x.KategoriAdi).ToList();
            GunlukRapor();
        }
        private void cmbOgunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOgunler.SelectedIndex == 0)
            {
                nudOgunlerinKalorisi.Value = kavaltiKalori;
            }
            else if (cmbOgunler.SelectedIndex == 1)
            {
                nudOgunlerinKalorisi.Value = ogleKalori;
            }
            else if (cmbOgunler.SelectedIndex == 2)
            {
                nudOgunlerinKalorisi.Value = araogunKalori;
            }
            else if (cmbOgunler.SelectedIndex == 3)
            {
                nudOgunlerinKalorisi.Value = aksamKalori;
            }
        }

        private void GunlukRapor()
        {
            kahvalti = kullanici.Ogunler.FirstOrDefault(x => x.Ogunler == Ogunler.Kahvalti && x.OlusturulmaZamani.Date == DateTime.Now.Date);
            if (kahvalti != null)
            {
                kavaltiKalori = kahvalti.Besinler.Sum(x => x.Kalori * x.Miktar);
            }
            ogle = kullanici.Ogunler.FirstOrDefault(x => x.Ogunler == Ogunler.Ogle && x.OlusturulmaZamani.Date == DateTime.Now.Date);
            if (ogle != null)
            {
                ogleKalori = ogle.Besinler.Sum(x => x.Kalori * x.Miktar);
            }
            araOgun = kullanici.Ogunler.FirstOrDefault(x => x.Ogunler == Ogunler.AraOgun && x.OlusturulmaZamani.Date == DateTime.Now.Date);
            if (araOgun != null)
            {
                araogunKalori = araOgun.Besinler.Sum(x => x.Kalori * x.Miktar);
            }
            aksam = kullanici.Ogunler.FirstOrDefault(x => x.Ogunler == Ogunler.Aksam && x.OlusturulmaZamani.Date == DateTime.Now.Date);
            if (aksam != null)
            {
                aksamKalori = aksam.Besinler.Sum(x => x.Kalori * x.Miktar);
            }
            nudToplamKalori.Value = kavaltiKalori + ogleKalori + araogunKalori + aksamKalori;
        }
        private void rbAylik_CheckedChanged(object sender, EventArgs e)
        {
            zaman = -30;
            KullaniciOgunKaloriHesapla(zaman);
            KullanicilarOgunKaloriHesapla(zaman);
            KullaniciKategoriKaloriHesapla(zaman);
            KullanicilarKategoriKaloriHesapla(zaman);
        }

        private void rbHaftalik_CheckedChanged(object sender, EventArgs e)
        {
            zaman = -7;
            KullaniciOgunKaloriHesapla(zaman);
            KullanicilarOgunKaloriHesapla(zaman);
            KullaniciKategoriKaloriHesapla(zaman);
            KullanicilarKategoriKaloriHesapla(zaman);
        }
        private void KullaniciOgunKaloriHesapla(int zaman)
        {
            DateTime zamanDilimi = DateTime.Now.AddDays(zaman);
            var kahvaltiKullaniciOgunleri = kullanici.Ogunler.Where(x => x.Ogunler == Ogunler.Kahvalti && x.OlusturulmaZamani.Date > zamanDilimi.Date).ToList();
            kahvaltiToplamKalori = kahvaltiKullaniciOgunleri.Average(x => x.ToplamKalori);
            var kahvaltiKullaniciBesin = kahvaltiKullaniciOgunleri.Select(x => x.Besinler).ToList();
            ArrayList kahvaltiBesinler = new ArrayList();
            foreach (var item in kahvaltiKullaniciBesin)
            {
                kahvaltiBesinler.Add(item.GroupBy(x => x.YiyecekAdi).Select(y => new
                {
                    YiyececekAdi = y.Key,
                    Miktar = y.Sum(z => z.Miktar)
                }).OrderByDescending(a => a.Miktar).First());
            }
            foreach (var item in kahvaltiBesinler)
            {
                text = item.ToString();
            }

            var ogleKullaniciOgunleri = kullanici.Ogunler.Where(x => x.Ogunler == Ogunler.Ogle && x.OlusturulmaZamani.Date > zamanDilimi.Date).ToList();
            ogleToplamKalori = ogleKullaniciOgunleri.Average(x => x.ToplamKalori);
            var ogleKullaniciBesin = ogleKullaniciOgunleri.Select(x => x.Besinler).ToList();
            ArrayList ogleBesinler = new ArrayList();
            foreach (var item in ogleKullaniciBesin)
            {
                ogleBesinler.Add(item.GroupBy(x => x.YiyecekAdi).Select(y => new
                {
                    YiyececekAdi = y.Key,
                    Miktar = y.Sum(z => z.Miktar)
                }).OrderByDescending(a => a.Miktar).First());
            }
            foreach (var item in ogleBesinler)
            {
                text2 = item.ToString();
            }

            var araKullaniciOgunleri = kullanici.Ogunler.Where(x => x.Ogunler == Ogunler.AraOgun && x.OlusturulmaZamani.Date > zamanDilimi.Date).ToList();
            araToplamKalori = araKullaniciOgunleri.Average(x => x.ToplamKalori);
            var araKullaniciBesin = araKullaniciOgunleri.Select(x => x.Besinler).ToList();
            ArrayList araBesinler = new ArrayList();
            foreach (var item in araKullaniciBesin)
            {
                araBesinler.Add(item.GroupBy(x => x.YiyecekAdi).Select(y => new
                {
                    YiyececekAdi = y.Key,
                    Miktar = y.Sum(z => z.Miktar)
                }).OrderByDescending(a => a.Miktar).First());
            }
            foreach (var item in araBesinler)
            {
                text3 = item.ToString();
            }

            var aksamKullaniciOgunleri = kullanici.Ogunler.Where(x => x.Ogunler == Ogunler.Aksam && x.OlusturulmaZamani.Date > zamanDilimi.Date).ToList();
            aksamToplamKalori = aksamKullaniciOgunleri.Average(x => x.ToplamKalori);
            var aksamKullaniciBesin = aksamKullaniciOgunleri.Select(x => x.Besinler).ToList();
            ArrayList aksamBesinler = new ArrayList();
            foreach (var item in aksamKullaniciBesin)
            {
                aksamBesinler.Add(item.GroupBy(x => x.YiyecekAdi).Select(y => new
                {
                    YiyececekAdi = y.Key,
                    Miktar = y.Sum(z => z.Miktar)
                }).OrderByDescending(a => a.Miktar).First());
            }
            foreach (var item in aksamBesinler)
            {
                text4 = item.ToString();
            }

        }

        private void KullanicilarOgunKaloriHesapla(int zaman)
        {
            DateTime zamanDilimi = DateTime.Now.AddDays(zaman);
            var kahvaltiKullanicilarOgunleri = db.Ogunler.Where(x => x.Ogunler == Ogunler.Kahvalti && DbFunctions.TruncateTime(x.OlusturulmaZamani) > zamanDilimi.Date).ToList();
            kahvaltiKullancilarToplamKalori = kahvaltiKullanicilarOgunleri.Average(x => x.ToplamKalori);
            var kahvaltiKullanicilarBesin = kahvaltiKullanicilarOgunleri.Select(x => x.Besinler).ToList();
            ArrayList kahvaltiBesinler = new ArrayList();
            foreach (var item in kahvaltiKullanicilarBesin)
            {
                kahvaltiBesinler.Add(item.GroupBy(x => x.YiyecekAdi).Select(y => new
                {
                    YiyececekAdi = y.Key,
                    Miktar = y.Sum(z => z.Miktar)
                }).OrderByDescending(a => a.Miktar).First());
            }
            foreach (var item in kahvaltiBesinler)
            {
                text5 = item.ToString();
            }

            var ogleKullanicilarOgunleri = db.Ogunler.Where(x => x.Ogunler == Ogunler.Ogle && DbFunctions.TruncateTime(x.OlusturulmaZamani) > zamanDilimi.Date).ToList();
            ogleKullanicilarToplamKalori = ogleKullanicilarOgunleri.Average(x => x.ToplamKalori);
            var ogleKullanicilarBesin = ogleKullanicilarOgunleri.Select(x => x.Besinler).ToList();
            ArrayList ogleBesinler = new ArrayList();
            foreach (var item in ogleKullanicilarBesin)
            {
                ogleBesinler.Add(item.GroupBy(x => x.YiyecekAdi).Select(y => new
                {
                    YiyececekAdi = y.Key,
                    Miktar = y.Sum(z => z.Miktar)
                }).OrderByDescending(a => a.Miktar).First());
            }
            foreach (var item in ogleBesinler)
            {
                text6 = item.ToString();
            }

            var araKullanicilarOgunleri = db.Ogunler.Where(x => x.Ogunler == Ogunler.AraOgun && DbFunctions.TruncateTime(x.OlusturulmaZamani) > zamanDilimi.Date).ToList();
            araKullanicilarToplamKalori = araKullanicilarOgunleri.Average(x => x.ToplamKalori);
            var araKullanicilarBesin = araKullanicilarOgunleri.Select(x => x.Besinler).ToList();
            ArrayList araBesinler = new ArrayList();
            foreach (var item in araKullanicilarBesin)
            {
                araBesinler.Add(item.GroupBy(x => x.YiyecekAdi).Select(y => new
                {
                    YiyececekAdi = y.Key,
                    Miktar = y.Sum(z => z.Miktar)
                }).OrderByDescending(a => a.Miktar).First());
            }
            foreach (var item in araBesinler)
            {
                text7 = item.ToString();
            }


            var aksamKullanicilarOgunleri = db.Ogunler.Where(x => x.Ogunler == Ogunler.Aksam && DbFunctions.TruncateTime(x.OlusturulmaZamani) > zamanDilimi.Date).ToList();
            aksamKullanicilarToplamKalori = aksamKullanicilarOgunleri.Average(x => x.ToplamKalori);
            var aksamKullanicilarBesin = aksamKullanicilarOgunleri.Select(x => x.Besinler).ToList();
            ArrayList aksamBesinler = new ArrayList();
            foreach (var item in aksamKullanicilarBesin)
            {
                aksamBesinler.Add(item.GroupBy(x => x.YiyecekAdi).Select(y => new
                {
                    YiyececekAdi = y.Key,
                    Miktar = y.Sum(z => z.Miktar)
                }).OrderByDescending(a => a.Miktar).First());
            }
            foreach (var item in aksamBesinler)
            {
                text8 = item.ToString();
            }
        }
        private void cmbOgunler2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblKullaniciTopYemek.Text = "";
            if (cmbOgunler2.SelectedIndex == 0)
            {
                lblKullaniciOrtKcal.Text = $"{Decimal.Round(kahvaltiToplamKalori, 2)} kcal";
                lblTumKisilerOrtKcal.Text = $"{Decimal.Round(kahvaltiKullancilarToplamKalori, 2)} kcal";
                lblKullaniciTopYemek.Text = text;
                lblKullanicilarTopYemek.Text = text5;
            }
            else if (cmbOgunler2.SelectedIndex == 1)
            {
                lblKullaniciOrtKcal.Text = $"{Decimal.Round(ogleToplamKalori, 2)} kcal";
                lblTumKisilerOrtKcal.Text = $"{Decimal.Round(ogleKullanicilarToplamKalori, 2)} kcal";
                lblKullaniciTopYemek.Text = text2;
                lblKullanicilarTopYemek.Text = text6;
            }
            else if (cmbOgunler2.SelectedIndex == 2)
            {
                lblKullaniciOrtKcal.Text = $"{Decimal.Round(araToplamKalori, 2)} kcal";
                lblTumKisilerOrtKcal.Text = $"{Decimal.Round(araKullanicilarToplamKalori, 2)} kcal";
                lblKullaniciTopYemek.Text = text3;
                lblKullanicilarTopYemek.Text = text7;
            }
            else if (cmbOgunler2.SelectedIndex == 3)
            {
                lblKullaniciOrtKcal.Text = $"{Decimal.Round(aksamToplamKalori, 2)} kcal";
                lblTumKisilerOrtKcal.Text = $"{Decimal.Round(aksamKullanicilarToplamKalori, 2)} kcal";
                lblKullaniciTopYemek.Text = text4;
                lblKullanicilarTopYemek.Text = text8;
            }
        }

        private void KullaniciKategoriKaloriHesapla(int zaman)
        {
            DateTime zamanDilimi = DateTime.Now.AddDays(zaman);
            var kullaniciOgun = kullanici.Ogunler.Where(x => x.OlusturulmaZamani.Date > zamanDilimi.Date).SelectMany(x => x.Besinler).Where(x => x.KategoriId == cmbRaporKategoriler.SelectedIndex + 1).ToList();
            decimal toplamKalori = 0;
            decimal ortalamaKalori = 0;
            foreach (var item in kullaniciOgun)
            {
                toplamKalori += item.Kalori * item.Miktar;
                ortalamaKalori = toplamKalori / kullaniciOgun.Count;
            }
            lblKullaniciOrtKcal.Text = $"{Decimal.Round(ortalamaKalori, 2)} kcal";
        }
        private void KullanicilarKategoriKaloriHesapla(int zaman)
        {
            DateTime zamanDilimi = DateTime.Now.AddDays(zaman);
            var kullanicilarOgun = db.Ogunler.Where(x => DbFunctions.TruncateTime(x.OlusturulmaZamani) > zamanDilimi.Date).SelectMany(x => x.Besinler).Where(x => x.KategoriId == cmbRaporKategoriler.SelectedIndex + 1).ToList();
            decimal toplamKalori = 0;
            decimal ortalamaKalori = 0;
            foreach (var item in kullanicilarOgun)
            {
                toplamKalori += item.Kalori * item.Miktar;
                ortalamaKalori = toplamKalori / kullanicilarOgun.Count;
            }
            lblTumKisilerOrtKcal.Text = $"{Decimal.Round(ortalamaKalori, 2)} kcal";
        }
        private void cmbRaporKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblKullaniciTopYemek.Text = lblKullanicilarTopYemek.Text = "";
            KullaniciKategoriKaloriHesapla(zaman);
            KullanicilarKategoriKaloriHesapla(zaman);
        }



    }
}

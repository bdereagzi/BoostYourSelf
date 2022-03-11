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
    public partial class AnaForm : Form
    {
        private readonly int kullaniciId;
        private readonly AppDbContext db;
        Kullanici kullanici;
        decimal toplamKcal = 0;
        DateTime date;
        Ogun kullaniciOgun;
        public AnaForm()
        {
            InitializeComponent();
        }
        public AnaForm(int kullaniciId, AppDbContext db)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            this.db = db;
            kullanici = db.Kullanicilar.Where(x => x.KullaniciId == kullaniciId).Select(x => x).FirstOrDefault();
            date = dtp.Value;
        }
        void KategoriGetir()
        {
            cmbKategoriler.DataSource = db.Kategoriler.ToList();
            cmbKategoriler.DisplayMember = ("KategoriAdi");
            cmbKategoriler.ValueMember = ("KategoriId");
        }

        void OgunGetir()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in kullanici.Ogunler.ToList())
            {
                dataGridView1.Rows.Add(item.OgunId, item.OgunAdi, item.OlusturulmaZamani, item.Ogunler, item.ToplamKalori, item.KullaniciId);

            }

            this.dataGridView1.Sort(this.dataGridView1.Columns["OlusturulmaZamani"], ListSortDirection.Descending);
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            KategoriGetir();
            cmbOgun.DataSource = Enum.GetNames(typeof(Ogunler));
            OgunGetir();
        }

        private void btnYeniBesinEkle_Click(object sender, EventArgs e)
        {
            BesinEkleForm besinEkle = new BesinEkleForm(db);
            besinEkle.ShowDialog();
        }


        private void pbAyarlar_Click(object sender, EventArgs e)
        {
            Ayarlar ayar = new Ayarlar(kullaniciId, db);
            ayar.ShowDialog();
        }

        private void pbIstatistik_Click(object sender, EventArgs e)
        {
            IstatistikForm istatistikForm = new IstatistikForm(kullaniciId,db);
            istatistikForm.ShowDialog();
        }

        private void pbCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combobox ın kategori seçiminden sonra sağdaki besinler datagridi doldurulacak
            var liste = db.Besinler.Where(a => a.KategoriId == (cmbKategoriler.SelectedIndex + 1)).ToList();
            //dgvBesinler.DataSource = liste;
            dgvBesinler.Rows.Clear();
            foreach (var item in liste)
            {
                dgvBesinler.Rows.Add(item.BesinId, item.YiyecekAdi, item.Miktar, item.Porsiyonlar, item.Kalori, item.KategoriId);
            }
        }
        private void btnOgunEkle_Click_1(object sender, EventArgs e)
        {
            List<Besin> besinler = new List<Besin>();
            List<Ogun> ogunler = new List<Ogun>();

            int besinId = 0;
            decimal toplamKcal = 0;
            besinId = (int)dgvBesinler.SelectedRows[0].Cells[0].Value;
            Besin k = db.Besinler.Where(t => t.BesinId == besinId).FirstOrDefault();
            toplamKcal += k.Kalori * nudMiktar.Value;
            lblKalori.Text = $"{k.Kalori * nudMiktar.Value} kcal";
            if (cmbOgun.SelectedIndex == 0)
            {
                ogunler = kullanici.Ogunler.Where(x => x.Ogunler == Model.Ogunler.Kahvalti && x.OlusturulmaZamani.Date == date.Date).ToList();
                if (ogunler.Count < 1)
                {
                    ogunler = new List<Ogun>();
                    Ogun kahvalti = new Ogun()
                    {
                        Kullanici = kullanici,
                        OgunAdi = cmbOgun.SelectedItem as string,
                        Ogunler = Model.Ogunler.Kahvalti,
                        KullaniciId = kullaniciId,
                        OlusturulmaZamani = date,
                        ToplamKalori = toplamKcal
                    };
                    ogunler.Add(kahvalti);
                }
                else
                {
                    kullaniciOgun = kullanici.Ogunler.FirstOrDefault(x => x.Ogunler == Model.Ogunler.Kahvalti && x.OlusturulmaZamani.Date == date.Date);
                    kullaniciOgun.ToplamKalori = toplamKcal;
                    kullaniciOgun.OlusturulmaZamani = date;
                    kullaniciOgun.Besinler.Add(k);
                    db.Ogunler.Add(kullaniciOgun);
                }
            }
            else if (cmbOgun.SelectedIndex == 1)
            {
                ogunler = kullanici.Ogunler.Where(x => x.Ogunler == Model.Ogunler.Ogle && x.OlusturulmaZamani.Date == date.Date).ToList();
                if (ogunler.Count < 1)
                {
                    ogunler = new List<Ogun>();
                    Ogun ogle = new Ogun()
                    {
                        Kullanici = kullanici,
                        OgunAdi = cmbOgun.SelectedItem as string,
                        Ogunler = Model.Ogunler.Ogle,
                        KullaniciId = kullaniciId,
                        OlusturulmaZamani = date,
                        ToplamKalori = toplamKcal
                    };
                    ogunler.Add(ogle);
                }
                else
                {
                    kullaniciOgun = kullanici.Ogunler.FirstOrDefault(x => x.Ogunler == Model.Ogunler.Ogle && x.OlusturulmaZamani.Date == date.Date);
                    kullaniciOgun.ToplamKalori = toplamKcal;
                    kullaniciOgun.OlusturulmaZamani = date;
                    kullaniciOgun.Besinler.Add(k);
                    db.Ogunler.Add(kullaniciOgun);
                }
            }
            else if (cmbOgun.SelectedIndex == 2)
            {
                ogunler = kullanici.Ogunler.Where(x => x.Ogunler == Model.Ogunler.AraOgun && x.OlusturulmaZamani.Date == date.Date).ToList();
                if (ogunler.Count < 1)
                {
                    ogunler = new List<Ogun>();
                    Ogun araOgun = new Ogun()
                    {
                        Kullanici = kullanici,
                        OgunAdi = cmbOgun.SelectedItem as string,
                        Ogunler = Model.Ogunler.AraOgun,
                        KullaniciId = kullaniciId,
                        OlusturulmaZamani = date,
                        ToplamKalori = toplamKcal
                    };
                    ogunler.Add(araOgun);
                }
                else
                {
                    kullaniciOgun = kullanici.Ogunler.FirstOrDefault(x => x.Ogunler == Model.Ogunler.AraOgun && x.OlusturulmaZamani.Date == date.Date);
                    kullaniciOgun.ToplamKalori = toplamKcal;
                    kullaniciOgun.OlusturulmaZamani = date;
                    kullaniciOgun.Besinler.Add(k);
                    db.Ogunler.Add(kullaniciOgun);
                }
            }
            else if (cmbOgun.SelectedIndex == 3)
            {
                ogunler = kullanici.Ogunler.Where(x => x.Ogunler == Model.Ogunler.Aksam && x.OlusturulmaZamani.Date == date.Date).ToList();
                if (ogunler.Count < 1)
                {
                    ogunler = new List<Ogun>();
                    Ogun aksam = new Ogun()
                    {
                        Kullanici = kullanici,
                        OgunAdi = cmbOgun.SelectedItem as string,
                        Ogunler = Model.Ogunler.Aksam,
                        KullaniciId = kullaniciId,
                        OlusturulmaZamani = date,
                        ToplamKalori = toplamKcal
                    };
                    ogunler.Add(aksam);
                }
                else
                {
                    kullaniciOgun = kullanici.Ogunler.FirstOrDefault(x => x.Ogunler == Model.Ogunler.Aksam && x.OlusturulmaZamani.Date == date.Date);
                    kullaniciOgun.ToplamKalori = toplamKcal;
                    kullaniciOgun.OlusturulmaZamani = date;
                    kullaniciOgun.Besinler.Add(k);
                    db.Ogunler.Add(kullaniciOgun);
                }
            }
            if (kullaniciOgun == null)
            {
                foreach (var item in ogunler)
                {
                    item.ToplamKalori = toplamKcal;
                    item.Besinler.Add(k);
                }
                foreach (var item in ogunler)
                {
                    db.Ogunler.Add(item);
                }
            }
            db.SaveChanges();
            OgunGetir();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dataGridView1.HitTest(e.X, e.Y);
                dataGridView1.Rows[hti.RowIndex].Selected = true;
                contextMenuStrip1.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("öğün silinecektir onaylıyor musunuz?", "Silme işlemi", MessageBoxButtons.YesNo);
            if (dataGridView1.SelectedRows.Count > 0)
            {

                if (result == DialogResult.Yes)
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    //var silinecekOgunAdi = db.Ogunler.Where(x => x.OgunId == id).Select(x => x.OgunAdi).FirstOrDefault();
                    Ogun silinecekOgun = db.Ogunler.FirstOrDefault(x => x.OgunId == id);
                    db.Ogunler.Remove(silinecekOgun);
                    db.SaveChanges();
                    OgunGetir();

                }
            }
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            date = dtp.Value;
        }
    }
}

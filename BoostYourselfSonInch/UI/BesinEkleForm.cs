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
    public partial class BesinEkleForm : Form
    {
        private readonly AppDbContext db;

        public BesinEkleForm()
        {
            InitializeComponent();
        }
        public BesinEkleForm(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
        }
        private void BesinEkleForm_Load(object sender, EventArgs e)
        {
            cmbBesinEkleKategori.DataSource = db.Kategoriler.ToList();
            cmbBesinEkleKategori.DisplayMember = "KategoriAdi";
            cmbBesinEkleKategori.ValueMember = ("KategoriId");
            cmbPorsiyon.DataSource = Enum.GetNames(typeof(Porsiyon));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBesinEkleAdi.Text) || nudKalori.Equals(0) || nudMiktar.Equals(0))
            {
                MessageBox.Show("Alan boş bırakılamaz");
                return;
            }

            Besin yeniBesin = new Besin()
            {
                YiyecekAdi = txtBesinEkleAdi.Text,
                Miktar = nudMiktar.Value,
                Kalori = nudKalori.Value,
                Kategori = (Kategori)cmbBesinEkleKategori.SelectedItem,

            };
            if (cmbPorsiyon.SelectedIndex == 0)
            {
                yeniBesin.Porsiyonlar = Porsiyon.Dilim;
            }
            else if (cmbPorsiyon.SelectedIndex == 1)
            {
                yeniBesin.Porsiyonlar = Porsiyon.SuBardagi;
            }
            else if (cmbPorsiyon.SelectedIndex == 2)
            {
                yeniBesin.Porsiyonlar = Porsiyon.YemekKasigi;
            }
            else if (cmbPorsiyon.SelectedIndex == 3)
            {
                yeniBesin.Porsiyonlar = Porsiyon.Adet;
            }
            else if (cmbPorsiyon.SelectedIndex == 4)
            {
                yeniBesin.Porsiyonlar = Porsiyon.Gram;
            }
            else if (cmbPorsiyon.SelectedIndex == 5)
            {
                yeniBesin.Porsiyonlar = Porsiyon.Kase;
            }

            db.Besinler.Add(yeniBesin);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Besin Kaydedildi");
            }
            else
            {
                MessageBox.Show("Hata! Kaydedilemedi");
            }
            this.Close();
        }
    }
}

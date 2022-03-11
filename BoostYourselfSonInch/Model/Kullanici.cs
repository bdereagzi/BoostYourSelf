using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BoostYourselfSonInch.Model
{
    public class Kullanici
    {
        public Kullanici()
        {
            Ogunler = new List<Ogun>();
        }
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime KayitZamani { get; set; } = DateTime.Now;
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int Boy { get; set; }
        public decimal Kilo { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public virtual List<Ogun> Ogunler { get; set; }


    }
    public enum Cinsiyet
    {
        Kadin, Erkek
    }
}

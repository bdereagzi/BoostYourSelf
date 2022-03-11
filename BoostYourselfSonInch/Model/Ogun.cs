using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BoostYourselfSonInch.Model
{
    public class Ogun
    {
        public Ogun()
        {
            Besinler = new List<Besin>();
            //Kullanicilar = new List<Kullanici>();
        }
        public int OgunId { get; set; }
        public string OgunAdi { get; set; }
        public DateTime OlusturulmaZamani { get; set; } = DateTime.Now;
        public Ogunler Ogunler { get; set; }
        public decimal ToplamKalori { get; set; }
        public int KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; }//bire-cok
        public virtual List<Besin> Besinler { get; set; }
    }
    public enum Ogunler
    {
        Kahvalti, Ogle, AraOgun, Aksam
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BoostYourselfSonInch.Model
{
    public class Besin
    {
        public Besin()
        {
            Ogunler = new List<Ogun>();
        }
        public int BesinId { get; set; }
        public string YiyecekAdi { get; set; }
        public decimal Miktar { get; set; }
        public Porsiyon Porsiyonlar { get; set; }
        public decimal Kalori { get; set; }
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
        public virtual List<Ogun> Ogunler { get; set; }

    }
    public enum Porsiyon
    {
        Dilim, SuBardagi, YemekKasigi, Adet, Gram, Kase
    }
}

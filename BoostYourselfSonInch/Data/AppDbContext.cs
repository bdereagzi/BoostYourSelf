using BoostYourselfSonInch.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BoostYourselfSonInch.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("Baglanti")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new KullaniciMapping());
            modelBuilder.Configurations.Add(new OgunMapping());
            modelBuilder.Configurations.Add(new BesinMapping());
            modelBuilder.Configurations.Add(new KategoriMapping());

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<Besin> Besinler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
    }
}

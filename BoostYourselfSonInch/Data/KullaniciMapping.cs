using BoostYourselfSonInch.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BoostYourselfSonInch.Data
{
    public class KullaniciMapping : EntityTypeConfiguration<Kullanici>
    {
        public KullaniciMapping()
        {
            ToTable("Kullanicilar");

            Property(x => x.KullaniciAdi)
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.Mail)
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.Sifre)
                .IsRequired()
                .HasMaxLength(50);

            //Property(x => x.Cinsiyet)
            //    .IsRequired()
            //    .HasColumnType("nvarchar");

            Property(x => x.Kilo)
                .IsRequired()
                .HasPrecision(4, 1);
        }
    }
}

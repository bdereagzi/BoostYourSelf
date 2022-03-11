using BoostYourselfSonInch.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoostYourselfSonInch.Data
{
    public class BesinMapping : EntityTypeConfiguration<Besin>
    {
        public BesinMapping()
        {
            ToTable("Besinler");

            Property(x => x.YiyecekAdi)
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.Miktar)
                .HasPrecision(5, 2);

            Property(x => x.Kalori)
                .HasPrecision(5, 2);

            //Property(x => x.Porsiyonlar)
            //    .IsRequired()
            //    .HasColumnType("decimal");

            //Property(x => x.Porsiyonlar)
            //   .HasPrecision(5, 2);

        }
    }
}

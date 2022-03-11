using BoostYourselfSonInch.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoostYourselfSonInch.Data
{
    public class OgunMapping : EntityTypeConfiguration<Ogun>
    {
        public OgunMapping()
        {
            ToTable("Ogunler");

            Property(x => x.OgunAdi)
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.ToplamKalori)
                .HasPrecision(5, 2);
        }
    }
}

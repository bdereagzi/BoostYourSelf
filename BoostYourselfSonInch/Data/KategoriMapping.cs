using BoostYourselfSonInch.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoostYourselfSonInch.Data
{
    public class KategoriMapping : EntityTypeConfiguration<Kategori>
    {
        public KategoriMapping()
        {
            ToTable("Kategoriler");

            Property(x => x.KategoriAdi)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}

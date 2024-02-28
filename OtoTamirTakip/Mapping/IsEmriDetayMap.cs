using OtoTamirTakip.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoTamirTakip.Mapping
{
	public class IsEmriDetayMap:EntityTypeConfiguration<IsEmirDetay>
	{
		public IsEmriDetayMap()
		{
			this.HasKey(q => q.ID);
			this.Property(q => q.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			this.Property(q => q.SiraNo).HasMaxLength(5);
			this.Property(q => q.ParcaAdi).HasMaxLength(250);
			this.Property(q => q.BirimFiyat).HasPrecision(12, 2);
			this.Property(q => q.Tutari).HasPrecision(12, 2);

			this.ToTable("IsEmriDetay");
			this.Property(q => q.ID).HasColumnName("ID");
			this.Property(q => q.SiraNo).HasColumnName("SiraNo");
			this.Property(q => q.Adet).HasColumnName("Adet");
			this.Property(q => q.ParcaAdi).HasColumnName("ParcaAdi");
			this.Property(q => q.BirimFiyat).HasColumnName("BirimFiyat");
			this.Property(q => q.Tutari).HasColumnName("Tutari");
		}
	}
}

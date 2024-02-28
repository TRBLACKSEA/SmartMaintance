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
	public class IsEmriMap : EntityTypeConfiguration<IsEmri>
	{
		public IsEmriMap()
		{
			this.HasKey(q => q.ID);
			this.Property(q => q.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			this.Property(q => q.AracKM).HasMaxLength(20);
			this.Property(q => q.OdemeSekli).HasMaxLength(20);
			this.Property(q => q.IsEmriNo).HasMaxLength(11);
			this.Property(q => q.ToplamTutar).HasPrecision(12, 2);

			this.ToTable("IsEmirleri");
			this.Property(q => q.ID).HasColumnName("ID");
			this.Property(q => q.OdemeSekli).HasColumnName("OdemeSekli");
			this.Property(q => q.IsEmriNo).HasColumnName("IsEmriNo");
			this.Property(q => q.Kasko).HasColumnName("Kasko");
			this.Property(q => q.Trafik).HasColumnName("Trafik");
			this.Property(q => q.MusOd).HasColumnName("MusOd");
			this.Property(q => q.ToplamTutar).HasColumnName("ToplamTutar");
			this.Property(q => q.AracKM).HasColumnName("AracKM");
		}
	}
}

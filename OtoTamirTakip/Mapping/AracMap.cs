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
	public class AracMap: EntityTypeConfiguration<Arac>
	{
		public AracMap()
		{
			this.HasKey(q => q.ID);
			this.Property(q=>q.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			this.Property(q => q.AracTipi).HasMaxLength(20);
			this.Property(q => q.AracModel).HasMaxLength(20);
			this.Property(q => q.Renk).HasMaxLength(20);
			this.Property(q => q.SaseNo).HasMaxLength(20);

			this.ToTable("Araclar");
			this.Property(q => q.ID).HasColumnName("AracID");
			this.Property(q => q.AracTipi).HasColumnName("AracTipi");
			this.Property(q => q.AracModel).HasColumnName("AracModel");
			this.Property(q => q.Renk).HasColumnName("Renk");
			this.Property(q => q.SaseNo).HasColumnName("SaseNo");
			this.Property(q => q.Kullanimdami).HasColumnName("Kullanimdami");
		}
	}
}

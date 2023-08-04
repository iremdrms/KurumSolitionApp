using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    internal class OdemeConfiguration : IEntityTypeConfiguration<Odeme>
    {
        public void Configure(EntityTypeBuilder<Odeme> builder)
        {
            builder.ToTable("NYO_SOSYALYARDİM");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(e => e.TcKimlikNo).HasColumnName("TCKIMLIKNO").IsRequired().HasMaxLength(11);
            builder.Property(e => e.MusteriAd).HasColumnName("MUSTERIAD").IsRequired().HasMaxLength(50);
            builder.Property(e => e.MusteriSoyad).HasColumnName("MUSTERISOYAD").IsRequired().HasMaxLength(50);
            builder.Property(e => e.OdemeDurumu).HasColumnName("ODEME_KD").IsRequired();
            builder.Property(e => e.OdenecekTutar).HasColumnName("ODENECEK_TTR").IsRequired().HasColumnType("decimal(11,2)");
            builder.Property(e => e.OdemeTarihi).HasColumnName("ODEME_TR").IsRequired().HasColumnType("date");
            builder.Property(e => e.OdemeAciklama).HasColumnName("ODEME_ACK").HasMaxLength(500);

        }
    }
}

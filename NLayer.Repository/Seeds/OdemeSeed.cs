using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class OdemeSeed : IEntityTypeConfiguration<Odeme>
    {
        public void Configure(EntityTypeBuilder<Odeme> builder)
        {
            builder.HasData(
                new Odeme
                {
                    Id = 1,
                    TcKimlikNo = "12345678901",
                    MusteriAd = "Ayşe",
                    MusteriSoyad = "Yılmaz",
                    OdemeDurumu = 0,
                    OdenecekTutar = 500.00m,
                    OdemeTarihi = DateTime.Now.AddDays(-15),
                    OdemeAciklama = "Ürün satışı",
                    CreatedDate= DateTime.Now,
                },
                new Odeme
                {
                    Id = 2,
                    TcKimlikNo = "23456789012",
                    MusteriAd = "Mehmet",
                    MusteriSoyad = "Kaya",
                    OdemeDurumu = 1,
                    OdenecekTutar = 750.50m,
                    OdemeTarihi = DateTime.Now.AddDays(-30),
                    OdemeAciklama = "Hizmet ödemesi",
                    CreatedDate = DateTime.Now,
                },
                new Odeme
                {
                    Id = 3,
                    TcKimlikNo = "34567890123",
                    MusteriAd = "Elif",
                    MusteriSoyad = "Demir",
                    OdemeDurumu = 0,
                    OdenecekTutar = 300.00m,
                    OdemeTarihi = DateTime.Now.AddDays(-7),
                    OdemeAciklama = "Fatura ödemesi",
                    CreatedDate = DateTime.Now,
                },
                new Odeme
                {
                    Id = 4,
                    TcKimlikNo = "45678901234",
                    MusteriAd = "Ahmet",
                    MusteriSoyad = "Yıldız",
                    OdemeDurumu = 2,
                    OdenecekTutar = 1200.75m,
                    OdemeTarihi = DateTime.Now.AddDays(-60),
                    OdemeAciklama = "Kira ödemesi",
                    CreatedDate = DateTime.Now,
                },
                new Odeme
                {
                    Id = 5,
                    TcKimlikNo = "56789012345",
                    MusteriAd = "Zeynep",
                    MusteriSoyad = "Akgün",
                    OdemeDurumu = 1,
                    OdenecekTutar = 250.25m,
                    OdemeTarihi = DateTime.Now.AddDays(-22),
                    OdemeAciklama = "Alışveriş ödemesi",
                    CreatedDate = DateTime.Now,
                }
                );
        }
    }
}

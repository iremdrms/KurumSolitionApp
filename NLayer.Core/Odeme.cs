using NLayer.Core.Enums;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public class Odeme: BaseEntity
    {
        
        public string TcKimlikNo { get; set; }
        public string MusteriAd {get; set; }
        public string MusteriSoyad { get; set; }
        public OdemeDurumuEnum OdemeDurumu{ get; set; }
        public decimal OdenecekTutar {get; set; }
        public DateTime OdemeTarihi { get; set; }
        public string OdemeAciklama { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.ORM.Entity
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; } //db deki money tipi
        public short Stok { get; set; }//db de smallint
        public int KategoriID { get; set; }
        public int TedarikciID { get; set; }
        public string BirimdekiMiktar { get; set; }
        public short YeniSatis { get; set; }
        public short EnAzYenidenSatisMiktari { get; set; }
        public bool Sonlandi { get; set; }//db de bit tipidir.
    }
}

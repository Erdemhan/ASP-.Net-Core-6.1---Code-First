using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPI.Models
{
    public class Ders:Entity
    {
        public string dersKodu { get; set; }
        public string ad { get; set; }
        public int kontenjan { get; set; }

        public OgretimUyesi dHoca { get; set; }
        public ICollection<Ogrenci> dOgrenciler { get; set; }
    }
}

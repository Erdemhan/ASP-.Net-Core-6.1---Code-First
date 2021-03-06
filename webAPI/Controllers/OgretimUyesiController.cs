using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAPI.Models;

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OgretimUyesiController : ControllerBase
    {
        // Constructor
        public OgretimUyesiController()
        {
        }

        [HttpGet]
        // GET requesti geldiğinde çalışacak fonksiyonumuz
        public List<OgretimUyesi> Get()
        {
            // Verinin el ile eklenmesi
            List<Ders> dersler = new List<Ders>();
            dersler.Add(new Ders { id = 0, ad = "Matematik I", dersKodu = "MM101", kontenjan = 5 });
            dersler.Add(new Ders { id = 1, ad = "Matematik 2", dersKodu = "MM102", kontenjan = 30 });
            dersler.Add(new Ders { id = 2, ad = "Fizik I", dersKodu = "FF101", kontenjan = 30 });

            List<OgretimUyesi> hocalar = new List<OgretimUyesi>();

            hocalar.Add(new OgretimUyesi { id = 0, persNo= 999, ad = "Erdemhan", soyad = "Özdin", dTarihi = DateTime.Today, verdigiDersler=dersler });

            // Verinin dönderilmesi
            return hocalar;
        }
    }
}


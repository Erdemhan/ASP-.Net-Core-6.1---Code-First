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
    public class DersController : ControllerBase
    {
        // Constructor
        public DersController()
        {
        }

        [HttpGet]
        // GET requesti geldiğinde çalışacak fonksiyonumuz
        public List<Ders> Get()
        {
            // Verinin el ile eklenmesi
            List<Ders> dersler = new List<Ders>();
            dersler.Add(new Ders { id = 0, ad = "Matematik I", dersKodu = "MM101", kontenjan = 5 });
            dersler.Add(new Ders { id = 1, ad = "Matematik 2", dersKodu = "MM102", kontenjan = 30 });
            dersler.Add(new Ders { id = 2, ad = "Fizik I", dersKodu = "FF101", kontenjan = 30 });

            // Verinin dönderilmesi
            return dersler;
        }
    }
}

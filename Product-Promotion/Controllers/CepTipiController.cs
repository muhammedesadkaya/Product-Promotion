using catiga.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace catiga.Controllers
{
    public class CepTipiController : BaseController
    {
        Product model = new Product();

        public ActionResult Index()
        {
            model.Products = C();
            return View(model);
        }

        public List<Product> C()
        {
            string cep = "cep";
            List<Product> _urunler = db.Products.Where(x => x.Type == cep).ToList();
            return _urunler;
        }
    }
}
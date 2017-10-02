using catiga.Models.DTO;
using catiga.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace catiga.Controllers
{
    public class AramaController : BaseController
    {
        ProductWM model = new ProductWM();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Autocomplete(string term)
        {

            var result = db.Products.Where(x => x.Name.Contains(term))
                         .Select(s => new ProductWM { Value = s.Name, Name = s.Name, ImagePath = s.ImagePath, ID = s.ID }).ToList();

            int num = 5;

            if (result.Count > num)
            {
                result = result.Take(num).ToList();
                ProductWM us = new ProductWM();
                us.Name = "/Arama/Index?text=" + term;
                us.Name = "Show More...";
                result.Add(us);
            }
            if (result.Count <= 0)
            {
                ProductWM us = new ProductWM();
                us.Name = "Not found";
                result.Add(us);
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
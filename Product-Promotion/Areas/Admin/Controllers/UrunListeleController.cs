using catiga.Models.DTO;
using catiga.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace catiga.Areas.Admin.Controllers
{
    public class UrunListeleController : BaseController
    {
        Product model = new Product();

        public ActionResult Index()
        {
            model.Products = C();
            return View(model);
        }

        public List<Product> C()
        {
            List<Product> _urunler = db.Products.Where(x => x.IsDelete == false).ToList();
            return _urunler;
        }

        public JsonResult DeleteUrun(int id)
        {
            Product _urun = db.Products.FirstOrDefault(x => x.ID == id);
            _urun.IsDelete = true;
            db.SaveChanges();

            return Json("");
        }
    }
}
using catiga.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace catiga.Controllers
{
    public class BilimselController : BaseController
    {
        Product model = new Product();

        public ActionResult Index()
        {
            model.Products = C();
            return View(model);
        }

        public List<Product> C()
        {
            string bilimsel = "bilimsel";
            List<Product> _urunler = db.Products.Where(x => x.Type == bilimsel && x.IsDelete == false).ToList();
            return _urunler;
        }

        public List<Product> A()
        {
            int digit12 = 12;
            string bilimsel = "bilimsel";
            List<Product> _urunler = db.Products.Where(x => x.Type == bilimsel && x.IsDelete == false && x.Digit == digit12).ToList();
            return _urunler;
        }

        public List<Product> B()
        {
            int digit14 = 14;
            string bilimsel = "bilimsel";
            List<Product> _urunler = db.Products.Where(x => x.Type == bilimsel && x.IsDelete == false && x.Digit == digit14).ToList();
            return _urunler;
        }

        public ActionResult hane(Product model)
        {
            int digit12 = 12;
            int digit14 = 14;
            if (model.Digit == digit12)
            {
                model.Products = A();
                return View("Index", model);
            }
            else if (model.Digit == digit14)
            {
                model.Products = B();
                return View("Index", model);
            }
            return RedirectToAction("Index", "Bilimsel");
        }
    }
}
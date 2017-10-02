using catiga.Areas.Admin.Models.Services;
using catiga.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace catiga.Areas.Admin.Controllers
{
    public class UrunEkleController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UrunEkle(Product model, HttpPostedFileBase exampleInputFile)
        {
            Product _product = new Product();

            _product.Name = model.Name;
            _product.Description = model.Description;
            _product.Digit = model.Digit;
            _product.Type = model.Type;

            string pic = Path.GetFileName(exampleInputFile.FileName);
            string path = Path.Combine(Server.MapPath("~/Urunler/"), pic);
            string dbpath = pic;
            _product.ImagePath = dbpath;

            db.Products.Add(_product);
            db.SaveChanges();
            exampleInputFile.SaveAs(path);

            return RedirectToAction("", "UrunEkle");
        }

    }
}
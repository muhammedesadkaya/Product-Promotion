using catiga.Models.ORM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace catiga.Controllers
{
    public class BaseController : Controller
    {
        public CatigaContext db;

        public BaseController()
        {
            db = new CatigaContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}
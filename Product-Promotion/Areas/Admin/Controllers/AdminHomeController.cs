﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace catiga.Areas.Admin.Controllers
{
    public class AdminHomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
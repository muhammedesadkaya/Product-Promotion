using catiga.Models.ORM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace catiga.Areas.Admin.Models.Services
{
    public class DrpServices
    {
        public static IEnumerable<SelectListItem> getDrpCategories()
        {
            using(CatigaContext db = new CatigaContext())
            {
                IEnumerable<SelectListItem> drpcategories = db.Products.Where(x => x.IsDelete == false).Select(x => new SelectListItem()
                {
                    Text=x.Name,
                    Value=x.ID.ToString()
                }).ToList();
                return drpcategories;
            }
        }
    }
}
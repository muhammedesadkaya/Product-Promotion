using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace catiga.Models.ORM.Entity
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public string ImagePath { get; set; }

        public string Description { get; set; }

        public int Digit { get; set; }

        public string Type { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace catiga.Models.DTO
{
    public class ProductWM : BaseWM
    {
        public string Name { get; set; }

        public string ImagePath { get; set; }

        public string Brand { get; set; }

        public string Description { get; set; }

        public int Digit { get; set; }

        public string Type { get; set; }

        public string Value { get; set; }

        public IEnumerable<ProductWM> Products { get; set; }
    }
}


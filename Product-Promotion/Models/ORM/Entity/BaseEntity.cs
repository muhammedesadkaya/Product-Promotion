using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace catiga.Models.ORM.Entity
{
    public class BaseEntity
    {
        public int ID { get; set; }

        private DateTime _addDate = DateTime.Now;
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        private bool _IsDelete = false;
        public bool IsDelete
        {
            get { return _IsDelete; }
            set { _IsDelete = value; }
        }


    }
}
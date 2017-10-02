using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace catiga.Models.ORM.Entity
{
    public class AdminUser : BaseEntity
    {
        [Required(ErrorMessage ="Lütfen geçerli bir E-mail adresi giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Lütfen geçerli bir şifre giriniz.")]
        public string Password { get; set; }

        public string AdminName { get; set; }

        public string AdminSurname { get; set; }
    }
}
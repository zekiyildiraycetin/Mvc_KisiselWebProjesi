using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
    }
}
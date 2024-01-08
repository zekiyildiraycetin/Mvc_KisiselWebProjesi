using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models
{
    public class ikonlar
    {
        [Key]
        public int Id { get; set; }
        public string ikon { get; set; }
        public string link { get; set; }
    }
}
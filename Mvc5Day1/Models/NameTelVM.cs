using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc5Day1.Models
{
    public class NameTelVM
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string tel { get; set; }
    }
}
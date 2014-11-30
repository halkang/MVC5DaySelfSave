using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc5Day1.Models
{
    public class YesNoAttribute : DataTypeAttribute
    {
        public YesNoAttribute() : base("YesNo")
        {

        }
        public override bool IsValid(object value)
        {
            return base.IsValid(value);
        }
    }
}
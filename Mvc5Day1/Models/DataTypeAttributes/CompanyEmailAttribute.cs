using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc5Day1.Models
{
    public class CompanyEmailAttribute : DataTypeAttribute
    {
        public CompanyEmailAttribute() : base(DataType.EmailAddress)
        {

        }
        public override bool IsValid(object value)
        {
            value = value ?? "";
            return value.ToString().EndsWith("@miniasp.com");
        }
    }
}
namespace Mvc5Day1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.PMEmail.Length < 15)
            {
                yield return new ValidationResult("Email 格式不合理", new string[] { "PMEmail" });
                yield break;
            }


            if (this.IsDelete && this.IsVisible)
            {
                yield return new ValidationResult("資料狀態不合理", new string[] { "IsDelete", "IsVisible" });
            }

        }
    }
    
    public partial class ProductMetaData
    {
        [Required]
        public int ProductId { get; set; }
        
        [Required]
        [StringLength(80, ErrorMessage="欄位長度不得大於 80 個字元")]
        public string ProductName { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<decimal> Stock { get; set; }
        [Required]
        public bool IsVisible { get; set; }
        [Required]
        public bool IsDelete { get; set; }

        [EmailAddress]
        [CompanyEmail(ErrorMessage="啟用多奇的信箱註冊")]
        public string PMEmail { get; set; }

        public virtual ICollection<OrderLine> OrderLine { get; set; }
    }
}

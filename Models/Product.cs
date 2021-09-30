using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace netcore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Please enter product name.")]
        public string Name { get; set; }
        [DataType(DataType.Date), Required(ErrorMessage="Please enter time.")]
        public DateTime Time { get; set; }
        [StringLength(4000), Required(ErrorMessage="Please enter product description.")]
        public string Description { get; set; }
        [Range(1, 100), DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)"), Required(ErrorMessage="Please enter price.")]
        public decimal Price { get; set; }
        [Required(ErrorMessage="Please enter rating.")]
        public string Rating { get; set; }
    }
     public class ProductPriceViewModel
    {
        public List<Product> Products { get; set; }
        public SelectList Price { get; set; }
        [RegularExpression(@"\d+\.?\d*", ErrorMessage="Only enter number."), Required(ErrorMessage="Please enter price.")]
        public string ProductPrice { get; set; }
        [Required(ErrorMessage="Please enter search key.")]
        public string SearchString { get; set; }
    }
}

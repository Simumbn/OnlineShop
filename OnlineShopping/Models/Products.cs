using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Products
    {
        //2
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string Image { get; set; }
        [Display(Name = "Product Color")]
        public string ProductColor { get; set; }
        [Required]
        public string Processor { get; set; }
        [Required]
        public string Display { get; set; }
        [Required]
        public string RAM { get; set; }
        [Required]
        public string Storage { get; set; }
        [Required]
        [Display(Name = "Available")]
        public bool IsAvailable { get; set; }
        [Required]
        [Display(Name = "Product Type")]
        public int ProductTypeID { get; set; }
        [ForeignKey("ProductTypeID")]
        public ProductTypes ProductTypes { get; set; }
        [Required]
        [Display(Name = "Tag Name")]
        public int TagNameID { get; set; }
        [ForeignKey("TagNameID")]
        public TagNames TagNames { get; set; }
        public double Quantity { get; set; }
    }
}

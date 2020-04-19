using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class OrderDetails
    {
        public int ID{ get; set; }
        [Display(Name = "Order")]
        public int OrderID { get; set; }
        [Display(Name = "Product")]
        public int PorductID { get; set; }

        [ForeignKey("OrderID")]
        public Order Order { get; set; }
        [ForeignKey("PorductID")]
        public Products Product { get; set; }

    }
}

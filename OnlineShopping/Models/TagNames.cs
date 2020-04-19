using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class TagNames
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Tag Name")]
        public string TagName { get; set; }
    }
}

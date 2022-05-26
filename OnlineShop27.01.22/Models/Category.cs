using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace OnlineShop27._01._22.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Категория")]

        public string ProductType { get; set; }

       
        public List<Product> Products { get; set; }
    }
}

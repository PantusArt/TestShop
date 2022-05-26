using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop27._01._22.Models
{
    public class Product
    {
        public int Id { get; set; }


        [Required]
        public string Name { get; set; }

        [Required]

        public decimal Price { get; set; }

        public string Image { get; set; }

        [Required]
        [Display(Name = "В наличии")]
        public bool IsAvaileble { get; set; }

        [Required]
        [Display(Name ="Категория")]

        public int CategoryId { get; set; }

        [Required]
        [Display(Name = "Производитель")]

        public int ProducerId { get; set; }
        
        [ForeignKey("CategoryId")]

        public Category Category { get; set; }

        [ForeignKey("ProducerId")]

        public Producer Producer { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
        public List<UserOrder> UserOrders { get; set; }
    }
}

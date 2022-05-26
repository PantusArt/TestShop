using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop27._01._22.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="№ заказа")]
        public string OrderNo { get; set; }

        [Required]

        public string Name { get; set; }

        [Required]
        [Display(Name = "Телефон")]
        public String PhoneNo { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        
        public string Address { get; set; }

        public DateTime OrderDate { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

    }
}

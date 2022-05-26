using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OnlineShop27._01._22.Models
{
    public class UserOrder
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Продукт")]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Пользователь")]
        public string UserId { get; set; }

        [ForeignKey("ProductId")]

        public Product Product { get; set; }

        [ForeignKey("UserId")]

        public ApplicationUser ApplicationUser { get; set; }
    }
}

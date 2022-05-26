using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop27._01._22.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        [Display(Name ="Заказ")]
        public int OrderId { get; set; }

        [Display(Name ="Товар")]
        public int ProductId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}

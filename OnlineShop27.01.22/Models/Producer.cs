using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop27._01._22.Models
{
    public class Producer
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Производитель")]
        public string ProducerName { get; set; }
        public List<Product> Products { get; set; }
    }
}

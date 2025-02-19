using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerArchitecture.Database.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        public string Product { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}

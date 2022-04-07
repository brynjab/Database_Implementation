using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Implementation.Models
{
    public class Product
    {
        public Product()
        {
            Orders = new List<Order>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int Unit_Price { get; set; }

        public List<Order> Orders { get; set; }
    }
}

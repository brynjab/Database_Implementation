using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Implementation.Models
{
    public class Order
    {
        public Order()
        {
            Customer = new Customer();
            Clerk = new Clerk();
            Products = new List<Product>();
        }

        public int Id { get; set; }
        public int Total_Price { get; set; }
        public DateTime Date { get; set; }

        public Customer Customer { get; set; }
        public Clerk Clerk { get; set; }
        public List<Product> Products { get; set; } 
        
      
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Implementation.Models
{
    public class Customer
    {
        public Customer()
        {
            Orders = new List<Order>();
        }

        public int Id { get; set; }

        
        public int CustomerNumber { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }

        public List<Order> Orders { get; set; }
    }
}

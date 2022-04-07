﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Implementation.Models
{
    public class Clerk
    {
        //mjög góð hefð 
        public Clerk()
        {
            Orders = new List<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public List<Order> Orders { get; set; }

    
    }
}

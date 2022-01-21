using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string ph_number { get; set; }
        public string pp { get; set; }
        public List<Product> order;
    }
}

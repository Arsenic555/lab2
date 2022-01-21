using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product
    {
        public int id { set; get; }

        public string name { set; get; }

        public ushort price { set; get; }

        public int ammount { set; get; }

        public string desc { set; get; }

        public string img { set; get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elastic
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public string OrderCount { get; set; }
    }
}

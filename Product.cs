using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket
{
    internal class Product
    {
        public Product(string name, int prise)
        {
            Name = name;
            Price = prise;
        }

        private string Name { get; set; }

        private int Price { get; set; }
    }
}

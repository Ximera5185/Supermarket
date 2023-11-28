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

        public int Price { get; private set; }
        private string Name { get; set; }
    }
}

using System;

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
        public string Name { get;private set; }
    }
}

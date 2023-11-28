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

        private int Price { get; set; }

        private string Name { get; set; }

        public string GetName()
        {
            return Name;
        }

        public int GetPrice()
        {
            return Price;
        }
    }
}

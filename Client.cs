using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket
{
    internal class Client
    {
        private Random _random = new Random();

        private int _maxValueMoney = 1000;
        private int _minValueMoney = 100;

        public Client(List<Product> products, List<Product> basket)
        {
            Money = _random.Next(_minValueMoney, _maxValueMoney);

            AddProductBasket(products, basket);
        }

        private int Money { get; set; }

        public int Pay(int purchaseAmount)
        {
            Money -= purchaseAmount;

            return purchaseAmount;
        }

        public void AddProductBasket(List<Product> products, List<Product> basket)
        {
            int numberSelectedProducts = _random.Next(0, products.Count);

            int indexsProduct;

            for (int i = 0; i < numberSelectedProducts; i++)
            {
                indexsProduct = _random.Next(0, products.Count);

                basket.Add(products [indexsProduct]);
            }
        }
    }
}
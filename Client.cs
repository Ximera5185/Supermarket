using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace supermarket
{
    internal class Client
    {

        Random random = new Random();
        Random random1 = new Random();

        private List<Product> _basket = new List<Product>();

        private int _maxValueMoney = 700;
        private int _minValueMoney = 100;

        public Client(List<Product> products, string name)
        {
            Name = name;

            Money = random1.Next(_minValueMoney, _maxValueMoney);

            AddProductBasket(products, _basket);
        }


        private string Name { get; set; }
        private int Money { get; set; }


        public void ShowClientInfo()
        {
            Console.WriteLine($"{Name} - {Money}");

            for (int i = 0; i < _basket.Count; i++)
            {
                Console.WriteLine($"Название продукта - {_basket [i].Name} Стоимость продукта - {_basket [i].Price}");
            }
        }

        public int Pay(int purchaseAmount)
        {
            if (Money >= purchaseAmount)
            {
                Console.WriteLine("Покупка успешна");

                Money -= purchaseAmount;

                return purchaseAmount;
            }
            else
            {
                Console.WriteLine("Недостаточно средств");

                return 0;
            }
        }

        public void AddProductBasket(List<Product> products, List<Product> basket)
        {
            int numberSelectedProducts = random.Next(0, products.Count);

            int indexsProduct;

            for (int i = 0; i < numberSelectedProducts; i++)
            {

                indexsProduct = random1.Next(0, products.Count);

                basket.Add(products [indexsProduct]);
            }
        }

        public int TakeBasketPrice()
        {
            int basketPrice = 0;

            for (int i = 0; i < _basket.Count; i++)
            {
                basketPrice += _basket [i].Price;
            }

            return basketPrice;
        }
    }
}
using System;
using System.Collections.Generic;

namespace supermarket
{
    internal class Client
    {
        static private Random _random = new Random();

        private List<Product> _basket = new List<Product>();

        private readonly int _maxValueMoney = 700;
        private readonly int _minValueMoney = 100;

        public Client(List<Product> products, string name)
        {
            Name = name;

            Money = _random.Next(_minValueMoney, _maxValueMoney);

            AddProductBasket(products, _basket);
        }

        private string Name { get; set; }
        private int Money { get; set; }

        public void ShowClientInfo()
        {
            Console.WriteLine($"{Name} - {Money}");

            for (int i = 0; i < _basket.Count; i++)
            {
                Console.WriteLine($"Название продукта - {_basket [i].GetName()} Стоимость продукта - {_basket [i].GetPrice()}");
            }
        }

        public int Pay(int purchaseAmount)
        {

            while (Money < purchaseAmount)
            {
                purchaseAmount = TakeBasketPrice();

                Console.WriteLine($"{Name}\n" +
                $"Недостаточно средств\n" +
                $"Выкидываем товар");

                Console.WriteLine();

                if (Money < purchaseAmount)
                {
                    _basket.RemoveAt(0);
                }
            }

            Console.WriteLine($"{Name}\n" + $"Покупка успешна");

            Console.WriteLine();

            Money -= purchaseAmount;

            return purchaseAmount;
        }

        public void AddProductBasket(List<Product> products, List<Product> basket)
        {
            int numberSelectedProducts = _random.Next(1, products.Count);

            int indexsProduct;

            for (int i = 0; i < numberSelectedProducts; i++)
            {
                indexsProduct = _random.Next(0, products.Count);

                basket.Add(products [indexsProduct]);
            }
        }

        public int TakeBasketPrice()
        {
            int basketPrice = 0;

            for (int i = 0; i < _basket.Count; i++)
            {
                basketPrice += _basket [i].GetPrice();
            }

            return basketPrice;
        }
    }
}
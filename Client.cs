using System;
using System.Collections.Generic;

namespace supermarket
{
    internal class Client
    {
        private static Random s_random = new Random();

        private readonly int _maxValueMoney = 700;
        private readonly int _minValueMoney = 100;

        private List<Product> _basket = new List<Product>();

        private string _name;

        private int _money;

        public Client(List<Product> products, string name)
        {
            _name = name;

            _money = s_random.Next(_minValueMoney, _maxValueMoney);

            AddProductBasket(products);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{_name} - {_money}");

            for (int i = 0; i < _basket.Count; i++)
            {
                Console.WriteLine($"Название продукта - {_basket [i].Name} Стоимость продукта - {_basket [i].Prise}");
            }
        }

        public int BuyProducts()
        {
            while (_money < TakeBasketPrice())
            {
                Console.WriteLine($"{_name}\n" +
                $"Недостаточно средств\n" +
                $"Выкидываем товар");

                Console.WriteLine();

                _basket.Remove(_basket [s_random.Next(_basket.Count - 1)]);
            }

            Console.WriteLine($"{_name}\n" + $"Покупка успешна");

            Console.WriteLine();

            _money -= TakeBasketPrice();

            return TakeBasketPrice();
        }

        public void AddProductBasket(List<Product> products)
        {
            int numberSelectedProducts = s_random.Next(products.Count);

            int indexsProduct;

            for (int i = 0; i < numberSelectedProducts; i++)
            {
                indexsProduct = s_random.Next(products.Count);

                _basket.Add(products [indexsProduct]);
            }
        }

        public int TakeBasketPrice()
        {
            int basketPrice = 0;

            for (int i = 0; i < _basket.Count; i++)
            {
                basketPrice += _basket [i].Prise;
            }

            return basketPrice;
        }
    }
}
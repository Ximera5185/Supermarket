using System;
using System.Collections.Generic;

namespace supermarket
{
    internal class Supermarket
    {
        private List<Product> _products = new List<Product>();

        private List<Client> _queueClients = new List<Client>();

        public Supermarket()
        {
            Cash = 0;
        }

        private int Cash { get; set; }

        public void Work() 
        {
            AddProduct();

            AddClient();

            ShowClients();

            ServeClients();

            ShowCashSupermarcet();
        }

        private void ShowCashSupermarcet()
        {
            Console.WriteLine($"Касса магазина - {Cash}");
        }

        private void AddProduct()
        {
            _products.Add(new Product("Сахар", 100));
            _products.Add(new Product("Молоко", 70));
            _products.Add(new Product("Хлеб", 50));
            _products.Add(new Product("Сыр", 200));
            _products.Add(new Product("Яблоко", 250));
        }

        private void AddClient()
        {
            _queueClients.Add(new Client(_products, "Алена"));
            _queueClients.Add(new Client(_products, "Дима"));
            _queueClients.Add(new Client(_products, "Аня"));
            _queueClients.Add(new Client(_products, "Оля"));
            _queueClients.Add(new Client(_products, "Данил"));
        }

        private void ServeClients()
        {
            int _purchaseAmount = 0;

            for (int i = 0; i < _queueClients.Count; i++)
            {
                _purchaseAmount = _queueClients [i].TakeBasketPrice();

                Cash += _queueClients [i].Pay(_purchaseAmount);
            }
        }

        private void ShowClients()
        {
            for (int i = 0; i < _queueClients.Count; i++)
            {
                Console.WriteLine("деньги клиента");

                _queueClients [i].ShowClientInfo();
            }
        }
    }
}
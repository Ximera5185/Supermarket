using System;
using System.Collections.Generic;

namespace supermarket
{
    internal class Supermarket
    {
        private List<Product> _products = new List<Product>();

        private Queue<Client> _queueClients = new Queue<Client>();

        private int _cash;

        public Supermarket()
        {
            _cash = 0;
        }

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
            Console.WriteLine($"Касса магазина - {_cash}");
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
            _queueClients.Enqueue(new Client(_products, "Алена"));
            _queueClients.Enqueue(new Client(_products, "Дима"));
            _queueClients.Enqueue(new Client(_products, "Аня"));
            _queueClients.Enqueue(new Client(_products, "Оля"));
            _queueClients.Enqueue(new Client(_products, "Данил"));
        }

        private void ServeClients()
        {
            while (_queueClients.Count > 0)
            {
                Client client = _queueClients.Dequeue();

                _cash += client.Pay();
            }
        }

        private void ShowClients()
        {
            int counter = 0;

            while (counter <= _queueClients.Count -1)
            {

                Client client = _queueClients.Peek();

                Console.WriteLine("деньги клиента");

                client.ShowtInfo();

                counter++;
            }
        }
    }
}
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

             AddProduct(_products);

            AddClient(_queueClients);

            ShowClients(_queueClients);

            ServeClients(_queueClients,Cash);
        }

        private int Cash { get; set; }

        private void AddProduct(List<Product> products)
        {
            products.Add(new Product("Сахар", 100));
            products.Add(new Product("Молоко", 70));
            products.Add(new Product("Хлеб", 50));
            products.Add(new Product("Сыр", 200));
            products.Add(new Product("Яблоко", 250));
        }

        public void AcceptPayment(Client client, int purchaseAmount)
        {
            Cash += client.Pay(purchaseAmount);
        }

        private void AddClient(List<Client> queueClients)
        {
            queueClients.Add(new Client(_products,"Алена"));
            queueClients.Add(new Client(_products, "Дима"));
            queueClients.Add(new Client(_products, "Аня"));
            queueClients.Add(new Client(_products, "Оля"));
            queueClients.Add(new Client(_products, "Данил"));
        }

        private void ServeClients(List<Client> queueClients, int cash)
        {
            int _purchaseAmount = 0;

            for (int i = 0; i < queueClients.Count; i++)
            {
                _purchaseAmount = queueClients [i].TakeBasketPrice();

               cash = queueClients [i].Pay(_purchaseAmount);
            }
        }

        private void ShowClients(List<Client> clients) 
        {
            for (int i = 0; i < clients.Count; i++)
            {
                Console.WriteLine("деньги клиента");

                clients [i].ShowClientInfo();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket
{
    internal class Supermarket
    {
        private List<Product> _products = new List<Product>();

        private List<Product> _basket = new List<Product>();

        private List<Client> _queueClients = new List<Client>();

        private int _purchaseAmount;

        public Supermarket()
        {
            Cash = 0;

            AddProduct(_products);

            AddClient(_queueClients);
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
            queueClients.Add(new Client(_products, _basket));
            queueClients.Add(new Client(_products, _basket));
            queueClients.Add(new Client(_products, _basket));
            queueClients.Add(new Client(_products, _basket));
            queueClients.Add(new Client(_products, _basket));
        }

        private void ServeClients(List<Client> clients) 
        {
            for (int i = 0; i < clients.Count; i++)
            {
                
            }
        }

        private int SumBascet(`) 
        {
        
        }
    }
}
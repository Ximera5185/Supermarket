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

        public Client()
        {
            Money = _random.Next(_minValueMoney, _maxValueMoney);
        }

        private Product Basket { get; set; }

        private int Money { get; set; }

        public int Pay(int purchaseAmount) 
        {
            Money -= purchaseAmount;

            return purchaseAmount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace P129HomeWorkd
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double TotalIncome { get; set; }

        public Product(string name)
        {
            Name = name;
        }

        public void Sell()
        {
            if (Count > 0)
            {
                Count --;
                TotalIncome += Price;
                return;
            }
            Console.WriteLine("Mehsulun Sayi Sifirdir");
        }

        public void Sell(int selCount)
        {
            if ((Count-selCount) >= 0)
            {
                Count-=selCount;
                TotalIncome += (selCount*Price);
                return;
            }
            Console.WriteLine("Mehsulun Sayi Sifirdir");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace P129HomeWork3
{
    class Book
    {
        private string _name;
        public string Name 
        {
            get => _name;
            set
            {
                while (value.Length < 3)
                {
                    Console.WriteLine("Duzgun Ad Daxil");
                    value = Console.ReadLine();
                }
                _name = value;
            } 
        }

        private int _pageCount;
        public int PageCount 
        {
            get => _pageCount;
            set
            {
                while (value < 10)
                {
                    Console.WriteLine("Duzgun Sehife Sayi Daxil Et");
                    value = int.Parse(Console.ReadLine());
                }
                _pageCount = value;
            } 
        }

        public Book(string name, int pagecount)
        {
            Name = name;
            PageCount = pagecount;
        }
    }
}

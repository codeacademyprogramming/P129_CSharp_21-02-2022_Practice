using System;

namespace P129HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[10];

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i+1}-ci Kitabin Adini Daxil Et");
                string name = Console.ReadLine();

                Console.WriteLine($"{i+1}-ci Kitabin Sehife Sayini Daxil Et");
                int pagecount = int.Parse(Console.ReadLine());

                Book book = new Book(name, pagecount);

                books[i] = book;
            }

            foreach (Book item in books)
            {
                Console.WriteLine($"{item.Name} {item.PageCount}");
            }
        }
    }
}

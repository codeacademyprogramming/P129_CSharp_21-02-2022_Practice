using System;

namespace P129HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Username Deyerini Daxil Et");
            string username = Console.ReadLine();

            User user = new User(username);

            Console.WriteLine("User name Duzgundur");
            Console.WriteLine("Sifreni Daxil Et");
            string password = Console.ReadLine();
            user.Password = password;

            Console.WriteLine("Sifre Ve UserName Dogrudur");

        }
    }
}

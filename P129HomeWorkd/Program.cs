using System;

namespace P129HomeWorkd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product zavod = new Product("Zavod Coreyi");
            //zavod.Price = 0.5;
            //zavod.Count = 10;

            //Console.WriteLine($"{zavod.Name} {zavod.Price} {zavod.Count} {zavod.TotalIncome}");

            //zavod.Sell();
            //zavod.Sell();

            ////Console.WriteLine($"{zavod.Name} {zavod.Price} {zavod.Count} {zavod.TotalIncome}");

            //zavod.Sell();
            //zavod.Sell();
            //zavod.Sell();
            //zavod.Sell();
            //zavod.Sell();
            //zavod.Sell();
            //zavod.Sell();
            //zavod.Sell();
            //Console.WriteLine($"{zavod.Name} {zavod.Price} {zavod.Count} {zavod.TotalIncome}");
            //zavod.Sell();

            Milk milla = new Milk("Milla");
            milla.Price = 3;
            milla.Count = 10;
            milla.Volume = 1;
            milla.FatRate = 3.2;

            Console.WriteLine($"{milla.Name} {milla.Price} {milla.Count} {milla.TotalIncome} {milla.FatRate} {milla.Volume}");

            milla.Sell();
            milla.Sell();

            //Console.WriteLine($"{zavod.Name} {zavod.Price} {zavod.Count} {zavod.TotalIncome}");

            milla.Sell();
            milla.Sell();
            milla.Sell();
            milla.Sell();
            milla.Sell();
            milla.Sell();
            milla.Sell();
            milla.Sell();
            Console.WriteLine($"{milla.Name} {milla.Price} {milla.Count} {milla.TotalIncome} {milla.FatRate} {milla.Volume}");
            milla.Sell();


        }
    }
}

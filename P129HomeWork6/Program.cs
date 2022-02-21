using System;

namespace P129HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe employe1 = new Employe
            {
                FullName = "Hamid Mammadov",
                Position = "Teacher",
                Salary = 1
            };

            Employe employe2 = new Employe
            {
                FullName = "Arif Quliyev",
                Position = "Aktor",
                Salary = 500
            };

            Employe employe3 = new Employe
            {
                FullName = "Tural Qasimli",
                Position = "Developer",
                Salary = 700
            };


            Company company = new Company();
            company.Name = "Code Academy";
            company.Limit = 3;
            company.AddEmoployee(employe1);
            company.AddEmoployee(employe2);
            company.AddEmoployee(employe3);

            Console.WriteLine("============Searche Employe==================");
            foreach (Employe item in company.SearchEmployees("m"))
            {
                Console.WriteLine($"{item.FullName} {item.No}");
            }
            Console.WriteLine("============Searche Employe==================");

            Console.WriteLine("============Get Employe==================");
            foreach (Employe item in company.GetEmployees())
            {
                Console.WriteLine($"{item.FullName} {item.No}");
            }
            Console.WriteLine("============Get Employe==================");


            Console.WriteLine("============Remove Employe==================");
            company.RemoveEmployee(2);
            Console.WriteLine("============Remove Employe==================");

            Console.WriteLine("============Remove Employe==================");
            foreach (Employe item in company.GetEmployees())
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.FullName} {item.No}");
                }
            }
            Console.WriteLine("============Remove Employe==================");


        }
    }
}

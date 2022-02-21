using System;

namespace P129HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Studnet studnet1 = new Studnet();
            studnet1.Name = "Perviz";
            studnet1.SurName = "Alizade";

            Studnet studnet2 = new Studnet();
            studnet2.Name = "Hamid";
            studnet2.SurName = "Alekberli";

            Studnet studnet3 = new Studnet();
            studnet3.Name = "Vasif";
            studnet3.SurName = "Aliyev";

            Group p129 = new Group();
            p129.No = "P129";
            p129.Limit = 2;
            p129.AddStudent(studnet1);
            p129.AddStudent(studnet2);
            p129.AddStudent(studnet3);

            Studnet[] studnets = p129.GetStudnets();

            foreach (Studnet item in studnets)
            {
                Console.WriteLine($"{item.Name} {item.SurName}");
            }
        }
    }
}

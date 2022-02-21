using System;
using System.Collections.Generic;
using System.Text;

namespace P129HomeWork6
{
    class Company
    {
        private string _name;
        public string Name 
        {
            get => _name;
            set
            {
                if (char.IsUpper(value[0]))
                {
                    foreach (char item in value)
                    {
                        if (!char.IsDigit(item) && !char.IsLetter(item) && !char.IsWhiteSpace(item))
                        {
                            Console.WriteLine("Daxil Edin Company Adi Duzgun Deyil");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Duzgun Ad Daxil Et");
                    return;
                }
            } 
        }
        public int Limit { get; set; }
        private Employe[] _employes;

        public Company()
        {
            _employes = new Employe[0];
        }

        public void AddEmoployee(Employe employe)
        {
            if (_employes.Length < Limit)
            {
                Array.Resize(ref _employes, _employes.Length + 1);
                employe.No = _employes.Length;
                _employes[_employes.Length - 1] = employe;
            }
        }

        public Employe[] GetEmployees() => _employes;

        public Employe[] SearchEmployees(string search)
        {
            Employe[] searchedEmployee = new Employe[0];

            foreach (Employe item in _employes)
            {
                if (item.FullName.Contains(search))
                {
                    Array.Resize(ref searchedEmployee, searchedEmployee.Length + 1);
                    searchedEmployee[searchedEmployee.Length - 1] = item;
                }
            }

            return searchedEmployee;
        }

        public void RemoveEmployee(int no)
        {
            for (int i = 0; i < _employes.Length; i++)
            {
                if (_employes[i].No == no)
                {
                    _employes[i] = null;
                    return;
                }
            }
            Console.WriteLine($"Daxil Etdiyniz No={no} Deyerli Isci Tapilmadi");
        }
    }
}

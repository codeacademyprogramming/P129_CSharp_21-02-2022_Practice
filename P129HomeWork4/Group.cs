using System;
using System.Collections.Generic;
using System.Text;

namespace P129HomeWork4
{
    class Group
    {
        public string No { get; set; }
        public int Limit { get; set; }
        private Studnet[] _studnets;

        public Group()
        {
            _studnets = new Studnet[0];
        }

        public void AddStudent(Studnet studnet)
        {
            if (_studnets.Length < Limit)
            {
                Array.Resize(ref _studnets, _studnets.Length + 1);
                _studnets[_studnets.Length - 1] = studnet;
            }
            else
            {
                Console.WriteLine("Groupda Yer Yoxdu");
            }
        }

        public Studnet[] GetStudnets()
        {
            return _studnets;
        }
    }
}

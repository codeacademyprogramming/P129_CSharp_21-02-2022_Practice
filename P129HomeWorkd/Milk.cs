using System;
using System.Collections.Generic;
using System.Text;

namespace P129HomeWorkd
{
    class Milk : Product
    {
        public double Volume { get; set; }
        public double FatRate { get; set; }
        public Milk(string name) : base(name)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EventDrivenProgramming
{
    internal class Refree
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() => $"{Id}, {Name}";

        public void Look() => Console.WriteLine($"{this} is looking");
       
    }
}

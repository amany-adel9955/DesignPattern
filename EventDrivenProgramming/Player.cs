using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EventDrivenProgramming
{
    internal class Player
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Team { get; set; }
        public override string ToString() => $"{Id} , {Name}, {Team}";

        public void Run() => Console.WriteLine($"{this} is running");
       
        
    }
}

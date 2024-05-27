using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class RubberDuck : Duck
    {
        public override void Display() =>  Console.WriteLine("I'm rubber duck");

        public RubberDuck(): base(new NoFly(), new Quacking())  // chaining to the parent constructor that implement interface that many classes implement it (nofly , quacking)
        {
                
        }


    }
}

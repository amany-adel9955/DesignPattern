using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class WhiteDuck : Duck
    {
        public WhiteDuck(): base(new NormalFly(), new Queezing())
        {
                
        }
        public override void Display() => Console.WriteLine("i'm a white duck");
       
    }
}

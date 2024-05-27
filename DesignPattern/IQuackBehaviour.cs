using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal interface IQuackBehaviour
    {
        public void QuackingBehaviour();
    }

    internal class Quacking : IQuackBehaviour
    {
        public void QuackingBehaviour()
        {
            Console.WriteLine("i'm quacking");
            Console.Beep();
        }
    }

    internal class Queezing : IQuackBehaviour
    {
        public void QuackingBehaviour()
        {
            Console.WriteLine("i'm queezing");
            Console.Beep(37, 1000);
        }
    }
}

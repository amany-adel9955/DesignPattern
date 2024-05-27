using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal interface IFlyBehavior
    {
        public void Flying();
    }

    internal class NoFly : IFlyBehavior
    {
        public void Flying()
        {
            Console.WriteLine("I'm not flying ");
        }
    }
    internal class NormalFly : IFlyBehavior
    {
        public void Flying()
        {
            Console.WriteLine("I'm flying with normal speed");
        }
    }

    internal class HighSpeedFly : IFlyBehavior
    {
        public void Flying()
        {
            Console.WriteLine("I'm flying with high speed");
        }
    }
}

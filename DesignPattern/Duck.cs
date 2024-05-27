using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehaviour QuackBehaviour { get; set; }

        protected Duck(IFlyBehavior flyBehavior , IQuackBehaviour quackBehaviour)
        {
            FlyBehavior = flyBehavior;
            QuackBehaviour = quackBehaviour;
        }
        public abstract void Display();
        public void Swim() => Console.WriteLine("I can swim");
        public void Cack()
        {
            QuackBehaviour.QuackingBehaviour();   // delegation to a method in class that implements the iquackbehaviour interface 
        }
        public void Fly() // fly function that call the fly behavior function according to the class implement the interface
        {
            FlyBehavior.Flying();
        }
    }
}

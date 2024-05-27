using AbstractFactory.CarComponents.Engine;
using AbstractFactory.CarComponents.FrontWing;
using AbstractFactory.CarComponents.GearBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarComponents.Factories
{
    internal class ConcreteFactory02 : IFactory
    {
        IEngine IFactory.GetEngine() => new MercsedsEngine();


        IFrontWing IFactory.GetFrontWing() => new DesignB();


        IGearBoxes IFactory.GetGearBox() => new GearBoxY();
     
    }
}

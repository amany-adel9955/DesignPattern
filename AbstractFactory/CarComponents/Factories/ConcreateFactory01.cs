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
    internal class ConcreateFactory01 : IFactory
    {
        IEngine IFactory.GetEngine() => new BMWEngine();


        IFrontWing IFactory.GetFrontWing() => new DesignA();


        IGearBoxes IFactory.GetGearBox() => new GearBoxX();
        
    }
}

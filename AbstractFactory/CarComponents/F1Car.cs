using AbstractFactory.CarComponents.Engine;
using AbstractFactory.CarComponents.Factories;
using AbstractFactory.CarComponents.FrontWing;
using AbstractFactory.CarComponents.GearBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarComponents
{
    internal class F1Car
    {
        IEngine _engine;
        IFrontWing _frontWing;
        IGearBoxes _gearBox;
        IFactory _factory;
        public F1Car(IFactory factory)
        {
            _factory = factory;
        }

        public void Assemble()
        {
            _engine = _factory.GetEngine();
            _frontWing = _factory.GetFrontWing();
            _gearBox = _factory.GetGearBox();
        }
    }
}

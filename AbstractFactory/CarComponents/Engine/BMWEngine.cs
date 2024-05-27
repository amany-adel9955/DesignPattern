using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarComponents.Engine
{
    internal class BMWEngine : IEngine
    {
        int IEngine.HoursePower => 3000;

        int IEngine.MaxSpeeg => 400;
    }
}

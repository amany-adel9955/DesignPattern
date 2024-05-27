using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarComponents.Engine
{
    internal class MercsedsEngine : IEngine
    {
        public int HoursePower => 2000;

        public int MaxSpeeg => 500;
    }
}

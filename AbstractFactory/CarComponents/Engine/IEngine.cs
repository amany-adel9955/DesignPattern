using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarComponents.Engine
{
    internal interface IEngine
    {
        public int HoursePower { get; }
        public int MaxSpeeg { get;}
    }
}

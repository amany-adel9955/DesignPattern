using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarComponents.GearBox
{
    internal interface IGearBoxes
    {
        public int ShiftNo { get;}
        public bool IsAutomatic { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarComponents.GearBox
{
    internal class GearBoxY : IGearBoxes
    {
        int IGearBoxes.ShiftNo => 6;

        bool IGearBoxes.IsAutomatic => true;
    }
}

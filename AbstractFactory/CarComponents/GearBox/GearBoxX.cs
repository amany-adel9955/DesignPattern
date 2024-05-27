using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarComponents.GearBox
{
    internal class GearBoxX : IGearBoxes
    {
        int IGearBoxes.ShiftNo => 4;

        bool IGearBoxes.IsAutomatic => false;
    }
}

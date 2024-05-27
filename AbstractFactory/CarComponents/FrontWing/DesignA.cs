using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarComponents.FrontWing
{
    internal class DesignA : IFrontWing
    {
        int IFrontWing.NoWings => 4;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    internal class Beverage
    {
        public virtual decimal Cost { get; set; }
        public virtual string Description { get; set; }

        public override string ToString()
        {
            return $"Description: {Description} \nCost: {Cost:c}";
        }
    }

    internal class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Spresso coffee";
            Cost = 2.5M; 
        }
    }

    internal class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "Houseblend coffee";
            Cost = 3.5M;
        }
    }

    internal class DarkRoast: Beverage
    {
        public DarkRoast()
        {
            Description = "Darkroast coffee";
            Cost = 2.8M;
        }
    }

    internal class Decafe : Beverage
    {
        public Decafe()
        {
            Description = "Decafe coffee";
            Cost = 2.4M;
        }
    }
}

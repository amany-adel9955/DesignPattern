using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{

    internal class Milk : Beverage // the milk itself is a beverage 
    {
        Beverage _beverage;  // is a composition relationship (the drink composed of coffee and milk)
        public Milk(Beverage beverage) 
        {
            _beverage = beverage;
        }

        public override string Description => $"{_beverage.Description}, with milk";

        public override decimal Cost => _beverage.Cost + 1.5M;
    }

    internal class Mocha :Beverage
    {
      Beverage _beverage;
        public Mocha(Beverage beverage)
        {
            _beverage = beverage; 
        }
        public override string Description => $"{_beverage.Description}, with mocha";

        public override decimal Cost => _beverage.Cost + 1.8M;
    }


    internal class Caramel : Beverage
    {
        Beverage _beverage;
        public Caramel(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string Description => $"{_beverage.Description}, with caramel";

        public override decimal Cost => _beverage.Cost + 2.8M;
    }  // event driven programming
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class GCard
    {
        public int Card { get; set; }
        private GCard(int card)  // private constructor.. can't make object from it
        {
            Card = card;  
        }

       static GCard()  // static constructor called by clr one time before using the class in the run time
        {
            SngletoneObj = new GCard(123);
        }
        private static GCard SngletoneObj;   // private property to make one object from the constructor
        public static GCard GetGCard()
        {

                 // static method that return an object from this class
            return SngletoneObj;
        }
    }
}

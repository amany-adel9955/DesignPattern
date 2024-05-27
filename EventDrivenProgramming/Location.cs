using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenProgramming
{
    internal struct Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Location(int x , int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString() => $"({X}, {Y}, {Z})";

        public static bool operator == (Location Left , Location Right)  // overide equal and not equal operators to use them in struct
        {
            return Left.X == Right.X && Left.Y == Right.Y && Left.Z == Right.Z;
        }

        public static bool operator != (Location Left, Location Right)
        {
            return Left.X != Right.X || Left.Y != Left.Y || Left.Z != Right.Z;
        }
            

        
    }
}

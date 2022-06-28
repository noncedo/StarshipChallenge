using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarshipChallenge
{
    class Location
    {
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }
        public int zCoordinate { get; set; }

        public int CalculateSurfaceArea(int x, int y, int z)
        {
            return x*y*z;
        }
        public bool SetHabitability(int area)
        {

            return false;
        }
    }
   
}

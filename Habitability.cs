using System;

namespace StarshipChallenge
{
    abstract class Habitability
    {
        public abstract int SetTravelSpeed();
        public virtual double Colonization(double area)
        {
            return 1;
        }
        public string Habitable { get; set; }
        protected int Area;
    }

    class IsHabitable : Habitability
    {
        public override double Colonization(double area)
        {
            //Not sure how much time it takes to colonise a planet.
            double ColonisedSurfaceArea = 0.043 * (0.5 * area);

            return ColonisedSurfaceArea;
        }
        public override int SetTravelSpeed()
        {
            return 10;
        }
        
            
    }
    class NotHabitable:Habitability
    {
        public override int SetTravelSpeed()
        {
            return 10 * 2;
        }
    }
}

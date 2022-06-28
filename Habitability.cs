using System;

namespace StarshipChallenge
{
    /*
     * I have tried to implement Strategy Pattern to define a planet's habitability
     * I have encapsulated algorithms from the location class to a class called habitabity which includes subclasses(IsHabitable and NotHabitable)
     * Which provide their own implementation
     */
    abstract class Habitability
    {
        public abstract int SetTravelSpeed();
        public virtual double Colonization(double area)
        {
            return area;
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

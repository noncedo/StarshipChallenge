using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarshipChallenge
{
   abstract class Habitability
    {
        public abstract int SetTravelSpeed();
        public abstract int Colonization();
    }

    class IsHabitable:Habitability
    {
        public override int Colonization()
        {
            throw new NotImplementedException();
        }
        public override int SetTravelSpeed()
        {
            throw new NotImplementedException();
        }
    }
    class NotHabitable:Habitability
    {
        public override int Colonization()
        {
            throw new NotImplementedException();
        }
        public override int SetTravelSpeed()
        {
            throw new NotImplementedException();
        }
    }
}

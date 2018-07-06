using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSchedule.Domain.Model
{
    public class Route
    {
        public string Origin { get; private set; }
        public string Destination { get; private set; }
        protected Route() { }

        public Route(string origin, string destination)
        {
            if(OriginIsSameAsDestination(origin, destination))
                throw new Exception();

            this.Origin = origin.ToUpper();
            this.Destination = destination.ToUpper();
        }

        private static bool OriginIsSameAsDestination(string origin, string destination)
        {
            return origin.ToUpper().Equals(destination.ToUpper());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSchedule.Domain.Model;

namespace FlightSchedule.Domain.TestUtil
{
    public class RouteTestBuilder
    {
        public string Origin { get; private set; }
        public string Destination { get; private set; }

        public RouteTestBuilder()
        {
            this.Origin = "IKA";
            this.Destination = "DXB";
        }
        public RouteTestBuilder WithOrigin(string origin)
        {
            this.Origin = origin;
            return this;
        }

        public RouteTestBuilder WithDestination(string destination)
        {
            this.Destination = destination;
            return this;
        }

        public Route Build()
        {
            return new Route(this.Origin, this.Destination);
        } 
    }
}

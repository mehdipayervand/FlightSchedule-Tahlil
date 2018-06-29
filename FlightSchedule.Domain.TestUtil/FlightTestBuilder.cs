using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSchedule.Domain.Model;

namespace FlightSchedule.Domain.TestUtil
{
    public class FlightTestBuilder
    {
        public DateTime DepartDate { get; private set; }
        public string Aircraft { get; private set; }
        public string FlightNo { get; private set; }
        public Route Route { get; private set; }

        public FlightTestBuilder()
        {
            this.DepartDate = DateTime.Now.AddDays(5);
            this.Aircraft = "AIRBUS";
            this.FlightNo = "2020";
            this.Route = new RouteTestBuilder().Build();
        }

        public Flight Build()
        {
            return new Flight(DepartDate, Aircraft, FlightNo, Route);
        }
    }
}

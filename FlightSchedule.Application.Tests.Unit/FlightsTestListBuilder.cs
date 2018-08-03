using System.Collections.Generic;
using FlightSchedule.Domain.Model;
using FlightSchedule.Domain.TestUtil;

namespace FlightSchedule.Application.Tests.Unit
{
    internal class FlightsTestListBuilder
    {
        internal IEnumerable<Flight> GetSomeFlights(long count)
        {
            var builder = new FlightTestBuilder();
            for (var i = 0; i < count; i++)
            {
                yield return builder.Build();
            }
        }
    }
}
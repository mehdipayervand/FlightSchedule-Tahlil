using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSchedule.Domain.Model;
using FlightSchedule.Domain.Services;
using NSubstitute;

namespace FlightSchedule.Application.Tests.Unit
{
    public class FlightServiceBuilder
    {
        public IFlightRepository FlightRepository { get; private set; }
        public IFlightCalculationService FlightCalculationService { get; private set; }

        public FlightServiceBuilder()
        {
            FlightRepository = Substitute.For<IFlightRepository>();
            FlightCalculationService = Substitute.For<IFlightCalculationService>();
        }

        public FlightService Build()
        {
            return new FlightService(FlightRepository, FlightCalculationService);
        }
    }
}

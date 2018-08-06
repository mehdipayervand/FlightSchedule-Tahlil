using FlightSchedule.Domain.Model;
using FlightSchedule.Domain.Services;
using NSubstitute;

namespace FlightSchedule.Application.Tests.Utils
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

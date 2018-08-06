using NSubstitute;
using Xunit;

namespace FlightSchedule.Application.Tests.Unit
{
    public class FlightServiceTests
    {
        [Fact]
        public void GenerateFlights_should_calculate_flights_and_save_them()
        {
            //TODO: refactor this test (use a factory or builder)
            //Ghomi: Codes Just Moved to FlightServiceBuilder Class ;)

            //arrange
            var flightServiceBuilder = new FlightServiceBuilder().GetSomeFlight(2);

            //act
            flightServiceBuilder.GenerateFlights();

            //assert
            flightServiceBuilder.FlightRepositoryProp.Received(1).Save(flightServiceBuilder.CalculatedFlightsProp[0]);
            flightServiceBuilder.FlightRepositoryProp.Received(1).Save(flightServiceBuilder.CalculatedFlightsProp[1]);
        }
    }
}

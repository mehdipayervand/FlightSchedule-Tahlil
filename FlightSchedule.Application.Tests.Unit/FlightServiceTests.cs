using System;
using System.Linq;
using Castle.Components.DictionaryAdapter;
using FlightSchedule.Domain.Model;
using FlightSchedule.Domain.Services;
using FlightSchedule.Domain.Shared;
using FluentAssertions;
using NSubstitute;
using Xunit;
using Xunit.Sdk;

namespace FlightSchedule.Application.Tests.Unit
{
    public class FlightServiceTests
    {
        [Fact]
        public void GenerateFlights_should_calculate_flights_and_save_them()
        {
            var schedule = new ReserveSchedule();
            var calculationService = Substitute.For<IFlightCalculationService>();
            var calculatedFlights = new FlightsTestListBuilder().GetSomeFlights(2).ToList();
            calculationService.Calculate(schedule).Returns(calculatedFlights);
            var repository = Substitute.For<IFlightRepository>();
            var flightService = new FlightService(repository, calculationService);

            flightService.GenerateFlights(schedule);

            repository.Received(1).Save(calculatedFlights[0]);
            repository.Received(1).Save(calculatedFlights[1]);
        }
        
        
        //TODO: move to another class :)
        //Ghomi: Codes Just Moved to FlightsTestListBuilder Class ;)
    }
}

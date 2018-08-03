using System;
using System.Collections.Generic;
using FlightSchedule.Domain.Model;
using FlightSchedule.Domain.Services;
using FlightSchedule.Domain.Shared;
using FluentAssertions;
using Xunit;

namespace FlightSchedule.Domain.Tests.Unit.Services
{
    public class FlightCalculationServiceTests
    {
        [Fact]
        public void Calculate_should_calculate_flights_based_on_weekly_plan()
        {
            var route = new Route("IKA", "SJC");
            var reserveSchedule = CreateReserveSchedule(route);
            var expectedFlights = CreateExpectedFlights(route);

            var actualFlights = new FlightCalculationService().Calculate(reserveSchedule);
            actualFlights.Should().BeEquivalentTo(expectedFlights);
        }

        private static IEnumerable<Flight> CreateExpectedFlights(Route route)
        {
            return new List<Flight>()
            {
                //TODO: make factory method for flight
                new Flight(new DateTime(2018,3,19,8,0,0),null,null,route),
                new Flight(new DateTime(2018,3,21,15,0,0),null,null,route),
                new Flight(new DateTime(2018,3,26,8,0,0),null,null,route),
                new Flight(new DateTime(2018,3,28,15,0,0),null,null,route),
            };
        }

        private static ReserveSchedule CreateReserveSchedule(Route route)
        {
            return new ReserveSchedule()
            {
                StartReserveDate = new DateTime(2018,03,17),
                EndReserveDate = new DateTime(2018,04,1),
                Route = route,
                WeeklyTimetable = new List<WeeklyTimetable>()
                {
                    new WeeklyTimetable() { DayOfWeek = DayOfWeek.Monday, DepartTime = new TimeSpan(8,0,0)},
                    new WeeklyTimetable() { DayOfWeek = DayOfWeek.Wednesday, DepartTime = new TimeSpan(15,0,0)}
                }
            };
        }
    }
}

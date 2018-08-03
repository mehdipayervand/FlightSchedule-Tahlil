using System;
using System.Collections.Generic;
using System.Linq;
using FlightSchedule.Application.Contracts.DataTransferObjects;
using FlightSchedule.Domain.Model;
using FlightSchedule.Domain.Services;
using FlightSchedule.Domain.Shared;
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
            var schedule = new ReserveScheduleDto()
            {
                Aircraft = "daf",
                WeeklyTimetable = new List<WeeklyTimetableDto>()
                {
                    new WeeklyTimetableDto {DepartTime = TimeSpan.MaxValue, DayOfWeek = DayOfWeek.Friday}
                },
                FlightNo = "daf",
                Destination = "fas",
                StartReserveDate = DateTime.Now,
                EndReserveDate = DateTime.Now,
                Origin = "fads"
            };
            var calculationService = Substitute.For<IFlightCalculationService>();
            var calculatedFlights = new FlightsTestListBuilder().GetSomeFlights(2).ToList();
            calculationService.Calculate(Arg.Any<ReserveSchedule>()).Returns(calculatedFlights);
            var repository = Substitute.For<IFlightRepository>();
            var flightService = new FlightService(repository, calculationService);

            flightService.GenerateFlights(schedule);

            repository.Received(1).Save(calculatedFlights[0]);
            repository.Received(1).Save(calculatedFlights[1]);
        }
    }
}
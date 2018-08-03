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
            //Arrange
            var flightServiceBuilder = new FlightServiceBuilder();
            var schedule = CreateReserveScheduleDto();
            var calculatedFlights = new FlightsTestListBuilder().GetSomeFlights(2).ToList();
            flightServiceBuilder.FlightCalculationService.Calculate(Arg.Any<ReserveSchedule>())
                .Returns(calculatedFlights);
            var flightService = flightServiceBuilder.Build();

            //Act
            flightService.GenerateFlights(schedule);

            //Assert
            flightServiceBuilder.FlightRepository.Received(1).Save(calculatedFlights[0]);
            flightServiceBuilder.FlightRepository.Received(1).Save(calculatedFlights[1]);
        }

        private static ReserveScheduleDto CreateReserveScheduleDto()
        {
            //TODO: Remove datetime.now
            return new ReserveScheduleDto()
            {
                Aircraft = "Airbus-W350",
                WeeklyTimetable = CreateWeeklyTimetableDto(),
                FlightNo = "WS-2040",
                Destination = "FRA",
                Origin = "IKA",
                StartReserveDate = DateTime.Now,
                EndReserveDate = DateTime.Now
            };
        }

        private static List<WeeklyTimetableDto> CreateWeeklyTimetableDto()
        {
            return new List<WeeklyTimetableDto>()
            {
                new WeeklyTimetableDto {DepartTime = TimeSpan.MaxValue, DayOfWeek = DayOfWeek.Friday}
            };
        }
    }
}
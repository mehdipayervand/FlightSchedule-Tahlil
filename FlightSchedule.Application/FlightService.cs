using System.Collections.Generic;
using System.Data;
using FlightSchedule.Application.Contracts;
using FlightSchedule.Application.Contracts.DataTransferObjects;
using FlightSchedule.Domain.Model;
using FlightSchedule.Domain.Services;
using FlightSchedule.Domain.Shared;

namespace FlightSchedule.Application
{
    public class FlightService : IFlightService
    {
        private readonly IFlightRepository _repository;
        private readonly IFlightCalculationService _calculationService;

        public FlightService(IFlightRepository repository, IFlightCalculationService calculationService)
        {
            _repository = repository;
            _calculationService = calculationService;
        }

        public void GenerateFlights(ReserveScheduleDto command)
        {
            var schedule = Map(command);
            var flights = _calculationService.Calculate(schedule);
            foreach (var flight in flights)
            {
                _repository.Save(flight);
            }
        }

        public void GenerateFlights(ReserveSchedule reserveSchedule)
        {
            var flights = _calculationService.Calculate(reserveSchedule);
            foreach (var flight in flights)
            {
                _repository.Save(flight);
            }
        }

        private ReserveSchedule Map(ReserveScheduleDto command)
        {
            return new ReserveSchedule
            {
                Aircraft = command.Aircraft,
                FlightNo = command.FlightNo,
                Route = new Route(command.Origin, command.Destination),
                StartReserveDate = command.StartReserveDate,
                EndReserveDate = command.EndReserveDate,
                WeeklyTimetable = Map(command.WeeklyTimetable)
            };
        }

        public List<WeeklyTimetable> Map(List<WeeklyTimetableDto> weeklyTimetable)
        {
            var result = new List<WeeklyTimetable>();
            weeklyTimetable.ForEach(item => { result.Add(new WeeklyTimetable(item.DayOfWeek, item.DepartTime)); });
            return result;
        }
    }
}
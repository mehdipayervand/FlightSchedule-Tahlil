using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSchedule.Domain.Model;
using FlightSchedule.Domain.Services;
using FlightSchedule.Domain.Shared;

namespace FlightSchedule.Application
{
    public class FlightService
    {
        private readonly IFlightRepository _repository;
        private readonly IFlightCalculationService _calculationService;

        public FlightService(IFlightRepository repository, IFlightCalculationService calculationService)
        {
            _repository = repository;
            _calculationService = calculationService;
        }

        public void GenerateFlights(ReserveSchedule schedule)
        {
            var flights = _calculationService.Calculate(schedule);
            foreach (var flight in flights)
            {
                _repository.Save(flight);
            }
        }
    }
}

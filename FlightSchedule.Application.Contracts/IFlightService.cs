using FlightSchedule.Application.Contracts.DataTransferObjects;
using FlightSchedule.Domain.Shared;

namespace FlightSchedule.Application.Contracts
{
    public interface IFlightService
    {
        void GenerateFlights(ReserveScheduleDto command);
    }
}
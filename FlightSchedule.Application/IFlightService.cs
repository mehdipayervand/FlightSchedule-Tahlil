using FlightSchedule.Domain.Shared;

namespace FlightSchedule.Application
{
    public interface IFlightService
    {
        void GenerateFlights(ReserveSchedule schedule);
    }
}
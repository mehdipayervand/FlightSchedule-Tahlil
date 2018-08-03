using System.Web.Http;
using FlightSchedule.Application.Contracts;
using FlightSchedule.Application.Contracts.DataTransferObjects;

namespace FlightSchedule.Presentation.Controllers
{
    public class FlightsController : ApiController
    {
        private readonly IFlightService _service;

        public FlightsController(IFlightService service)
        {
            this._service = service;
        }

        //TODO: don't reference domain here :| (USE DTO INSTEAD)
        public void Post(ReserveScheduleDto schedule)
        {
            _service.GenerateFlights(schedule);
        }
    }
}
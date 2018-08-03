using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FlightSchedule.Application;
using FlightSchedule.Domain.Services;
using FlightSchedule.Domain.Shared;

namespace FlightSchedule.Presentation.Controllers
{
    public class FlightsController : ApiController
    {
        private IFlightService _service;
        public FlightsController(IFlightService service)
        {
            this._service = service;
        }

        //TODO: don't reference domain here :| (USE DTO INSTEAD)
        public void Post(ReserveSchedule schedule)
        {
            _service.GenerateFlights(schedule);
        }
    }
}

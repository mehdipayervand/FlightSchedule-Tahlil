using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSchedule.Domain.Shared;
using RestSharp;

namespace FlightSchedule.Specs.Endpoints
{
    public static class FlightEndpoint
    {
        public static void GenerateFlights(ReserveSchedule schedule)
        {
            var client = new RestClient("http://localhost:5783/api/");
            var request = new RestRequest("flights", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(schedule);
            var response = client.Execute(request);
        }
    }
}

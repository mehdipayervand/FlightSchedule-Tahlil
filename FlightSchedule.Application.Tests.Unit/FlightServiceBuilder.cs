using FlightSchedule.Domain.Model;
using FlightSchedule.Domain.Services;
using FlightSchedule.Domain.Shared;
using NSubstitute;
using System.Collections.Generic;
using System.Linq;

namespace FlightSchedule.Application.Tests.Unit
{
    public class FlightServiceBuilder
    {
        #region Fields
        private int _numberOfFlightsToGenerate;
        #endregion

        #region Properties
        public ReserveSchedule ReserveScheduleProp { get; set; }
        public IFlightCalculationService FlightCalculationServiceProp { get; set; }
        public List<Flight> CalculatedFlightsProp { get; set; }
        public IFlightRepository FlightRepositoryProp { get; set; }
        public FlightService FlightService { get; set; }
        public int NumberOfFlightsToGenerate
        {
            get { return _numberOfFlightsToGenerate; }
            set
            {
                _numberOfFlightsToGenerate = value;

                CalculatedFlightsProp = new FlightsTestListBuilder().GetSomeFlights(_numberOfFlightsToGenerate).ToList();
                FlightCalculationServiceProp.Calculate(ReserveScheduleProp).Returns(CalculatedFlightsProp);
                FlightService = new FlightService(FlightRepositoryProp, FlightCalculationServiceProp);
            }
        }
        #endregion

        public FlightServiceBuilder()
        {
            ReserveScheduleProp = new ReserveSchedule();
            FlightCalculationServiceProp = Substitute.For<IFlightCalculationService>();
            FlightRepositoryProp = Substitute.For<IFlightRepository>();
        }

        #region Methods
        /// <summary>
        /// This Method will Generate Flights based on given number of Flights
        /// </summary>
        /// <param name="numberOfFlights">Number of Flights to generate</param>
        /// <returns></returns>
        public FlightServiceBuilder GetSomeFlight(int numberOfFlights)
        {
            this.NumberOfFlightsToGenerate = numberOfFlights;
            return this;
        }

        /// <summary>
        /// This Method will generate Fights Schedule
        /// </summary>
        /// <returns></returns>
        public void GenerateFlights()
        {
            FlightService.GenerateFlights(ReserveScheduleProp);
        }
        #endregion
    }
}

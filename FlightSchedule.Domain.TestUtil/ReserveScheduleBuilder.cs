using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSchedule.Domain.Model;
using FlightSchedule.Domain.Shared;
using Framework.Core.Clock;

namespace FlightSchedule.Domain.TestUtil
{
    public class ReserveScheduleBuilder
    {
        public string Aircraft { get; private set; }
        public string FlightNo { get; private set; }
        public Route Route { get; private set; }
        public DateTime StartReserveDate { get; private set; }
        public DateTime EndReserveDate { get; private set; }
        public List<WeeklyTimetable> WeeklyTimetable { get; private set; }

        public ReserveScheduleBuilder()
        {
            var route = new Route("IKA", "SJC");
            StartReserveDate = TravelTo.SomeFutureTime();
            EndReserveDate = TravelTo.SomeFutureTime();
            Route = route;
            WeeklyTimetable = new List<WeeklyTimetable>();
            Aircraft = "AIRBUS";
            FlightNo = "2020";
        }

        public ReserveScheduleBuilder WithAircraft(string aircraft)
        {
            Aircraft = aircraft;
            return this;
        }

        public ReserveScheduleBuilder WithFlightNo(string flightNo)
        {
            FlightNo = flightNo;
            return this;
        }

        public ReserveScheduleBuilder WithRoute(Route route)
        {
            Route = route;
            return this;
        }

        public ReserveScheduleBuilder WithStartReserveDate(DateTime startReserveDate)
        {
            StartReserveDate = startReserveDate;
            return this;
        }

        public ReserveScheduleBuilder WithEndReserveDate(DateTime endReserveDate)
        {
            EndReserveDate = endReserveDate;
            return this;
        }

        public ReserveScheduleBuilder WithWeeklyTimetable(List<WeeklyTimetable> weeklyTimetable)
        {
            WeeklyTimetable = weeklyTimetable;
            return this;
        }

        public ReserveSchedule Build()
        {
            return new ReserveSchedule(Aircraft, FlightNo, Route, StartReserveDate, EndReserveDate, WeeklyTimetable);
        }
    }
}
using System;
using System.Collections.Generic;
using FlightSchedule.Domain.Model;

namespace FlightSchedule.Domain.Shared
{
    public class ReserveSchedule
    {
        public string Aircraft { get; set; }
        public string FlightNo { get; set; }
        public Route Route { get; set; }
        public DateTime StartReserveDate { get; set; }
        public DateTime EndReserveDate { get; set; }
        public List<WeeklyTimetable> WeeklyTimetable { get; set; }

        public ReserveSchedule()
        {
            
        }

        public ReserveSchedule(string aircraft, string flightNo, Route route, DateTime startReserveDate, DateTime endReserveDate, List<WeeklyTimetable> weeklyTimetable)
        {
            Aircraft = aircraft;
            FlightNo = flightNo;
            Route = route;
            StartReserveDate = startReserveDate;
            EndReserveDate = endReserveDate;
            WeeklyTimetable = weeklyTimetable;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSchedule.Domain.Model;
using FlightSchedule.Domain.Shared;
using Framework.Core;

namespace FlightSchedule.Domain.Services
{
    public class FlightCalculationService
    {
        public static List<Flight> Calculate(ReserveSchedule schedule)
        {
            var flights = new List<Flight>();
            foreach (var dateTime in schedule.StartReserveDate.EachDay(schedule.EndReserveDate))
            {
                var dayOfWeekInReserves = FindDayInWeek(schedule, dateTime);
                if (HasFlightInDay(dayOfWeekInReserves))
                {
                    var departDate = CalculateDepartDate(dateTime, dayOfWeekInReserves);
                    var flight = new Flight(departDate, schedule.Aircraft, schedule.FlightNo, schedule.Route);
                    flights.Add(flight);
                }
            }
            return flights;
        }

       

        private static WeeklyTimetable FindDayInWeek(ReserveSchedule schedule, DateTime dateTime)
        {
            return schedule.WeeklyTimetable.FirstOrDefault(a => a.DayOfWeek == dateTime.DayOfWeek);
        }
        private static bool HasFlightInDay(WeeklyTimetable dayOfWeekInReserves)
        {
            return dayOfWeekInReserves != null;
        }
        private static DateTime CalculateDepartDate(DateTime dateTime, WeeklyTimetable dayOfWeekInReserves)
        {
            var departDate = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
            departDate = departDate.Add(dayOfWeekInReserves.DepartTime);
            return departDate;
        }
    }
}

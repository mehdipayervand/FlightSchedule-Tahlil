using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}

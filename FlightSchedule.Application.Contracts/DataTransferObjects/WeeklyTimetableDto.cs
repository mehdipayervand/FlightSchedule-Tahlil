using System;

namespace FlightSchedule.Application.Contracts.DataTransferObjects
{
    public class WeeklyTimetableDto
    {
        public DayOfWeek DayOfWeek { get; private set; }
        public TimeSpan DepartTime { get; private set; }

        public WeeklyTimetableDto(DayOfWeek dayOfWeek, TimeSpan departTime)
        {
            DayOfWeek = dayOfWeek;
            DepartTime = departTime;
        }
    }
}

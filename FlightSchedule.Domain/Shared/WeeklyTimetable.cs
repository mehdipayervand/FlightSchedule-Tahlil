﻿using System;

namespace FlightSchedule.Domain.Shared
{
    public class WeeklyTimetable
    {
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan DepartTime { get; set; }
    }
}
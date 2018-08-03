﻿using System;

namespace FlightSchedule.Application.Contracts.DataTransferObjects
{
    public class WeeklyTimetableDto
    {
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan DepartTime { get; set; }
    }
}

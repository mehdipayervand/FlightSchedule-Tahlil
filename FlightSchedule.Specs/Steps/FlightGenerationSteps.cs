using System;
using System.Collections.Generic;
using FlightSchedule.Domain.Model;
using FlightSchedule.Domain.Shared;
using FlightSchedule.Specs.Endpoints;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace FlightSchedule.Specs.Steps
{
    [Binding]
    public class FlightGenerationSteps
    {
        [Given(@"I have reserved a charter flight from airline with following information")]
        public void GivenIHaveReservedACharterFlightFromAirlineWithFollowingInformation(Table table)
        {
            //create a schedule
        }
        
        [Given(@"I have entered the following weekly flight schedule")]
        public void GivenIHaveEnteredTheFollowingWeeklyFlightSchedule(Table table)
        {
            //Add timetable to schedule
        }
        
        [When(@"I press generate")]
        public void WhenIPressGenerate()
        {
            //Post schedule
        }
        
        [Then(@"The following flights should be generated")]
        public void ThenTheFollowingFlightsShouldBeGenerated(Table table)
        {
            //get by 'flight number' in order to assert
        }
    }
}

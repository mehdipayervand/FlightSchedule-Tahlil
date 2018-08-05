﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace FlightSchedule.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class FlightGenerationFeature : Xunit.IClassFixture<FlightGenerationFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "FlightGeneration.feature"
#line hidden
        
        public FlightGenerationFeature(FlightGenerationFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FlightGeneration", "\tIn order to generate my flights easily & time-efficient\r\n\tAs a agency manager\r\n\t" +
                    "I want to be able to generate flights in batch from schedule", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Generate flights from weekly flight plan")]
        [Xunit.TraitAttribute("FeatureTitle", "FlightGeneration")]
        [Xunit.TraitAttribute("Description", "Generate flights from weekly flight plan")]
        [Xunit.TraitAttribute("Category", "api")]
        public virtual void GenerateFlightsFromWeeklyFlightPlan()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate flights from weekly flight plan", new string[] {
                        "api"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Aircraft",
                        "FlightNo",
                        "Origin",
                        "Destination",
                        "StartReserveDate",
                        "EndReserveDate"});
            table1.AddRow(new string[] {
                        "Airbus-W350",
                        "WS-2040",
                        "IKA",
                        "FRA",
                        "2018-03-17",
                        "2018-04-01"});
#line 8
 testRunner.Given("I have reserved a charter flight from airline with following information", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Day",
                        "DepartTime"});
            table2.AddRow(new string[] {
                        "Monday",
                        "08:00"});
            table2.AddRow(new string[] {
                        "Wednesday",
                        "17:00"});
#line 11
 testRunner.And("I have entered the following weekly flight schedule", ((string)(null)), table2, "And ");
#line 15
  testRunner.When("I press generate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "DepartDate",
                        "Aircraft",
                        "FlightNo",
                        "Origin",
                        "Destination"});
            table3.AddRow(new string[] {
                        "2018-03-19",
                        "Airbus-W350",
                        "WS-2040",
                        "IKA",
                        "FRA"});
            table3.AddRow(new string[] {
                        "2018-03-21",
                        "Airbus-W350",
                        "WS-2040",
                        "IKA",
                        "FRA"});
            table3.AddRow(new string[] {
                        "2018-03-26",
                        "Airbus-W350",
                        "WS-2040",
                        "IKA",
                        "FRA"});
            table3.AddRow(new string[] {
                        "2018-03-28",
                        "Airbus-W350",
                        "WS-2040",
                        "IKA",
                        "FRA"});
#line 16
  testRunner.Then("The following flights should be generated", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                FlightGenerationFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                FlightGenerationFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion

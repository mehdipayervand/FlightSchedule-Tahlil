#tool "nuget:?package=xunit.runner.console"

Task("Build")
    .Does(()=>{
        MSBuild("../FlightSchedule.sln", configurator =>
            configurator.SetConfiguration("Release")
                .SetVerbosity(Verbosity.Minimal)
                .UseToolVersion(MSBuildToolVersion.VS2015)
                .SetMSBuildPlatform(MSBuildPlatform.x86)
                .SetPlatformTarget(PlatformTarget.MSIL));
});

Task("Run-Unit-Tests")
    .IsDependentOn("Build")
    .Does(()=>{
        var testAssemblies = GetFiles("../**/bin/Release/*.Tests.Unit.dll");
        XUnit2(testAssemblies);
});

RunTarget("Run-Unit-Tests");
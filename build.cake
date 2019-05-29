// Include tools to run external components
#tool "nuget:?package=xunit.runner.console"

// Create arguement to run on target
var target = Argument("target", "default");

// Compose tasks to run
Task("default")
.IsDependentOn("test");

Task("build")
.Does(() => { 
    MSBuild("./Cake.sln");
 });

 Task("test")
 .IsDependentOn("build")
.Does(() => { 
    DotNetCoreTool("./Cake-Tests/bin/Debug/netcoreapp2.1/Cake-Tests.dll");
 });

RunTarget(target);
# Cake-Script

Cake (C# Make) is a build automation tool for .NET. It allows you to write C# to run various Tasks that you would likely find as build steps on your build server. Such as compile code (msbuild), run unit tests (xunit, nunit, mstests), creating nuget packages and create deployments.

## Familiar

Cake is built on top of the Roslyn compiler which enables you to write your build scripts in C#.

## Cross platform

Cake is available on Windows, Linux and macOS.

## Cross runtime

Cake runs on .NET, .NET Core and Mono.

## Reliable

Regardless if you're building on your own machine, or building on a CI system such as AppVeyor, Azure DevOps, TeamCity, TFS or Jenkins, Cake is built to behave in the same way.

## Batteries included

Cake supports the most common tools used during builds such as MSBuild, .NET Core CLI, MSTest, xUnit, NUnit, NuGet, ILMerge, WiX and SignTool out of the box.

## Build Script

First thing you need to do is get the Cake build script that is written in PowerShell. From your project folder, run the following command to download the latest PowerShell Ssript (build.ps1)

```
Invoke-WebRequest http://cakebuild.net/download/bootstrapper/windows -OutFile build.ps1
```

## Create cake script for Build and Unit test

```
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
    DotNetCoreTool("./Cake-Tests/bin/Debug/netcoreapp2.1/Cake-Tests.dll", "xunit");
 });

RunTarget(target);
```

## Reference

https://codeopinion.com/automating-builds-with-cake-c-make/<br/>
https://cakebuild.net/

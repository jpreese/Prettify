var target = Argument("target", "Default");

const string solution = "Prettify.sln";
const string project = "./Prettify/Prettify.csproj";
const string testProject = "./PrettifyTests/PrettifyTests.csproj";

Task("RestoreSolution")
    .Does(() => 
    {
        DotNetCoreRestore(solution);
    });

Task("BuildProject")
    .IsDependentOn("RestoreSolution")
    .Does(() =>
    {
        DotNetCoreBuild(project);
    });

Task("RunTests")
    .IsDependentOn("BuildProject")
    .Does(() =>
    {
        DotNetCoreTest(testProject);
    });

Task("Default")
    .IsDependentOn("RunTests")
    .Does(() => { });

RunTarget(target);
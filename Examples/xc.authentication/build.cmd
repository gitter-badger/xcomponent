@echo off

set /p xcversion=<../xcversion.txt

pushd %~dp0

..\Tools\NuGet.exe update -self

..\Tools\NuGet.exe install FAKE -ConfigFile ..\Tools\Nuget.Config -ExcludeVersion -OutputDirectory ..\packages -Version 4.10.3
..\Tools\NuGet.exe install XComponent.Community -ConfigFile ..\Tools\Nuget.Config -ExcludeVersion -OutputDirectory ..\packages -Version %xcversion%
..\Tools\NuGet.exe restore authenticationservice\Authentication\Authentication.sln
..\Tools\NuGet.exe restore authenticationservice\AuthenticationConsoleApp\AuthenticationConsoleApp.sln

set encoding=utf-8
..\packages\FAKE\tools\FAKE.exe build.fsx All

popd
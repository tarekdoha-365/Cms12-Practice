Hello,

This project is about setting up an Episerver Project using the CLI tool, IIS, VS2022, dotnet Core 5 MVC, Razor Pages.

Documentation:

# Points:
## Setup environment base solution
## Setup IIS



### Setup environment base solution

    Install Episerver Template tool
    
    dotnet new -i EpiServer.Net.Templates --nuget-source https://nuget.optimizely.com/feed/packages.svc/ --force

    To Check in the CMS: dotnet new --list to check if the Template is added

    Install Episerver CLI tool

    dotnet tool install EpiServer.Net.Cli --global --add-source https://nuget.optimizely.com/feed/packages.svc/ --force
    

     dotnet new epicmsempty --name ProjectName --force
     dotnet-episerver create-cms-database ProjectName.csproj -S TD -U sa -P "YourPassword"
     EPiServer.Net.Cli update-database ProjectName.csproj


### Setup IIS





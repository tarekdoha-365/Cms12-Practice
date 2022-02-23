Hello,

This project is about setting up an Episerver Project using the CLI tool, IIS, VS2022, dotnet Core 5 MVC, Razor Pages.

Documentation:

# Points:
## Setup environment base solution
## IIS Setup



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

   Enable Windows feature tools requirments, Add the Host name in etc.
   IIS Create new website, Application Pools --> Project name --> Advanced settings --> .Net CLR Version Select No Managed Code. Edit Permission -->Security Permission to Add the Users.
   dotnet publish for later point to add to the IIS website.




# ASP.NET MVC Core 2 project - Microsoft .NET Core SDK - 2.0.3
This project intent to show how to setup a solution using n-tiers architecture using Entity Framework.
.Net Core is used as framework for the solution. The IDE used for this example was VS Code.
The model for this project is a "Netflix" example having only two entities: Movie and Category

## Prerequisites
- Microsoft .NET Core SDK - 2.0.3
- Visual Studio Code

## Steps

1. Create the solution:
~~~
dotnet new sln --name Netflix
~~~
2. Create presentarion tier (ASP.NET MVC Core2 - Angular project)
~~~
dotnet new angular --name Netflix.Web --framework netcoreapp2.0
~~~
3. Install front end modules
~~~
cd Netflix.Web

npm install

cd ..
~~~
4. Create business tier (Class library project)
~~~
dotnet new classlib --name Netflix.Business --framework netcoreapp2.0
~~~
5. Create data tier (Class library project)
~~~
dotnet new classlib --name Netflix.Data --framework netcoreapp2.0
~~~
6.  Create model tier (Class library project)
~~~
dotnet new classlib --name Netflix.Model --framework netcoreapp2.0
~~~
7. Add references to presentation tier
~~~
dotnet add Netflix.Web/Netflix.Web.csproj reference Netflix.Business/Netflix.Business.csproj

dotnet add Netflix.Web/Netflix.Web.csproj reference Netflix.Model/Netflix.Model.csproj
~~~
8. Add references to business tier
~~~
dotnet add Netflix.Business/Netflix.Business.csproj reference Netflix.Data/Netflix.Data.csproj

dotnet add Netflix.Business/Netflix.Business.csproj reference Netflix.Model/Netflix.Model.csproj
~~~
9. Add references to data tier
~~~
dotnet add Netflix.Data/Netflix.Data.csproj reference Netflix.Model/Netflix.Model.csproj
~~~
10. Add tier projects to solution
~~~
dotnet sln Netflix.sln add Netflix.Web/Netflix.Web.csproj Netflix.Business/Netflix.Business.csproj Netflix.Data/Netflix.Data.csproj Netflix.Model/Netflix.Model.csproj
~~~
11. Restore references to all projects in the solution
~~~
dotnet restore
~~~
12. Run the project
~~~
cd Netflix.Web
dotnet run
~~~

## Add Entity Framework separating entities and data access
https://garywoodfine.com/using-ef-core-in-a-separate-class-library-project/
https://docs.microsoft.com/en-us/ef/core/get-started/netcore/new-db-sqlite


1. Install Entity Framework to data tier
~~~
cd Netflix.Data
dotnet add package Microsoft.EntityFrameworkCore --version 2.0.1
~~~

2. Create a class name ApiContext in data tier
~~~
using System;
using Microsoft.EntityFrameworkCore;

namespace Netflix.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext (DbContextOptions<ApiContext> options) : base(options){ }
    }
}
~~~

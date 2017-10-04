# ASP.NET MVC Core project - Microsoft .NET Core SDK - 2.0.0
This project intent to show how to setup a web project using n-tiers architecture using Entity Framework.
.Net Core is used as framework for the solution. The IDE used for this example was VS Code.
The model for this project is a "Netflix" example having only two entities: Movie and Category

## Prerequisites
- Microsoft .NET Core SDK - 2.0.0
- Visual Studio Code

## Steps

1. Create the solution:
~~~
dotnet new sln --name Netflix
~~~

2. Create presentarion tier (ASP.NET MVC project)
~~~
dotnet new mvc --name Netflix.Presentation --framework netcoreapp2.0
~~~

3. Create business tier (Class library project)
~~~
dotnet new classlib --name Netflix.Business --framework netcoreapp2.0
~~~

4. Create data tier (Class library project)
~~~
dotnet new classlib --name Netflix.Data --framework netcoreapp2.0
~~~

5.  Create model tier (Class library project)
~~~
dotnet new classlib --name Netflix.Model --framework netcoreapp2.0
~~~

6. Add references to presentation tier
~~~
dotnet add Netflix.Presentation/Netflix.Presentation.csproj reference Netflix.Business/Netflix.Business.csproj

dotnet add Netflix.Presentation/Netflix.Presentation.csproj reference Netflix.Model/Netflix.Model.csproj
~~~

7. Add references to business tier
~~~
dotnet add Netflix.Business/Netflix.Business.csproj reference Netflix.Data/Netflix.Data.csproj

dotnet add Netflix.Business/Netflix.Business.csproj reference Netflix.Model/Netflix.Model.csproj
~~~

8. Add references to data tier
~~~
dotnet add Netflix.Data/Netflix.Data.csproj reference Netflix.Model/Netflix.Model.csproj
~~~

9. Add tier projects to solution
~~~
dotnet sln Netflix.sln add Netflix.Presentation/Netflix.Presentation.csproj Netflix.Business/Netflix.Business.csproj Netflix.Data/Netflix.Data.csproj Netflix.Model/Netflix.Model.csproj
~~~

10. Restore references to all projects in the solution
~~~
dotnet restore
~~~

11. Run the project
~~~
cd Netflix.Presentation
dotnet run
~~~

## Add Entity Framework separating entities and data access
[Reference](https://garywoodfine.com/using-ef-core-in-a-separate-class-library-project/)

1. Install Entity Framework to data tier
~~~
cd Netflix.Data
dotnet add package Microsoft.EntityFrameworkCore --version 2.0.0
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

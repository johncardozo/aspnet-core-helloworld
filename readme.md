# Pasos para crear el proyecto de Netflix

1. Crear la solución:
~~~
dotnet new sln --name Netflix
~~~

2. Crear la capa de presentación con un proyecto ASP.NET MVC
~~~
dotnet new mvc --name Netflix.Presentation
~~~

3. Crear la capa de negocio con un proyecto de librería de clases
~~~
dotnet new classlib --name Netflix.Business
~~~

4. Crear la capa de datos con un proyecto de librería de clases
~~~
dotnet new classlib --name Netflix.Data
~~~

5. Crear la capa de modelo con un proyecto de librería de clases
~~~
dotnet new classlib --name Netflix.Model
~~~

6. Crear las referencias de Presentacion
~~~
dotnet add Netflix.Presentation/Netflix.Presentation.csproj reference Netflix.Business/Netflix.Business.csproj

dotnet add Netflix.Presentation/Netflix.Presentation.csproj reference Netflix.Model/Netflix.Model.csproj
~~~

7. Crear las referencias de Business
~~~
dotnet add Netflix.Business/Netflix.Business.csproj reference Netflix.Data/Netflix.Data.csproj

dotnet add Netflix.Business/Netflix.Business.csproj reference Netflix.Model/Netflix.Model.csproj
~~~

8. Crear las referencias de Data
~~~
dotnet add Netflix.Data/Netflix.Data.csproj reference Netflix.Model/Netflix.Model.csproj
~~~

9. Se agregan los proyectos a la solución
~~~
dotnet sln Netflix.sln add Netflix.Presentation/Netflix.Presentation.csproj Netflix.Business/Netflix.Business.csproj Netflix.Data/Netflix.Data.csproj Netflix.Model/Netflix.Model.csproj
~~~

10. Restaurar las librerías y referencias de la solucion
~~~
dotnet restore
~~~

11. Ejecutar la capa de presentación
~~~
cd Netflix.Presentation
dotnet run
~~~

## EF en proyectos separados para Data y Model
[Referencia en Internet](https://garywoodfine.com/using-ef-core-in-a-separate-class-library-project/)


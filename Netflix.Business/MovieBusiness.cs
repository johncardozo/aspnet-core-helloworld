using System;
using System.Linq;
using System.Collections.Generic;
using Netflix.Model;

namespace Netflix.Business
{
    public class MovieBusiness
    {
        public static List<Movie> GetAll(){
            List<Movie> lista = new List<Movie>();
            lista.Add(new Movie(1, "Lethal Weapon"));
            lista.Add(new Movie(2, "Die Hard"));
            lista.Add(new Movie(3, "The Last boy scout"));
            lista.Add(new Movie(4, "Heat"));
            lista.Add(new Movie(5, "Matrix"));

            return lista;            
        }

        public static List<Movie> GetGreaterThanNumber(int number){

            List<Movie> lista = new List<Movie>();
            lista.Add(new Movie(1, "Lethal Weapon"));
            lista.Add(new Movie(2, "Die Hard"));
            lista.Add(new Movie(3, "The Last boy scout"));
            lista.Add(new Movie(4, "Heat"));
            lista.Add(new Movie(5, "Matrix"));

            var resultado = (List<Movie>) lista.Where(p => p.Id >= number).ToList();

            return resultado;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Netflix.Presentation.Models;
using Netflix.Model;
using Netflix.Business;


namespace Netflix.Presentation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            // Get all movies
            List<Movie> lista = MovieBusiness.GetGreaterThanNumber(3);
            
            // Create one movie
            Movie m = new Movie(1, "Highlander");
            m.Id = 6;
            m.Name = "Braveheart";
            
            // Send data to view
            ViewData["movie"] = m;
            ViewData["lista"] = lista;
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercise2.Models;

namespace Exercise2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { id = 1, Name = "Wiro Sableng"},
                new Movie { id = 2, Name = "Petani Sukses"}
            };
        }
    }
}
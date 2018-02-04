using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMVC.Models;

namespace VidlyMVC.Controllers
{
    public class MoviesController : Controller
    {
        public static List<Movie> Movies = new List<Movie>() { new Movie() { Id = 1, Name = "Ninnu kori" }, new Movie() { Id = 2, Name = "MCA" } };

        public ActionResult Index()
        {
            return View(Movies);
        }

        public ActionResult Details(int id)
        {
            return View(Movies.Single(x => x.Id == id));
        }
    }
}
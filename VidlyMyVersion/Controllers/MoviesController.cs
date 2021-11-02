using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMyVersion.Models;
using VidlyMyVersion.ViewModels;

namespace VidlyMyVersion.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek!"
            };


            var customers = new List<Customer>
            {
                new Customer{ Name="Customer 1" },
                new Customer{ Name="Customer 1"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}
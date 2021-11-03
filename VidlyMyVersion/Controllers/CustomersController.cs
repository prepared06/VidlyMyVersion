using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMyVersion.Models;
using VidlyMyVersion.ViewModels;


namespace VidlyMyVersion.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer{Name = "Ivan Guy", Id = 1},
                new Customer{Name = "George MCJhony", Id = 2},
                new Customer{Name = "Gordon Freeman", Id = 3}
            };
            var viewModel = new CustomersListViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("Customers/Details/{Id}")]
        public ActionResult Details(int Id)
        {
            
            var customers = new List<Customer>
            {
                new Customer{Name = "Ivan Guy", Id = 1},
                new Customer{Name = "George MCJhony", Id = 2},
                new Customer{Name = "Gordon Freeman", Id = 3}
            };


            var customer = customers[Id-1];

            return View(customer);
        }
    }
}
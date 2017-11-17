using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LicencePlateFinder.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LicencePlateFinder.Controllers
{
    public class Licence_plateController : Controller
    {
        Licence_plateRepository licence_PlateRepository;

        public Licence_plateController(Licence_plateRepository licence_PlateRepository)
        {
            this.licence_PlateRepository = licence_PlateRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}

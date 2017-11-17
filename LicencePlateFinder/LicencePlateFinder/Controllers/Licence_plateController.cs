using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LicencePlateFinder.Repositories;
using LicencePlateFinder.Models;
using LicencePlateFinder.ViewModels.PlateViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LicencePlateFinder.Controllers
{
    public class Licence_plateController : Controller
    {
        Licence_plateRepository licence_PlateRepository;
        PlateViewModel plateViewModel;

        public Licence_plateController(PlateViewModel plateViewModel, Licence_plateRepository licence_PlateRepository)
        {
            this.plateViewModel = plateViewModel;
            this.licence_PlateRepository = licence_PlateRepository;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/list")]
        [HttpGet]
        public IActionResult Index(PlateViewModel plateViewModel)
        {
            var listOfMatchingPlates = licence_PlateRepository.SearchPlates(plateViewModel.Licence_plate.Plate);
            return View(plateViewModel);
        }

        [Route("api/searchPlate")]
        [HttpGet]
        public IActionResult ApiSearch([FromQuery] string q)
        {
            if (q.Length != 0)
            {
                return Json(licence_PlateRepository.ApiSearchQueryByPlate(q));
            }
            else
            {
                return NotFound();
            }
        }

        [Route("searchPlate")]
        [HttpGet]
        public IActionResult Index([FromQuery] string q)
        {
            if (q.Length != 0)
            {
                var list = licence_PlateRepository.ApiSearchQueryByPlate(q);
                return View(list);
            }
            else
            {
                return View();
            }
        }

        [Route("api/searchPolice")]
        [HttpGet]
        public IActionResult ApiSearch([FromQuery] int? police)
        {
            if (!(police == null))
            {
                return Json(licence_PlateRepository.ApiSearchQueryByPolice((int)police));
            }
            else
            {
                return NotFound();
            }
        }

        [Route("api/searchDiplomat")]
        [HttpGet]
        public IActionResult ApiSearch3([FromQuery] int? diplomat)
        {
            if (!(diplomat == null))
            {
                return Json(licence_PlateRepository.ApiSearchQueryByDiplomat((int)diplomat));
            }
            else
            {
                return NotFound();
            }
        }

        [Route("api/search/{brand}")]
        [HttpGet]
        public IActionResult ApiSearchBrand([FromRoute] string brand)
        {
            if (brand.Length != 0)
            {
                return Json(licence_PlateRepository.ApiSearchBrand(brand));
            }
            else
            {
                return NotFound();
            }
        }
    }
}

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

        [Route("")]
        [HttpPost]
        public IActionResult Index(PlateViewModel plateViewModel)
        {
            //if (ModelState.IsValid)
            //{
            //    redditpostRepository.AddNew(newPost);
            //    return RedirectToAction("ListOfSearches");

            var listOfMatchingPlates = licence_PlateRepository.SearchPlates(plateViewModel.Licence_plate.Plate);
            return View(plateViewModel);
            
            //}
            //else
            //{
            //    return View("Add");
            //}
        }
    }
}

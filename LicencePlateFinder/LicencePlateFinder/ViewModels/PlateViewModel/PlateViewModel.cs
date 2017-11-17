using LicencePlateFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LicencePlateFinder.ViewModels.PlateViewModel
{
    public class PlateViewModel
    {
        public Licence_plate Licence_plate { get; set; } = new Licence_plate();
        public List<Licence_plate> PlateList = new List<Licence_plate>();
    }
}

using LicencePlateFinder.Entities;
using LicencePlateFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LicencePlateFinder.Repositories
{
    public class Licence_plateRepository
    {
        Licence_plateContext licence_PlateContext;

        public Licence_plateRepository(Licence_plateContext licence_PlateContext)
        {
            this.licence_PlateContext = licence_PlateContext;
        }

        public List<Licence_plate> SearchPlates(string LicencePlateFromSearchBox)
        {
            //            return licence_PlateContext.Licence_plates.Where(p => p.Plate.Contains("HUE-076")).ToList();
            return licence_PlateContext.Licence_plates.ToList();
        }

        public List<Licence_plate> ApiSearchQueryByPlate(string plate)
        {
            return licence_PlateContext.Licence_plates.Where(p => p.Plate.Contains(plate)).ToList();
        }

        public List<Licence_plate> ApiSearchQueryByPolice(int police)
        {
            if (police == 1)
            {
                return licence_PlateContext.Licence_plates.Where(p => p.Plate.StartsWith("RB")).ToList();
            }
            else
            {
                return licence_PlateContext.Licence_plates.Where(p => !p.Plate.StartsWith("RB")).ToList();
            }
        }

        public List<Licence_plate> ApiSearchBrand(string brand)
        {
            return licence_PlateContext.Licence_plates.Where(p => p.Car_brand == brand).ToList();
        }
    }
}

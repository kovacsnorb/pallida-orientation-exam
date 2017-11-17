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
            return licence_PlateContext.Licence_plates.Where(p => p.Plate.Contains(LicencePlateFromSearchBox)).ToList();
        }
    }
}

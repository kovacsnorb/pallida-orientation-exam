using LicencePlateFinder.Entities;
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
    }
}

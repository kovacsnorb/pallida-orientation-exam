using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using LicencePlateFinder.Models;

namespace LicencePlateFinder.Entities
{
    public class Licence_plateContext : DbContext
    {
        public Licence_plateContext(DbContextOptions<Licence_plateContext> options) : base(options)
        {
        }

        public DbSet<Licence_plate> Licence_plates { get; set; }
    }
}

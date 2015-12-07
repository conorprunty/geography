using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Geography.Models
{
    public class GeographyModelContext : DbContext
    {
        public GeographyModelContext()
            : base("GeographyModelContext")
        {
           

        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Feature> Features { get; set; }

        public DbSet<Language> Languages { get; set; }



    }
}
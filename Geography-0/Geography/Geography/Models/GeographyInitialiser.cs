using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Geography.Models;

namespace Geography
{
 public class GeographyInitializer : System.Data.Entity.
DropCreateDatabaseAlways<GeographyModelContext>
 {
 protected override void Seed(GeographyModelContext context)
 {
 var _countries = new List<Country>
 {
 new Country{Name="Ireland",Population="1.26m"},
 new Country{Name="England",Population="4.4m"},
 new Country{Name="France",Population="1.4m"},
 new Country{Name="Brazil",Population="5.4m"},
 new Country{Name="Sweden",Population="3.9m"},
 new Country{Name="New Zealand",Population="3.9m"},
 new Country{Name="Germany",Population="4.4m"},
 new Country{Name="Australia",Population="2.8m"},
 new Country{Name="Japan",Population="8.8m"},
 new Country{Name="USA",Population="3.8m"},
 new Country{Name="Canada",Population="7.8m"},
 new Country{Name="Italy",Population="3.8m"},
 new Country{Name="Spain",Population="3.1m"},
 new Country{Name="Portugal",Population="2.9m"},
 new Country{Name="Poland",Population="3.6m"},
 new Country{Name="Russia",Population="1.7m"},
 new Country{Name="Mexico",Population="8.7m"},
 new Country{Name="Chile",Population="4.9m"},
 new Country{Name="Argentina",Population="2.06m"},
 new Country{Name="China",Population="7.6m"},

 };
 _countries.ForEach(s => context.Countries.Add(s));
 context.SaveChanges();

 var _cities = new List<City>
 {
 new City{Name="Dublin",Size=1243},
 new City{Name="Berlin",Size=435345},
 new City{Name="Paris",Size=645456},
 new City{Name="London",Size=45645},
 new City{Name="Chicago",Size=234345},
 new City{Name="Cork",Size=7657},
 new City{Name="Manchester",Size=567567},
 new City{Name="Lisbon",Size=567567},
 new City{Name="Madrid",Size=76575},
 new City{Name="Las Vegas",Size=567567},


 };
 _cities.ForEach(t => context.Cities.Add(t));
 context.SaveChanges();

 var _features = new List<Feature>
 {
 new Feature{Name="Mountain",Location="Ireland"},
 new Feature{Name="River",Location="England"},
 new Feature{Name="Lake",Location="Scotland"},
 new Feature{Name="Skyscraper",Location="Wales"},
 new Feature{Name="Currency",Location="Spain"},


 };
 _features.ForEach(u => context.Features.Add(u));
 context.SaveChanges();

 var _languages = new List<Language>
 {
 new Language{Name="English",NumberOfUsers="1.23m"},
 new Language{Name="Franch",NumberOfUsers="6.35m"},
 new Language{Name="Irish",NumberOfUsers="3.56m"},
 new Language{Name="Spanish",NumberOfUsers="4.22m"},
 new Language{Name="German",NumberOfUsers="4.22m"},
 new Language{Name="Japanese",NumberOfUsers="1.99m"},
 new Language{Name="Chinese",NumberOfUsers="1.76bn"},
 new Language{Name="Portuguese",NumberOfUsers="3.56m"},
 new Language{Name="Swedish",NumberOfUsers="9.44m"},
 new Language{Name="Norwegian",NumberOfUsers="77.88m"},


 };
 _languages.ForEach(v => context.Languages.Add(v));
 context.SaveChanges();

 }
 }
}
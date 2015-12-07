using Geography.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Geography
{
    /// <summary>
    /// Summary description for GeographyService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GeographyService : System.Web.Services.WebService
    {

        private GeographyModelContext db = new GeographyModelContext();

        [WebMethod]

        public string[] GetCitiesByName(string namePart)
        {
            List<string> cities = new List<string>();

            if (namePart != "")
            {
                foreach (var city in db.Cities
                    .Where(a => a.Name.Contains(namePart))
                    .ToList())
                {
                    cities.Add(city.Name);
                }
            }
            return cities.ToArray();
        }

    }
}

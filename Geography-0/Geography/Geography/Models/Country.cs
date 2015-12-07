using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Geography.Models
{
    public class Country
    {
        private ICollection<City> _cities;

        public Country()
        {
            _cities = new List<City>();
        }

        public int CountryId { get; set; }

        public string Name { get; set; }

        public string Population { get; set; }

        public virtual ICollection<City> Cities
        {
            get { return _cities; }
            set { _cities = value; }
        }

    }
}
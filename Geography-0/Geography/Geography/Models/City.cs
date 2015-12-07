using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Geography.Models
{
    public class City
    {
        private ICollection<Country> _countries;

        public City()
        {
            _countries = new List<Country>();
        }

        public int CityId { get; set; }

        public string Name { get; set; }

        public int Size { get; set; }

        public virtual ICollection<Country> Countries
        {
            get { return _countries; }
            set { _countries = value; }
        }


    }
}
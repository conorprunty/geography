using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Geography.Models
{
    public class Feature
    {
        private ICollection<Country> _countries;

        public Feature()
        {
            _countries = new List<Country>();
        }

        public int FeatureId { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public virtual ICollection<Country> Countries
        {
            get { return _countries; }
            set { _countries = value; }
        }
    }
}
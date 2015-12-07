using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Geography.Models
{
    public class Language
    {
        private ICollection<Country> _languages;

        public Language()
        {
            _languages = new List<Country>();
        }

        public int LanguageId { get; set; }

        public string Name { get; set; }

        public string NumberOfUsers { get; set; }

        public virtual ICollection<Country> Countries
        {
            get { return _languages; }
            set { _languages = value; }
        }
    }
}
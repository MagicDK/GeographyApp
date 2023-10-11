using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GeographyApp
{
    public class Continent
    {
        public string ContinentName;
        public Image ContinentShape;
        public List<Country> CountryList;
        public List<Country> TerritoryList;
        public List<Country> IslandList;

        public Continent(string name, Image shape)
        {
            this.ContinentName = name;
            this.ContinentShape = shape;
            this.CountryList = new List<Country> {};
            this.TerritoryList = new List<Country> {};
            this.IslandList = new List<Country> {};
        }
    }
}

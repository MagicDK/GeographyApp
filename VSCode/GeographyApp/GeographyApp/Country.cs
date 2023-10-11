using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Controls;

namespace GeographyApp
{
    public class Country : Continent
    {
        public string CountryName;
        public Image CountryFlag;
        public Image CountryShape;
        public Continent CountryContinent;
        public bool isTerritory;
        public bool isIsland;
        public Country(string name, Image flag, Image shape, Continent continent, bool territory, bool island) : base(continent.ContinentName, continent.ContinentShape)
        {
            this.CountryName = name;
            this.CountryFlag = flag;
            this.CountryShape = shape;
            this.CountryContinent = continent;
            this.isTerritory = territory;
            this.isIsland = island;
            if (isTerritory) { continent.TerritoryList.Add(this); }
            else if (isIsland) { continent.IslandList.Add(this); }
            else { continent.CountryList.Add(this); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
namespace GeographyApp
{
    public class Country : Continent
    {
        public string CountryName;
        public BitmapImage CountryFlag;
        public BitmapImage CountryShape;
        public Continent CountryContinent;
        public bool isTerritory;
        public bool isIsland;
        public Country(string name, BitmapImage flag, BitmapImage shape, Continent continent, bool territory, bool island) : base(continent.ContinentName, continent.ContinentShape)
        {
            this.CountryName = name;
            this.CountryFlag = flag;
            this.CountryShape = shape;
            this.CountryContinent = continent;
            this.isTerritory = territory;
            this.isIsland = island;
            if (isIsland) { continent.IslandList.Add(this); }
            if (isTerritory) { continent.TerritoryList.Add(this); }
            else { continent.CountryList.Add(this); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Timers;
using System.Threading;
using System.Windows.Threading;

namespace GeographyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DisplayMainMenu(true);
        }

        public void DisplayMainMenu(bool first_launch)
        {
            Main.Content = new MainMenuPage(first_launch);
        }

        public void DisplayPlaySettings()
        {
            Main.Content = new GameSettingsPage(InitializeCountries());
        }

        private Continent[] InitializeCountries()
        {
            // Continent Association Array
            //----------------------------------
            //   0 - North America
            //   1 - Europe
            //   2 - Africa
            //   3 - South America
            //   4 - Oceania
            //   5 - Asia
            //-----------------------------------

            //Continent Instantiation (Name, Shape)
            //-----------------------------------
            Continent[] Continents = {
                new Continent("North America", new BitmapImage()),
                new Continent("Europe", new BitmapImage()),
                new Continent("Africa", new BitmapImage()),
                new Continent("South America", new BitmapImage()),
                new Continent("Oceania", new BitmapImage()),
                new Continent("Asia", new BitmapImage())
            };
            //----------------------------------

            //Country Instantiation (Name, Flag, Shape, Continent, Territory, Island)
            //----------------------------------
            // North America
            //----------------------------------
            new Country("American Samoa", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/AmericanSamoa.png", UriKind.Relative)), new BitmapImage(), Continents[0], true, true);
            new Country("Anguilla", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/Anguilla.png", UriKind.Relative)), new BitmapImage(), Continents[0], true, true);
            new Country("Antigua Barbuda", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/AntiguaBarbuda.png", UriKind.Relative)), new BitmapImage(), Continents[0], true, true);
            new Country("Bahamas", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/Bahamas.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, true);
            new Country("Barbados", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/Barbados.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, true);
            new Country("Belize", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/Belize.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Bermuda", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/Bermuda.png", UriKind.Relative)), new BitmapImage(), Continents[0], true, true);
            new Country("British Virgin Islands", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/BritishVirginIslands.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Canada", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/Canada.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Cayman Islands", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/CaymanIslands.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Costa Rica", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/CostaRica.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Cuba", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/Cuba.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Dominica", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/Dominica.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Dominican Republic", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/DominicanRepublic.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("El Salvador", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/ElSalvador.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Grenada", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/Grenada.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Guadeloupe", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/Guadeloupe.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Guatemala", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/Guatemala.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Haiti", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/Haiti.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Honduras", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/Honduras.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Jamaica", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/Jamaica.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Mexico", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/Mexico.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Montserrat", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/Montserrat.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Nicaragua", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/Nicaragua.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Panama", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/Panama.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Puerto Rico", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/PuertoRico.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Saint Barthelemy", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/SaintBarthelemy.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Saint Kitts And Nevis", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/SaintKittsAndNevis.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Saint Pierre And Miquelon", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/SaintPierreAndMiquelon.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Saint Vincent And The Grenadines", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/SaintVincentAndTheGrenadines.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("Turks And Caicos Islands", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/TurksAndCaicosIslands.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("United States Virgin Islands", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/UnitedStatesVirginIslands.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            new Country("United States", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/NorthAmerica/UnitedStates.png", UriKind.Relative)), new BitmapImage(), Continents[0], false, false);
            //----------------------------------
            // South America
            //----------------------------------
            new Country("Argentina", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/SouthAmerica/Argentina.png", UriKind.Relative)), new BitmapImage(), Continents[3], false, false);
            new Country("Aruba", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/SouthAmerica/Aruba.png", UriKind.Relative)), new BitmapImage(), Continents[3], false, false);
            new Country("Bolivia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/SouthAmerica/Bolivia.png", UriKind.Relative)), new BitmapImage(), Continents[3], false, false);
            new Country("Bonaire", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/SouthAmerica/Bonaire.png", UriKind.Relative)), new BitmapImage(), Continents[3], false, false);
            new Country("Brazil", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/SouthAmerica/Brazil.png", UriKind.Relative)), new BitmapImage(), Continents[3], false, false);
            new Country("Chile", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/SouthAmerica/Chile.png", UriKind.Relative)), new BitmapImage(), Continents[3], false, false);
            new Country("Colombia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/SouthAmerica/Colombia.png", UriKind.Relative)), new BitmapImage(), Continents[3], false, false);
            new Country("Curacao", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/SouthAmerica/Curacao.png", UriKind.Relative)), new BitmapImage(), Continents[3], false, false);
            new Country("Ecuador", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/SouthAmerica/Ecuador.png", UriKind.Relative)), new BitmapImage(), Continents[3], false, false);
            new Country("Falkland Islands", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/SouthAmerica/FalklandIslands.png", UriKind.Relative)), new BitmapImage(), Continents[3], false, false);
            new Country("French Guiana", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/SouthAmerica/FrenchGuiana.png", UriKind.Relative)), new BitmapImage(), Continents[3], false, false);
            new Country("Guyana", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/SouthAmerica/Guyana.png", UriKind.Relative)), new BitmapImage(), Continents[3], false, false);
            new Country("Paraguay", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/SouthAmerica/Paraguay.png", UriKind.Relative)), new BitmapImage(), Continents[3], false, false);
            new Country("Peru", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/SouthAmerica/Peru.png", UriKind.Relative)), new BitmapImage(), Continents[3], false, false);
            new Country("Saint Lucia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/SouthAmerica/SaintLucia.png", UriKind.Relative)), new BitmapImage(), Continents[3], false, false);
            new Country("Suriname", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/SouthAmerica/Suriname.png", UriKind.Relative)), new BitmapImage(), Continents[3], false, false);
            new Country("Trinidad And Tobago", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/SouthAmerica/TrinidadAndTobago.png", UriKind.Relative)), new BitmapImage(), Continents[3], false, false);
            new Country("Uruguay", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/SouthAmerica/Uruguay.png", UriKind.Relative)), new BitmapImage(), Continents[3], false, false);
            new Country("Venezuela", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/SouthAmerica/Venezuela.png", UriKind.Relative)), new BitmapImage(), Continents[3], false, false);
            //----------------------------------
            // Oceania
            //----------------------------------
            new Country("Australia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/Australia.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Christmas Island", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/ChristmasIsland.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Cocos Islands", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/CocosIslands.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Cook Islands", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/CookIslands.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Fiji", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/Fiji.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("French Polynesia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/FrenchPolynesia.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Guam", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/Guam.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Kiribati", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/Kiribati.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Marshall Islands", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/MarshallIslands.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Micronesia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/Micronesia.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Nauru", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/Nauru.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("New Caledonia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/NewCaledonia.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("New Zealand", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/NewZealand.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Niue", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/Niue.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Norfolk Island", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/NorfolkIsland.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Northern Mariana Islands", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/NorthernMarianaIslands.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Palau", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/Palau.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Papa New Guinea", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/PapaNewGuinea.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Pitcairn Islands", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/PitcairnIslands.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Samoa", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/Samoa.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Soloman Islands", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/SolomanIslands.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Tokelau", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/Tokelau.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Tonga", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/Tonga.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Tuvalu", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/Tuvalu.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Vanuatu", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/Vanuatu.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            new Country("Wallis And Futuna", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Oceania/WallisAndFutuna.png", UriKind.Relative)), new BitmapImage(), Continents[4], false, false);
            //----------------------------------
            // Europe
            //----------------------------------
            new Country("Aland", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Aland.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Albania", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Albania.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Andorra", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Andorra.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Austria", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Austria.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Belarus", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Belarus.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Belgium", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Belgium.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Bosnia Herzegovina", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/BosniaHerzegovina.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("British Indian Ocean Territory", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/BritishIndianOceanTerritory.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Bulgaria", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Bulgaria.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Croatia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Croatia.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Cyprus", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Cyprus.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Czech", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Czech.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Denmark", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Denmark.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("England", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/England.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Estonia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Estonia.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Faroe Islands", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/FaroeIslands.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Finland", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Finland.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("France", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/France.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Georgia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Georgia.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Germany", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Germany.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Gibraltar", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Gibraltar.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Great Britain", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/GreatBritain.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Greece", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Greece.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Greenland", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Greenland.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Guernsey", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Guernsey.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Hungary", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Hungary.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Iceland", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Iceland.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Ireland", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Ireland.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Isle Of Man", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/IsleOfMan.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Italy", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Italy.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Jersey", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Jersey.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Kosovo", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Kosovo.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Latvia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Latvia.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Liechtenstein", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Liechtenstein.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Lithuania", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Lithuania.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Luxembourg", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Luxembourg.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Malta", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Malta.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Martinique", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Martinique.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Moldova", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Moldova.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Monaco", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Monaco.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Montenegro", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Montenegro.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Netherlands", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Netherlands.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("North Macedonia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/NorthMacedonia.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Northern Ireland", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/NorthernIreland.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Norway", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Norway.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Poland", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Poland.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Portugal", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Portugal.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Romania", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Romania.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("San Marino", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/SanMarino.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Scotland", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Scotland.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Serbia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Serbia.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Sint Maarten", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/SintMaarten.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Slovakia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Slovakia.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Slovenia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Slovenia.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("South Georgia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/SouthGeorgia.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Spain", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Spain.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Sweden", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Sweden.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Switzerland", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Switzerland.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Ukraine", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Ukraine.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Vatican City", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/VaticanCity.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            new Country("Wales", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Europe/Wales.png", UriKind.Relative)), new BitmapImage(), Continents[1], false, false);
            //----------------------------------
            // Africa
            //----------------------------------
            new Country("Algeria", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Algeria.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Angola", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Angola.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Benin", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Benin.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Botswana", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Botswana.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Burkina Faso", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/BurkinaFaso.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Burundi", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Burundi.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Cameroon", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Cameroon.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Cape Verde", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/CapeVerde.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Central African Republic", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/CentralAfricanRepublic.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Chad", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Chad.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Comoros", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Comoros.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Congo", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Congo.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Democratic Congo", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/DemocraticCongo.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Djibouti", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Djibouti.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Egypt", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Egypt.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Equatorial Guinea", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/EquatorialGuinea.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Eritrea", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Eritrea.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Eswatini", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Eswatini.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Ethiopia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Ethiopia.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Gabon", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Gabon.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Gambia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Gambia.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Ghana", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Ghana.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Glorioso Islands", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/GloriosoIslands.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Guinea Bissau", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/GuineaBissau.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Guinea", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Guinea.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Ivory Coast", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/IvoryCoast.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Kenya", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Kenya.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Lesotho", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Lesotho.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Liberia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Liberia.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Libya", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Libya.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Madagascar", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Madagascar.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Malawi", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Malawi.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Mali", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Mali.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Mauritania", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Mauritania.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Mauritius", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Mauritius.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Mayotte", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Mayotte.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Morocco", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Morocco.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Mozambique", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Mozambique.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Namibia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Namibia.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Niger", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Niger.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Nigeria", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Nigeria.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Reunion Island", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/ReunionIsland.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Rwanda", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Rwanda.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Sahrawi Arab Democratic Republic", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/SahrawiArabDemocraticRepublic.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Saint Helena", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/SaintHelena.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Sao Tome And Principe", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/SaoTomeAndPrincipe.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Senegal", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Senegal.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Seychelles", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Seychelles.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Sierra Leone", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/SierraLeone.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Somalia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Somalia.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("South Africa", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/SouthAfrica.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("South Sudan", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/SouthSudan.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Sudan", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Sudan.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Tanzania", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Tanzania.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Togo", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Togo.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Tunisia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Tunisia.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Uganda", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Uganda.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Zambia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Zambia.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            new Country("Zimbabwe", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Africa/Zimbabwe.png", UriKind.Relative)), new BitmapImage(), Continents[2], false, false);
            //----------------------------------
            // Asia
            //----------------------------------
            new Country("Afghanistan", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Afghanistan.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Armenia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Armenia.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Azerbaijan", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Azerbaijan.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Bahrain", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Bahrain.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Bangladesh", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Bangladesh.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Bhutan", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Bhutan.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Brunei", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Brunei.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Cambodia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Cambodia.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("China", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/China.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("East Timor", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/EastTimor.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Hong Kong", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/HongKong.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("India", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/India.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Indonesia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Indonesia.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Iran", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Iran.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Iraq", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Iraq.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Israel", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Israel.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Japan", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Japan.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Jordan", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Jordan.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Kazakhstan", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Kazakhstan.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Kuwait", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Kuwait.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Kyrgyzstan", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Kyrgyzstan.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Laos", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Laos.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Lebanon", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Lebanon.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Macau", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Macau.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Malaysia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Malaysia.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Maldives", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Maldives.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Mongolia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Mongolia.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Myanmar", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Myanmar.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Nepal", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Nepal.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("North Korea", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/NorthKorea.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Oman", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Oman.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Pakistan", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Pakistan.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Palestine", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Palestine.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Philippines", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Philippines.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Qatar", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Qatar.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Republic Of China", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/RepublicOfChina.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Russia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Russia.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Saudi Arabia", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/SaudiArabia.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Singapore", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Singapore.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("South Korea", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/SouthKorea.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Sri Lanka", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/SriLanka.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Syria", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Syria.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Tajikistan", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Tajikistan.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Thailand", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Thailand.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Turkey", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Turkey.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Turkmenistan", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Turkmenistan.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("U AE", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/UAE.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Uzbekistan", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Uzbekistan.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Vietnam", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Vietnam.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);
            new Country("Yemen", new BitmapImage(new Uri(@"/GeographyApp;component/Photos/Flags/Asia/Yemen.png", UriKind.Relative)), new BitmapImage(), Continents[5], false, false);

            //---------------------------------- MUST SET INDIVIDUAL FLAG BUILD ACTION TO RESOURCE FOR FLAG TO DISPLAY ---------------------------------
            return Continents;
        }
    }

}

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
            Main.Content = new MainMenuPage();
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
                new Country("American Samoa", new BitmapImage(new Uri(@"/Photos/Flags/NorthAmerica/AmericanSamoa.png", UriKind.RelativeOrAbsolute)), new BitmapImage(), Continents[0], true, true);
                new Country("Anguilla", new BitmapImage(new Uri(@"/Photos/Flags/NorthAmerica/Anguilla.png", UriKind.RelativeOrAbsolute)), new BitmapImage(), Continents[0], true, true);
                new Country("Antigua Barbuda", new BitmapImage(new Uri(@"/Photos/Flags/NorthAmerica/AntiguaBarbuda.png", UriKind.RelativeOrAbsolute)), new BitmapImage(), Continents[0], true, true);
                new Country("Bahamas", new BitmapImage(new Uri(@"/Photos/Flags/NorthAmerica/Bahamas.png", UriKind.RelativeOrAbsolute)), new BitmapImage(), Continents[0], false, true);
            //----------------------------------
            return Continents;
        }
    }

}

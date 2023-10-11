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
            InitializeCountries();
            Main.Content = new MainMenuPage();
        }

        public void DisplayPlaySettings()
        {
            Main.Content = new GameSettingsPage();
        }

        private void InitializeCountries()
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
                new Continent("North America", new Image()),
                new Continent("Europe", new Image()),
                new Continent("Africa", new Image()),
                new Continent("South America", new Image()),
                new Continent("Oceania", new Image()),
                new Continent("Asia", new Image())
            };
            //----------------------------------

            //Country Instantiation (Name, Flag, Shape, Continent, Territory, Island)
            //----------------------------------
                new Country("American Samoa", new Image(), new Image(), Continents[0], true, true);
                new Country("Anguilla", new Image(), new Image(), Continents[0], true, true);
                new Country("Antigua Barbuda", new Image(), new Image(), Continents[0], true, true);
                new Country("Bahamas", new Image(), new Image(), Continents[0], false, true);
            //----------------------------------
        }
    }

}

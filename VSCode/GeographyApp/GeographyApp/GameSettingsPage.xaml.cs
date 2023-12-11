using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GeographyApp
{
    /// <summary>
    /// Interaction logic for GameSettingsPage.xaml
    /// </summary>
    public partial class GameSettingsPage : Page
    {
        int CountriesSelectedCount = 0;
        Continent[] ContinentArr;
        public GameSettingsPage(Continent[] arr)
        {
            InitializeComponent();
            for (int i = 0; i < arr.Count(); i++)
            {
                CountriesSelectedCount += arr[i].CountryList.Count;
            }
            CountriesSelectedLabel.Content = CountriesSelectedCount + " Countries Selected";
            ContinentArr = arr;
            //Image flagtest = new Image();
            //flagtest.Source = arr[0].TerritoryList[0].CountryFlag;
            //flagtest.Width = 500;
            //flagtest.Height = 500;
            //flagtest.IsEnabled = true;
        }
        // Continent Association Array
        //----------------------------------
        //   0 - North America
        //   1 - Europe
        //   2 - Africa
        //   3 - South America
        //   4 - Oceania
        //   5 - Asia
        //-----------------------------------
        private void Checkbox_Click(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            TextBlock textblock = (TextBlock)checkbox.Content;
            if (textblock.Text == "North America")
            {
                if (checkbox.IsChecked == true) { CountriesSelectedCount += ContinentArr[0].CountryList.Count; }
                else { CountriesSelectedCount -= ContinentArr[0].CountryList.Count; }
            }
            else if (textblock.Text == "Europe")
            {
                if (checkbox.IsChecked == true) { CountriesSelectedCount += ContinentArr[1].CountryList.Count; }
                else { CountriesSelectedCount -= ContinentArr[1].CountryList.Count; }
            }
            else if (textblock.Text == "Africa")
            {
                if (checkbox.IsChecked == true) { CountriesSelectedCount += ContinentArr[2].CountryList.Count; }
                else { CountriesSelectedCount -= ContinentArr[2].CountryList.Count; }
            }
            else if (textblock.Text == "South America")
            {
                if (checkbox.IsChecked == true) { CountriesSelectedCount += ContinentArr[3].CountryList.Count; }
                else { CountriesSelectedCount -= ContinentArr[3].CountryList.Count; }
            }
            else if (textblock.Text == "Oceania")
            {
                if (checkbox.IsChecked == true) { CountriesSelectedCount += ContinentArr[4].CountryList.Count; }
                else { CountriesSelectedCount -= ContinentArr[4].CountryList.Count; }
            }
            else if (textblock.Text == "Asia")
            {
                if (checkbox.IsChecked == true) { CountriesSelectedCount += ContinentArr[5].CountryList.Count; }
                else { CountriesSelectedCount -= ContinentArr[5].CountryList.Count; }
            }
            CountriesSelectedLabel.Content = CountriesSelectedCount + " Countries Selected";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (mainWindow != null)
            {
                mainWindow.DisplayMainMenu(false);
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (mainWindow != null)
            {
                mainWindow.DisplayFlagModePage();
            }
        }
    }
}

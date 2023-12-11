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

namespace GeographyApp
{
    /// <summary>
    /// Interaction logic for FlagModePage.xaml
    /// </summary>
    public partial class FlagModePage : Page
    {
        public FlagModePage()
        {
            InitializeComponent();
        }

        private void FlagGuessBoxFocus(object sender, EventArgs e)
        {
            FlagGuessBox.Text = "";
            FlagGuessBox.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void FlagGuessBoxLostFocus(object sender, EventArgs e)
        {
            FlagGuessBox.Text = "Enter Country Name...";
            FlagGuessBox.Foreground = new SolidColorBrush(Colors.LightGray);
        }
    }
}

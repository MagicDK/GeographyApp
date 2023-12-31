﻿using System;
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
using System.IO;

namespace GeographyApp
{
    /// <summary>
    /// Interaction logic for MainMenuPage.xaml
    /// </summary>
    public partial class MainMenuPage : Page
    {
        DispatcherTimer timer1 = new DispatcherTimer();
        public MainMenuPage(bool first_launch)
        {
            InitializeComponent();
            if (first_launch)
            {
                MainMenuUserControls.Opacity = 0;
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = TimeSpan.FromMilliseconds(50);
                timer1.Start();
            }
            else
            {
                MainMenuUserControls.Opacity = 1;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MainMenuUserControls.Opacity == 1)
            {
                timer1.Stop();
            }
            MainMenuUserControls.Opacity += .1;
        }

        // Main Menu User Options
        //--------------------------------------------------------------------------------
        private void PlayButton_Click(object sender, EventArgs e)
        {
            PlayButton.Content = "Flag Mode";
            InfoButton.Content = "Map Mode";
            ExitButton.Content = "Return";
            PlayButton.Click -= PlayButton_Click;
            PlayButton.Click += FlagModeButton_Click;
            InfoButton.Click -= InfoButton_Click;
            InfoButton.Click += MapModeButton_Click;
            ExitButton.Click -= ExitButton_Click;
            ExitButton.Click += ReturnButton_Click;
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
        //---------------------------------------------------------------------------------

        //Play Menu User Options
        //---------------------------------------------------------------------------------
        private void FlagModeButton_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (mainWindow != null) 
            {
                mainWindow.DisplayPlaySettings();
            }
            mainWindow.DisplayPlaySettings();
        }
        private void MapModeButton_Click(object sender, EventArgs e)
        {

        }
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            PlayButton.Content = "Play";
            InfoButton.Content = "Info";
            ExitButton.Content = "Exit";
            PlayButton.Click -= FlagModeButton_Click;
            PlayButton.Click += PlayButton_Click;
            InfoButton.Click -= MapModeButton_Click;
            InfoButton.Click += InfoButton_Click;
            ExitButton.Click -= ReturnButton_Click;
            ExitButton.Click += ExitButton_Click;
        }
        //----------------------------------------------------------------------------------
    }
}

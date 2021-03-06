﻿using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
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
using System.Windows.Shapes;

namespace Activator.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : MetroWindow
    {
        public MainView()
        {
            InitializeComponent();

            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;

            lblTitle.Content = "HOME";
            
            Mouse.OverrideCursor = Cursors.Wait;
            try
            {
                HomePageView home = new HomePageView();
                MenuPage.Content = home;
                CheckStreamProcessorStatus();
            }
            finally
            {
                Mouse.OverrideCursor = null;
            }            
        }

        private void ButtonCloseApplication_Click(object sender, RoutedEventArgs e)
        {
            //CloseConfirmView closeconf = new CloseConfirmView();
            //closeconf.ShowDialog();
            InitDialog();
        }

        private async Task InitDialog()
        {
            var result = await this.ShowMessageAsync("Are you sure want to quit?", "", MessageDialogStyle.AffirmativeAndNegative);
            if (result == MessageDialogResult.Affirmative) Application.Current.Shutdown();
            
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
           
        }

        private void ButtonMenuHome_Click(object sender, RoutedEventArgs e)
        {
            HomePageView home = new HomePageView();
            MenuPage.Content = home;
            lblTitle.Content = "HOME";
            
        }

        private void ButtonMenuPeopleIn_Click(object sender, RoutedEventArgs e)
        {
            PeopleInPageView pin = new PeopleInPageView();
            MenuPage.Content = pin;
            lblTitle.Content = "HISTORY";
            
        }
    

        private void ButtonMenuAllPeople_Click(object sender, RoutedEventArgs e)
        {
            AllPeoplePageView apin = new AllPeoplePageView();
            MenuPage.Content = apin;
            lblTitle.Content = "ALL PEOPLE";
            
        }

        private void ButtonMenuReaders_Click(object sender, RoutedEventArgs e)
        {
            ReadersView readers = new ReadersView();
            MenuPage.Content = readers;
            lblTitle.Content = "READERS";
            
        }

        private void ButtonMenuCameras_Click(object sender, RoutedEventArgs e)
        {
            CamerasPageView cams = new CamerasPageView();
            MenuPage.Content = cams;
            lblTitle.Content = "CAMERAS";
            
        }


        private void ButtonMenuGetHelp_Click(object sender, RoutedEventArgs e)
        {
            GetHelpPageView gethelp = new GetHelpPageView(); /* check*/
            MenuPage.Content = gethelp;
            lblTitle.Content = "GET HELP";

        }

        private void CheckStreamProcessorStatus()
        {
            Mouse.OverrideCursor = Cursors.Wait;
            try
            {
                if (!Models.Starter.ListStreamProcessors().Contains(Models.MyAWSConfigs.streamProcessorName))
                {
                    Models.Starter.CreateStreamProcessor();
                }
            }
            finally
            {
                Mouse.OverrideCursor = null;
            }
        }
    }
}

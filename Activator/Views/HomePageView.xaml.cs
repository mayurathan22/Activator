﻿using Amazon.Kinesis.Model;
using Amazon.Rekognition;
using Amazon.Rekognition.Model;
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

namespace Activator.Views
{
    /// <summary>
    /// Interaction logic for HomePageView.xaml
    /// </summary>
    public partial class HomePageView : UserControl
    {

        public HomePageView()
        {
            InitializeComponent();            
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Wait;
            try
            {
                StreamProcessor sp = Models.Starter.DescribeStreamProcessor();

                if (sp.Status == StreamProcessorStatus.STOPPED)
                {
                    Models.Starter.StartStreamProcessor();
                }
            }
            finally
            {
                Mouse.OverrideCursor = null;
            }
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Wait;
            try
            {
                StreamProcessor sp = Models.Starter.DescribeStreamProcessor();

                if (sp.Status == StreamProcessorStatus.RUNNING)
                {
                    Models.Starter.StopStreamProcessor();
                }
            }
            finally
            {
                Mouse.OverrideCursor = null;
            }
        }

        
    }
}
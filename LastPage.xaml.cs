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

namespace WPFNavigation
{
    /// <summary>
    /// Interaction logic for LastPage.xaml
    /// </summary>
    public partial class LastPage : Page
    {
        public LastPage()
        {
            InitializeComponent();
        }

    
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindows = (MainWindow)Window.GetWindow(this);
            objMainWindows.Main.Content = new MiddlePage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindows = (MainWindow)Window.GetWindow(this);
            objMainWindows.Main.Content = new WelcomePage();
        }
    }
}

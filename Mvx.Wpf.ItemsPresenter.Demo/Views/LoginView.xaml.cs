﻿using MvvmCross.Platforms.Wpf.Presenters.Attributes;
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

namespace Mvx.Wpf.ItemsPresenter.Demo.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    [MvxContentPresentation]
    public partial class LoginView
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current?.Shutdown();
        }
    }
}
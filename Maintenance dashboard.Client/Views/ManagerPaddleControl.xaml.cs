﻿using MaintenanceDashboard.Client.ViewModels;
using MaintenanceDashboard.Data.Api;
using MaintenanceDashboard.Data.Domain;
using System.Windows;
using System.Windows.Controls;

namespace MaintenanceDashboard.Client.Views
{
    public partial class ManagerPaddleControl : UserControl
    {
        public ManagerPaddleControl()
        {
            
            InitializeComponent();
        }

        private void btnOpenAcceptancePaddle_Checked(object sender, RoutedEventArgs e)
        {
            if (GridPrincipal != null)
            {
                GridPrincipal.Children.Clear();
                GridPrincipal.Children.Add(new CreateAcceptancePaddle());
            }
        }

        private void btnOpenReleasePaddle_Checked(object sender, RoutedEventArgs e)
        {
            GridPrincipal.Children.Clear();
            GridPrincipal.Children.Add(new BuiltFunctionControl());
        }

        private void btnOpenAddPaddle_Checked(object sender, RoutedEventArgs e)
        {
            if (GridPrincipal != null)
            {
                GridPrincipal.Children.Clear();
                GridPrincipal.Children.Add(new CreatePaddleControl());
            }
        }

        private void btnOpenEditPaddle_Checked(object sender, RoutedEventArgs e)
        {
            GridPrincipal.Children.Clear();
            GridPrincipal.Children.Add(new EditPaddleControl());
        }

        private void btnOpenAddPaddlePrevention_Checked(object sender, RoutedEventArgs e)
        {
            GridPrincipal.Children.Clear();
            GridPrincipal.Children.Add(new CreatePaddlePrevention());
        }

        private void btnOpenEditPaddlePrevention_Checked(object sender, RoutedEventArgs e)
        {
            GridPrincipal.Children.Clear();
            GridPrincipal.Children.Add(new EditPaddlePrevention());
        }
    }
}

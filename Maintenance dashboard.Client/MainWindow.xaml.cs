﻿using System;
using System.Windows;
using System.Windows.Controls;
using MaintenanceDashboard.Client.Views;

namespace MaintenanceDashboard.Client
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCloseWindow_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            switch (ListViewMenu.SelectedIndex)
            {
                case 0:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new HomeControl());
                    break;
                case 1:
                    GridPrincipal.Children.Clear();   
                    GridPrincipal.Children.Add(new ManagerEmployeeControl());
                    break;
                case 2:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new ManagerRegisterToolControl());
                    break;
                case 3:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new ManagerPaddleControl());
                    break;
                case 4:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new BuiltFunctionControl());
                    break;
                case 5:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new BuiltFunctionControl());
                    break;
                default:
                    break;
            }
        }

        private void MoveCursorMenu(int index)
        {
            TrainsitioningContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (10 +(60* index)), 0, 0);
        }

        private void btnSavePassword_Click(object sender, RoutedEventArgs e)
        {
            var DateTimeNow = Convert.ToString(DateTime.Now.DayOfWeek);
            if (DateTimeNow.ToLower() == PasswordBox.Password.ToLower())
            {
                ListViewMenu.IsEnabled = IsEnabled;
                btnCloseWindow.IsEnabled = IsEnabled;
            }
            PasswordBox.Clear();
        }
    }
}

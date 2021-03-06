﻿using MaintenanceDashboard.Client.ViewModels;
using MaintenanceDashboard.Data.Api;
using System.Windows;
using System.Windows.Controls;

namespace MaintenanceDashboard.Client.Views
{
    public partial class CreateEmployeeControl : UserControl
    {
        public CreateEmployeeControl()
        {
            var _employeeViewModel = new EmployeeViewModel(new EmployeeContext());
            this.DataContext = _employeeViewModel;
            InitializeComponent();
        }
    }
}

﻿using MaintenanceDashboard.Client.ViewModels;
using MaintenanceDashboard.Data.Api;
using System.Windows;
using System.Windows.Controls;

namespace MaintenanceDashboard.Client.Views
{
    public partial class CreatePaddleControl : UserControl
    {
        public CreatePaddleControl()
        {
            InitializeComponent();
            this.DataContext = new PaddleViewModel(new PaddleContext());
        }

    }
}

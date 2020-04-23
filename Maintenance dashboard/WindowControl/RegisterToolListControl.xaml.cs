﻿using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Maintenance_dashboard.WindowControl
{
    /// <summary>
    /// Logika interakcji dla klasy RegisterToolList.xaml
    /// </summary>
    public partial class RegisterToolList : UserControl
    {
        private WorkshopDbContext _context = new WorkshopDbContext();
        public RegisterToolList()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            CollectionViewSource employeeViewSource = ((CollectionViewSource)(this.FindResource("registerToolViewSource")));
            // Load is an extension method on IQueryable,
            // defined in the System.Data.Entity namespace.
            // This method enumerates the results of the query,
            // similar to ToList but without creating a list.
            // When used with Linq to Entities this method
            // creates entity objects and adds them to the context.
            _context.RegisterTools.Load();
            // After the data is loaded call the DbSet<T>.Local property
            // to use the DbSet<T> as a binding source.
            employeeViewSource.Source = _context.RegisterTools.Local;
        }
    }
}
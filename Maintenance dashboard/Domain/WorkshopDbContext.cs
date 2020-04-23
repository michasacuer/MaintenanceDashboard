﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Maintenance_dashboard
{
    class WorkshopDbContext:DbContext
    {
        public DbSet <Employee> Employees { get; set; }
        public DbSet<RegisterTool> RegisterTools  { get; set; }

        public WorkshopDbContext()
            :base("name=WorkshopDbContext")
        {}
    }
}
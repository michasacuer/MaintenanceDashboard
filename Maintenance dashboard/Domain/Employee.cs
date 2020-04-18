﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintenance_dashboard
{
    class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set;}
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Uid { get; set; }
    }
}

﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaintenanceDashboard.Data.Domain
{
    public class ReceivedPaddle
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Employee")] [Required]
        public int EmployeeId { get; set; }
        [ForeignKey("Paddle")] [Required]
        public int PaddleId { get; set; }
        [Required]
        public string AddedDate { get; set; }
        [Required]
        public string ActivityPerformed { get; set; }
        [Required]
        public string PlannedRepairDate { get; set; }
        public string Comments { get; set; }
        [Required]
        public string IsOrders { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Paddle Paddle { get; set; }

    }
}

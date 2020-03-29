using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Leave_Management.Models
{
    public class LeaveAllocationVM
    {
        [Key]
        public int Id { get; set; }
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        public string EmployeeId { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveTypeVM LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
    }
}

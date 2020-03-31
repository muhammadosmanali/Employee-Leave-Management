using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Leave_Management.Models
{
    public class DetailsLeaveTypeVM
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }

    public class CreateleaveTypeVM
    {
        [Required]
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Leave_Management.Data
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TaxId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
    }
}

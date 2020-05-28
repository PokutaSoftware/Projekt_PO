using System;
using System.Collections.Generic;
using System.Text;

namespace PO.Project.Domain
{
    public class Employee : User
    {
        public string Address { get; set; }
        public DateTime HireDate { get; set; }
        public string Department { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public virtual List<EmployeeToRepairXref> EmployeeToRepair { get; set; } = new List<EmployeeToRepairXref>();
    }
}

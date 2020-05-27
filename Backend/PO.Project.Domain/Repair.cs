using System;
using System.Collections.Generic;
using System.Text;

namespace PO.Project.Domain
{
    public class Repair
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string CarRegistrationNumber { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual List<CarPartsUsed> CarPartsUsed { get; set; } = new List<CarPartsUsed>();
        public virtual List<ServicesUsed> ServicesUsed { get; set; } = new List<ServicesUsed>();
        public virtual List<ClientToRepairXref> ClientToRepair { get; set; } = new List<ClientToRepairXref>();
        public virtual List<EmployeeToRepairXref> EmployeeToRepair { get; set; } = new List<EmployeeToRepairXref>();
    }
}

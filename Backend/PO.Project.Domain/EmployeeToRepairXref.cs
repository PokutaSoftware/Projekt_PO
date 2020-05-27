using System;
using System.Collections.Generic;
using System.Text;

namespace PO.Project.Domain
{
    public class EmployeeToRepairXref
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int RepairId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Repair Repair { get; set; }
    }
}

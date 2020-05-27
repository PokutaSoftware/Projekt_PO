using System;
using System.Collections.Generic;
using System.Text;

namespace PO.Project.Domain
{
    public class ServicesUsed
    {
        public int Id { get; set; }
        public int RepairId { get; set; }
        public int ServiceId { get; set; }
        public int ServiceCount { get; set; }

        public virtual Repair Repair { get; set; }
        public virtual Service Service { get; set; }
    }
}

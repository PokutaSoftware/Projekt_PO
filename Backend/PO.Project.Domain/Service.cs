using System;
using System.Collections.Generic;
using System.Text;

namespace PO.Project.Domain
{
    public class Service
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public double Price { get; set; }
        public string ApproxTime { get; set; }

        public int RepairId { get; set; }
        public virtual Repair Repair { get; set; }
    }
}

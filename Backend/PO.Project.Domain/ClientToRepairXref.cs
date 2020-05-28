using System;
using System.Collections.Generic;
using System.Text;

namespace PO.Project.Domain
{
    public class ClientToRepairXref
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int RepairId { get; set; }

        public virtual Client Client { get; set; }
        public virtual Repair Repair { get; set; }
    }
}

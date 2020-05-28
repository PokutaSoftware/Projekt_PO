using System;
using System.Collections.Generic;
using System.Text;

namespace PO.Project.Domain
{
    public class CarPartsUsed
    {
        public int Id { get; set; }
        public int RepairId { get; set; }
        public int CarPartId { get; set; }
        public int CarPartCount { get; set; }

        public virtual Repair Repair { get; set; }
        public virtual CarPart CarPart { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PO.Project.Domain
{
    public class CarPart
    {
        public int IdCarPart { get; set; }
        public string ProductName { get; set; }
        public double RetailPrice { get; set; }
        public double WholesalePrice { get; set; }
        public DateTime DateOfStoring { get; set; }

        public int IdRepair { get; set; }
        public Repair Repair { get; set; }
    }
}

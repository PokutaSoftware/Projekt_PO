﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PO.Project.Domain
{
    public class CarPart
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double RetailPrice { get; set; }
        public double WholesalePrice { get; set; }
        public DateTime DateOfStoring { get; set; }

        public virtual List<CarPartsUsed> CarPartsUsed { get; set; } = new List<CarPartsUsed>();
    }
}

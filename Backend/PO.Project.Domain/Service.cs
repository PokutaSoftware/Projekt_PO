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

        public virtual List<ServicesUsed> ServicesUsed { get; set; } = new List<ServicesUsed>();
    }
}

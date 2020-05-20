using System;
using System.Collections.Generic;
using System.Text;

namespace PO.Project.Domain
{
    public class Repair
    {
        public int IdRepair { get; set; }
        public string CarName { get; set; }
        public string CarRegistrationNumber { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int IdEmployee { get; set; }
        public int IdClient { get; set; }
        public List<CarPart> IdCarPart { get; set; } = new List<CarPart>();
        public List<Service> IdService { get; set; } = new List<Service>();

    }
}

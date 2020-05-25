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
        public DateTime EndDate { get; set; }

        public virtual List<CarPart> CarParts { get; set; } = new List<CarPart>();
        public virtual List<Service> Services { get; set; } = new List<Service>();
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}

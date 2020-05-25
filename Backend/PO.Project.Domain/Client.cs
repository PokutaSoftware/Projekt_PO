using System;
using System.Collections.Generic;
using System.Text;

namespace PO.Project.Domain
{
    public class Client : User
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public int RepairId { get; set; }
        public virtual Repair Repair { get; set; }
    }
}

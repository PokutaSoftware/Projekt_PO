using System;
using System.Collections.Generic;
using System.Text;

namespace PO.Project.Domain
{
    public class Client : User
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public virtual List<ClientToRepairXref> ClientToRepair { get; set; } = new List<ClientToRepairXref>();
    }
}

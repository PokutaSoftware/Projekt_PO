using System;
using System.Collections.Generic;
using System.Text;

namespace PO.Project.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Privileges { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}

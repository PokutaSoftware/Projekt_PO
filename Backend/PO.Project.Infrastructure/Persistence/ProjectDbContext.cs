using Microsoft.EntityFrameworkCore;
using PO.Project.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PO.Project.Infrastructure.Persistence
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }

        public virtual DbSet<CarPart> CarParts { get; set; }
        public virtual DbSet<CarPartsUsed> CarPartsUsed { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientToRepairXref> ClientToRepairXrefs { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeToRepairXref> EmployeeToRepairXrefs { set; get; }
        public virtual DbSet<Repair> Repairs { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServicesUsed> ServicesUsed { get; set; }
    }
}

using PO.Project.Domain;
using PO.Project.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace PO.Project.Infrastructure.Migrations
{
    public class DbSeed
    {
        private readonly ProjectDbContext context;
        private readonly DateTime dateTime;
        private readonly Random random;
        private readonly int numberOfRows;

        public DbSeed(ProjectDbContext context)
        {
            this.context = context;
            dateTime = DateTime.Now;
            random = new Random();
            numberOfRows = 20;
        }

        public void Seed()
        {
            var carPartList = BuildCarPartsList();
            context.CarParts.AddRange(carPartList);
            context.SaveChanges();

            var clientList = BuildClientList();
            context.Clients.AddRange(clientList);
            context.SaveChanges();

            var employeeList = BuildEmployeeList();
            context.Employees.AddRange(employeeList);
            context.SaveChanges();

            var serviceList = BuildServiceList();
            context.Services.AddRange(serviceList);
            context.SaveChanges();

            var repairList = BuildRepairList();
            context.Repairs.AddRange(repairList);
            context.SaveChanges();

            var carPartsUsedList = BuildCarPartsUsedList();
            context.CarPartsUsed.AddRange(carPartsUsedList);
            context.SaveChanges();

            var servicesUsedList = BuildServicesUsedList();
            context.ServicesUsed.AddRange(servicesUsedList);
            context.SaveChanges();

            var clientToRepairXrefList = BuildClientToRepairXrefList();
            context.ClientToRepairXrefs.AddRange(clientToRepairXrefList);
            context.SaveChanges();

            var employeeToRepairXrefList = BuildEmployeeToRepairXrefList();
            context.EmployeeToRepairXrefs.AddRange(employeeToRepairXrefList);
            context.SaveChanges();
        }

        private IEnumerable<CarPart> BuildCarPartsList()
        {
            var carPartList = new List<CarPart>();

            for (int i = 0; i < numberOfRows; i++)
            {
                var carPart = new CarPart
                {
                    ProductName = "ProductName" + i,
                    RetailPrice = random.Next(5, 5000),
                    WholesalePrice = random.Next(1, 4000),
                    DateOfStoring = dateTime.AddDays(-(random.Next(0, 10)))
                };
                carPartList.Add(carPart);
            }

            return carPartList;
        }

        private IEnumerable<Client> BuildClientList()
        {
            var clientList = new List<Client>();

            for (int i = 0; i < numberOfRows; i++)
            {
                var client = new Client
                {
                    FirstName = "FirstName" + i,
                    LastName = "LastName" + i,
                    Privileges = "Client",
                    RegistrationDate = dateTime.AddDays(-(random.Next(0, 10))),
                    Login = "LoginClient" + i,
                    Password = "PaswordClient" + i,
                    PhoneNumber = random.Next(100000000, 999999999).ToString(),
                    Email = "clientemail" + i + "@gmail.com"
                };

                clientList.Add(client);
            }

            return clientList;
        }

        private IEnumerable<Employee> BuildEmployeeList()
        {
            var employeeList = new List<Employee>();

            for (int i = 0; i < numberOfRows; i++)
            {
                var employee = new Employee
                {
                    FirstName = "FirstName" + i,
                    LastName = "LastName" + i,
                    Privileges = "Employee",
                    RegistrationDate = dateTime.AddDays(-(random.Next(0, 10))),
                    Login = "LoginEmployee" + i,
                    Password = "PaswordEmployee" + i,
                    PhoneNumber = random.Next(100000000, 999999999).ToString(),
                    Email = "employeeemail" + i + "@gmail.com",
                    Address = "Address" + i,
                    HireDate = dateTime.AddDays(-(random.Next(0, 10))),
                    Department = "Department" + i
                };

                employeeList.Add(employee);
            }

            return employeeList;
        }

        private IEnumerable<Service> BuildServiceList()
        {
            var serviceList = new List<Service>();

            for (int i = 0; i < numberOfRows; i++)
            {
                var service = new Service
                {
                    ServiceName = "ServiceName" + i,
                    Price = random.Next(2, 50) * 10,
                    ApproxTime = i + "h"
                };

                serviceList.Add(service);
            }

            return serviceList;
        }

        private IEnumerable<Repair> BuildRepairList()
        {
            var repairList = new List<Repair>();

            for (int i = 0; i < numberOfRows; i++)
            {
                var repair = new Repair
                {
                    CarName = "CarName" + i,
                    CarRegistrationNumber = "OPO" + random.Next(1000, 9999),
                    Status = "Status" + i,
                    Description = "Description" + i,
                    StartDate = dateTime.AddDays(-(random.Next(5, 10))),
                    EndDate = dateTime.AddDays(-(random.Next(0, 5)))
                };

                repairList.Add(repair);
            }

            return repairList;
        }

        private IEnumerable<CarPartsUsed> BuildCarPartsUsedList()
        {
            var carPartsUsedList = new List<CarPartsUsed>();

            for (int i = 0; i < numberOfRows; i++)
            {
                var carPartsUsed = new CarPartsUsed
                {
                    RepairId = i + 1,
                    CarPartId = i + 1,
                    CarPartCount = random.Next(1, 10)
                };

                carPartsUsedList.Add(carPartsUsed);
            }

            return carPartsUsedList;
        }

        private IEnumerable<ServicesUsed> BuildServicesUsedList()
        {
            var servicesUsedList = new List<ServicesUsed>();

            for (int i = 0; i < numberOfRows; i++)
            {
                var servicesUsed = new ServicesUsed
                {
                    RepairId = i + 1,
                    ServiceId = i + 1,
                    ServiceCount = random.Next(0, 10)
                };

                servicesUsedList.Add(servicesUsed);
            }

            return servicesUsedList;
        }

        private IEnumerable<ClientToRepairXref> BuildClientToRepairXrefList()
        {
            var clientToRepairXrefList = new List<ClientToRepairXref>();

            for (int i = 0; i < numberOfRows; i++)
            {
                var clientToRepairXref = new ClientToRepairXref
                {
                    ClientId = i + 1,
                    RepairId = i + 1
                };

                clientToRepairXrefList.Add(clientToRepairXref);
            }

            return clientToRepairXrefList;
        }

        private IEnumerable<EmployeeToRepairXref> BuildEmployeeToRepairXrefList()
        {
            var employeeToRepairXrefList = new List<EmployeeToRepairXref>();

            for (int i = 0; i < numberOfRows; i++)
            {
                var employeeToRepairXref = new EmployeeToRepairXref
                {
                    EmployeeId = i + 1,
                    RepairId = i + 1
                };

                employeeToRepairXrefList.Add(employeeToRepairXref);
            }

            return employeeToRepairXrefList;
        }
    }
}

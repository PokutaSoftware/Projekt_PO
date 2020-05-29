using System;
using System.Collections.Generic;
using System.Text;
using static PO.Project.Domain.Models.EmployeeModule;

namespace PO.Project.Domain.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {

            };
        }


        public Employee GetEmployee(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using static PO.Project.Domain.Models.ServiceModule;

namespace PO.Project.Domain.Models
{
    public class MockServiceRepository : IServiceRepository
    {
        private List<Service> _serviceList;

        public MockServiceRepository()
        {
            _serviceList = new List<Service>()
            {

            };
        }

        public Service GetService(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

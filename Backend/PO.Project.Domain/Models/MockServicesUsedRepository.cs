using System;
using System.Collections.Generic;
using System.Text;
using static PO.Project.Domain.Models.ServicesUsedModule;

namespace PO.Project.Domain.Models
{
    public class MockServicesUsedRepository : IServicesUsedRepository
    {
        private List<ServicesUsed> _servicesUsedList;

        public MockServicesUsedRepository()
        {
            _servicesUsedList = new List<ServicesUsed>()
            {

            };
        }



        public ServicesUsed GetServicesUsed(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static PO.Project.Domain.Models.ClientModule;

namespace PO.Project.Domain.Models
{
    public class MockClientRepository : IClientRepository
    {
        private List<Client> _clientList;

        public MockClientRepository()
        {
            _clientList = new List<Client>()
            {

            };
        }



        public Client GetClient(int Id)
        {
            return _clientList.FirstOrDefault(c => c.Id == 1);
        }
    }
}

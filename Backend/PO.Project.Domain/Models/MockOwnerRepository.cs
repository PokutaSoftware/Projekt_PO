using System;
using System.Collections.Generic;
using System.Text;
using static PO.Project.Domain.Models.OwnerModule;

namespace PO.Project.Domain.Models
{
    public class MockOwnerRepository : IOwnerRepository
    {

        private List<Owner> _ownerList;

        public MockOwnerRepository()
        {
            _ownerList = new List<Owner>()
            {

            };
        }



        public Owner GetOwner(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using static PO.Project.Domain.Models.UserModule;

namespace PO.Project.Domain.Models
{
    public class MockUserRepository : IUserRepository
    {
        private List<User> _userList;

        public MockUserRepository()
        {
            _userList = new List<User>()
            {

            };
        }

        public User GetUser(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

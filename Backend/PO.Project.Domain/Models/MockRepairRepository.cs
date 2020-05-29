using System;
using System.Collections.Generic;
using System.Text;
using static PO.Project.Domain.Models.RepairModule;

namespace PO.Project.Domain.Models
{
    public class MockRepairRepository : IRepairRepository
    {
        private List<Repair> _repairList;

        public MockRepairRepository()
        {
            _repairList = new List<Repair>()
            {

            };
        }


        public Repair GetRepair(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

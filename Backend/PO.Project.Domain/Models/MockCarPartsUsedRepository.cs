using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static PO.Project.Domain.Models.CarPartsUsedModule;

namespace PO.Project.Domain.Models
{
    public class MockCarPartsUsedRepository: ICarPartsUsedRepository
    {

        private List<CarPartsUsed> _carPartsUsedList;

        public MockCarPartsUsedRepository()
        {
            _carPartsUsedList = new List<CarPartsUsed>()
            {

            };
        }

        public CarPartsUsed GetCarPartsUsed(int Id)
        {
            return _carPartsUsedList.FirstOrDefault(c => c.Id == 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static PO.Project.Domain.Models.CarPartModule;

namespace PO.Project.Domain.Models
{
    public class MockCarPartRepository : ICarPartRepository
    {
        private List<CarPart> _carPartList;

        public MockCarPartRepository()
        {
            _carPartList = new List<CarPart>()
            {
            
            
            };
        }

        public CarPart GetCarPart(int Id)
        {
            return _carPartList.FirstOrDefault(c => c.Id == 1);
        }
    }

    
}

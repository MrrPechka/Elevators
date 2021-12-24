using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Service
{
    public interface IHumanCreateService : IService
    {
        void CreateHuman(int number, int locationFloor, int destinationFloor);
    }
}
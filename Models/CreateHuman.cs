using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CreateHuman : FactoryOfHumans
    {
        public CreateHuman(int number, int destinationFloor, int floor) : base(number, destinationFloor,floor) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CreateHuman : FactoryOfHumans
    {
        public CreateHuman(int number, int destinationFloor, Floor floor) : base(number, destinationFloor,floor) { }
    }
}

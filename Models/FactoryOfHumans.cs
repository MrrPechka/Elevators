using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FactoryOfHumans
    {
        public int number;
        public int destinationFloor;
        public readonly Floor floor;

        public FactoryOfHumans(int number, int destinationFloor, Floor floor)
        {
            this.number = number;
            this.destinationFloor = destinationFloor;

            if (floor == null)
                return;
            this.floor = floor;
        }
    }
}

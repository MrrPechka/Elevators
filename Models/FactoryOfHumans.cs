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
        public int floor;

        public FactoryOfHumans(int number, int destinationFloor, int floor)
        {
            this.number = number;
            this.destinationFloor = destinationFloor;

            if (floor == 0)
                return;
            this.floor = floor;
        }
    }
}

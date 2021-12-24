using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SystemData
    {
        private ISettings settings;
        //floors and elevators please
        public SystemData(ISettings settings)
        {
            this.settings = settings;
        }

        public void SetSettings(ISettings settings)
        {
            this.settings = settings;
            //floors and elevators
        }

        public ISettings GetSettings()
        {
            return settings;
        }

        public void NewHuman(int number, int locationFloor, int destinationFloor)
        {
            CreateHuman createHuman = new CreateHuman(number, locationFloor, destinationFloor);
        }

        //realization, its range counts, getters and movers:
        public void AddFloor() { }
        public void AddElevator() { }
        
    }
}

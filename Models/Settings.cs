using Models.ElevatorManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Settings : ISettings
    {
        public int ElevatorsNumber { get; set; }
        public int ElevatorsSize { get; set; }
        public int FloorsNumber { get; set; }
        public int SecondsToWait { get; set; }
        public int SecondsToMove { get; set; }
        public IElevatorManager ElevatorManager { get; set; }
    }
}

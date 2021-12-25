using Models.ElevatorManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface ISettings
    {
        int ElevatorsNumber { get; set; }
        int ElevatorsSize { get; set; }
        int FloorsNumber { get; set; }
        int SecondsToWait { get; set; }
        int SecondsToMove { get; set; }
        IElevatorManager ElevatorManager { get; set; }
    }
}

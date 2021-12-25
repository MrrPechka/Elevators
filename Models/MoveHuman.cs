using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MoveHuman
    {
        public static void MoveHumans(SystemData data)
        {
            foreach (Elevator elevator in data.GetElevator())
            {
                if (elevator.status == Elevator.ElevatorStatus.WaitOpened)
                {
                    Floor floor = data.GetFloorByNumber(elevator.GetKeepeFloor());
                    MoveHuman.ExitElevator(floor, elevator);
                    MoveHuman.EnterElevator(floor, elevator, data.GetSettings().ElevatorsSize);
                }
            }
        }

        public static void EnterElevator(Floor floor, Elevator elevator, int elevatorSize)
        {
            IEnumerable<Human> humanToMove = floor.GetHuman().Where<Human>(h => h.humanStatus == Human.HumanStatus.OnTheFloor && (elevator.DestinationFloor - elevator.Floor > 0 && (floor.GetKeepeFloor() - h.DestinationFloor) < 0 || elevator.DestinationFloor - elevator.Floor < 0 && (floor.GetKeepeFloor() - h.DestinationFloor) > 0));
            foreach(var h in humanToMove)
            {
                if (elevatorSize > elevator.GetHumanCount())
                    elevator.AddHuman(h);
                else
                    break;
            }
            floor.RemoveSomeHumans(h => h.humanStatus == Human.HumanStatus.InLift);
        }

        public static void ExitElevator(Floor floor, Elevator elevator)
        {
            IEnumerable<Human> elevatorsHuman = elevator?.GetHuman();
            floor.AddRangeHumans(elevatorsHuman.Where(h => h.humanStatus == Human.HumanStatus.InLift && (floor.GetKeepeFloor() - h.DestinationFloor) == 0));
            elevator.RemoveSomeHumans(h => h.humanStatus == Human.HumanStatus.Disposing);
        }
    }
}

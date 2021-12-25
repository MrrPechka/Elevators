using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ElevatorManager
{
    public class MinWaitingTimeElevatorManager : IElevatorManager
    {
        public void ManageElevators(SystemData data)
        {
            MoveHuman.MoveHumans(data);
            Context context = new Context();
            foreach (Elevator elevator in data.GetElevator())
            {
                if (elevator.status == Elevator.ElevatorStatus.Moving)
                {
                    if (elevator.DestinationFloor == elevator.GetKeepeFloor())
                    {
                        elevator.SetDestinationFloor(context.GetNearestFloor(elevator, data.GetFloorByNumber(elevator.GetKeepeFloor())));
                        elevator.OpenDoor();
                    }
                    else if (data.GetSettings().ElevatorsSize > elevator.GetHumanCount())
                    {
                        context.ChangeTargetFloor(data, elevator);
                    }
                }
                else if (elevator.status == Elevator.ElevatorStatus.WaitClosed)
                {
                    if (elevator.GetHumanCount() != 0)
                        elevator.StartMoving();
                    else
                    {
                        elevator.SetDestinationFloor(this.GetTargetFloorForMinWaitingTime(data, elevator));
                        Floor fl = data.GetFloorByNumber(elevator.DestinationFloor);
                        if (elevator.DestinationFloor == elevator.GetKeepeFloor() && fl.getHumanCountUp() + fl.getHumanCountDown() != 0)
                        {
                            elevator.SetDestinationFloor(context.GetNearestFloor(elevator, data.GetFloorByNumber(elevator.GetKeepeFloor())));
                            elevator.OpenDoor();
                        }
                        else if (elevator.DestinationFloor != elevator.GetKeepeFloor())
                        {
                            elevator.StartMoving();
                        }
                    }
                }
            }
        }
        private int GetTargetFloorForMinWaitingTime(SystemData data, Elevator elevator)
        {
            decimal maxEff = 0;
            int numFloor = -1;
            decimal curEff = 0;
            foreach (var fl in data.GetFloor())
            {
                int humsUp;
                int humsDown;
                new Context().GetEffectiveHumanCountOnFloor(fl, elevator, data, out humsUp, out humsDown);
                if (this.CheckOtherLiftsEfficientcy(data, fl, elevator))
                    continue;
                int distance = Math.Abs(elevator.GetKeepeFloor() - fl.GetKeepeFloor());
                if (distance != 0)
                {
                    if (humsUp > humsDown)
                        curEff = (decimal)humsUp / distance;
                    else
                        curEff = (decimal)humsDown / distance;
                }
                else if (humsUp > 0 || humsDown > 0)
                {
                    numFloor = fl.GetKeepeFloor();
                    break;
                }
                if (curEff > maxEff)
                {
                    maxEff = curEff;
                    numFloor = fl.GetKeepeFloor();
                }
            }
            if (numFloor == -1)
                return elevator.GetKeepeFloor();
            return numFloor;
        }

        private bool CheckOtherLiftsEfficientcy(SystemData data, Floor floor, Elevator elevator)
        {
            int distance = Math.Abs(elevator.GetKeepeFloor() - floor.GetKeepeFloor());
            foreach (var l in data.GetElevator())
            {
                if (l != elevator && l.status == Elevator.ElevatorStatus.WaitClosed && l.GetHumanCount() == 0)
                {
                    if (Math.Abs(l.GetKeepeFloor() - floor.GetKeepeFloor()) < distance)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ElevatorManager
{
    class Context
    {
        internal int GetNearestFloor(Elevator elevator, Floor floor)
        {
            if (elevator.GetHumanCount() == 0)
            {
                if (floor.GetHumanCount() == 0)
                    return elevator.GetKeepeFloor();
                int nearestFloorUp = int.MaxValue;
                int nearestFloorDown = int.MinValue;
                int countHumansUp = 0;
                int countHumansDown = 0;
                foreach (var h in floor.GetHuman())
                {
                    if (floor.GetKeepeFloor() - h.DestinationFloor < 0)
                    {
                        countHumansUp++;
                        if (nearestFloorUp > h.DestinationFloor)
                            nearestFloorUp = h.DestinationFloor;
                    }
                    else
                    {
                        countHumansDown++;
                        if (nearestFloorDown < h.DestinationFloor)
                            nearestFloorDown = h.DestinationFloor;
                    }
                }
                if (countHumansUp > countHumansDown)
                    return nearestFloorUp;
                else
                    return nearestFloorDown;
            }
            else
            {
                return this.GetNearestFloorForHumansInLift(elevator);
            }
        }

        internal int GetNearestFloorForHumansInLift(Elevator elevator)
        {
            if (elevator.GetHumanCount() != 0)
            {
                int nearestFloor = int.MaxValue;
                bool dir = elevator.GetHuman().ElementAt(0).DestinationFloor > elevator.GetKeepeFloor();
                foreach (var h in elevator.GetHuman())
                {
                    if (Math.Abs(elevator.GetKeepeFloor() - h.DestinationFloor) < Math.Abs(elevator.GetKeepeFloor() - nearestFloor))
                        nearestFloor = h.DestinationFloor;
#if DEBUG
                    if (dir != (h.DestinationFloor > elevator.GetKeepeFloor()))
                    {
                        throw new Exception("MODEL: MinWaitingTimeStrategy: IsChoosenDirectionUp: Not all humans go in same direction!");
                    }
#endif
                }
                return nearestFloor;
            }
            return elevator.GetKeepeFloor();
        }

        internal void ChangeTargetFloor(SystemData data, Elevator elevator)
        {
            bool isDirUp = elevator.GetKeepeFloor() < elevator.DestinationFloor;
            int i = elevator.GetKeepeFloor() + (isDirUp ? 1 : -1);
            int humsUp;
            int humsDown;
            while (i != elevator.DestinationFloor)
            {
                Floor fl = data.GetFloorByNumber(i);
                this.GetEffectiveHumanCountOnFloor(fl, elevator, data, out humsUp, out humsDown);
                if (isDirUp && humsUp > 0 || !isDirUp && humsDown > 0)
                {
                    elevator.SetDestinationFloor(i);
                    break;
                }
                else
                    i += (isDirUp ? 1 : -1);
            }
            this.GetEffectiveHumanCountOnFloor(data.GetFloorByNumber(elevator.DestinationFloor), elevator, data, out humsUp, out humsDown);
            if (elevator.GetHumanCount() != 0 && (isDirUp && humsUp <= 0 || !isDirUp && humsDown <= 0))
            {
                elevator.SetDestinationFloor(this.GetNearestFloorForHumansInLift(elevator));
                while (i != elevator.DestinationFloor)
                {
                    Floor fl = data.GetFloorByNumber(i);
                    this.GetEffectiveHumanCountOnFloor(fl, elevator, data, out humsUp, out humsDown);
                    if (isDirUp && humsUp > 0 || !isDirUp && humsDown > 0)
                        elevator.SetDestinationFloor(i);
                    else
                        i += (isDirUp ? 1 : -1);
                }
            }
        }

        internal void GetEffectiveHumanCountOnFloor(Floor fl, Elevator elevator, SystemData data, out int humsUp, out int humsDown)
        {
            humsUp = fl.getHumanCountUp();
            humsDown = fl.getHumanCountDown();
            foreach (var l in data.GetElevator())
            {
                if (l == elevator)
                    continue;
                if (l.DestinationFloor == fl.GetKeepeFloor())
                {
                    if (l.GetHumanCount() != 0)
                    {
                        if (l.GetKeepeFloor() - l.DestinationFloor > 0)
                            humsDown -= data.GetSettings().ElevatorsSize - l.GetHumanCount();
                        else
                            humsUp -= data.GetSettings().ElevatorsSize - l.GetHumanCount();
                    }
                    else if (humsUp > humsDown)
                        humsUp -= data.GetSettings().ElevatorsSize - l.GetHumanCount();
                    else
                        humsDown -= data.GetSettings().ElevatorsSize - l.GetHumanCount();
                }
                else if (l.GetKeepeFloor() == fl.GetKeepeFloor() && l.status == Elevator.ElevatorStatus.WaitOpened)
                {
                    if (l.GetKeepeFloor() - l.DestinationFloor > 0)
                        humsDown -= data.GetSettings().ElevatorsSize - l.GetHumanCount();
                    else
                        humsUp -= data.GetSettings().ElevatorsSize - l.GetHumanCount();
                }
            }
        }
    }
}


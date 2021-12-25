using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Elevator : IKeepHuman
    {
        internal int DestinationFloor { get; private set; }
        public ElevatorStatus status;
        public enum ElevatorStatus
        {
            WaitClosed,
            WaitOpened,
            Moving
        }

        HashSet<Human> dataHuman= new HashSet<Human>();
        internal int humanCount;
        internal int ElevatorCount { get; private set; }
        internal int Floor { get; private set; }

        internal readonly int TICKS_TO_MOVE;
        internal readonly int TICKS_TO_WAIT;

        internal Elevator(int elevatorCount, int ticksToMove = 30, int ticksToWait = 30, int floor = 0) : base()
        {
            TICKS_TO_MOVE = ticksToMove;
            this.ElevatorCount = elevatorCount;
            TICKS_TO_WAIT = ticksToWait;
            Floor = floor;
            DestinationFloor = floor;
            status = ElevatorStatus.WaitClosed;
        }
        internal void StartMoving()
        {
            status = ElevatorStatus.Moving;
        }
        internal void SetDestinationFloor(int floor)
        {
            this.DestinationFloor = floor;
        }
        private void Move()
        {
            if(status == ElevatorStatus.Moving)
            {
                if (DestinationFloor - Floor > 0)
                    Floor++;
                else if (Floor > 0)
                    Floor--;
            }
        }

        internal int GetTickToMove()
        {
            return TICKS_TO_MOVE;
        }
        internal void OpenDoor()
        {
            this.status = ElevatorStatus.WaitOpened;
        }
        internal void WaitWithOpenedDoor()
        {
            this.status = ElevatorStatus.WaitOpened;
        }
        internal void WaitWithClosedDoor()
        {
            this.status = ElevatorStatus.WaitClosed;
        }
        public void AddHuman(Human human)
        {
            if(human != null)
            {
                dataHuman.Add(human);
                human.ChangeStatus();
                humanCount += 1;
            }
        }
        public void AddRangeHumans(IEnumerable<Human> human)
        {
            if(human != null)
            {
                foreach (var humans in human)
                    AddHuman(humans);
            }
        }
        public void RemoveSomeHumans(Predicate<Human> predicate)
        {
            if(predicate != null && dataHuman.Count > 0)
            {
                dataHuman.RemoveWhere(predicate);
                humanCount = dataHuman.Count;
            }
        }
        public void RemoveAllHumans(Human human)
        {
            if(human != null && dataHuman.Contains(human))
            {
                dataHuman.Remove(human);
                humanCount--;
            }
        }
        public IEnumerable<Human> GetHuman()
        {
            return dataHuman;
        }
        public int GetKeeperNumber()
        {
            return ElevatorCount;
        }
        public int GetKeepeFloor()
        {
            return Floor;
        }
        protected void Notify()
        {
            if (status == ElevatorStatus.WaitOpened)
                status = ElevatorStatus.WaitClosed;
            else if (status == ElevatorStatus.Moving)
                Move();
        }
        public int GetHumanCount() => humanCount;
    }
}

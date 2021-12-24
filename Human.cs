using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Models
{
    public class Human
    {
        internal HumanStatus humanStatus { get; private set; }
        internal int DestinationFloor { get; private set; }
        internal enum HumanStatus
        {
            Created,
            OnTheFloor,
            InLift,
            Disposing,
            Dispose
        }

        internal Human(int destinationFloor) :base()
        {
            this.DestinationFloor = destinationFloor;
            humanStatus = HumanStatus.Created;
        }

        public void Dispose()
        {
            if(humanStatus != HumanStatus.Dispose)
                humanStatus = HumanStatus.Disposing;
        }

        internal void ChangeStatus()
        {
            if (humanStatus == HumanStatus.InLift)
                this.Dispose();
            if (humanStatus == HumanStatus.OnTheFloor)
                humanStatus = HumanStatus.InLift;
        }

        public void HumanOnFire()
        {
            DestinationFloor = 0;
        }

        public String GetStatus()
        {
            String status;
            switch (this.humanStatus)
            {
                case HumanStatus.Created:
                    {
                        status = "On the creation floor";
                        break;
                    }
                case HumanStatus.OnTheFloor:
                    {
                        status = "Waiting for elevator";
                        break;
                    }
                case HumanStatus.InLift:
                    {
                        status = "Is in the elevator and goes to " + this.DestinationFloor;
                        break;
                    }
                case HumanStatus.Disposing:
                    {
                        status = "Delivered to the target floor";
                        break;
                    }
                default:
                    {
                        throw new Exception("No such status: " + this.humanStatus);
                    }
            }
            return status;
        }
    }
}

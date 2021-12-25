using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Floor : IKeepHuman
    {
        HashSet<Human> human = new HashSet<Human>();
        int floorNumber;
        internal int humanCountUp;
        internal int humanCountDown;
        internal Floor(int floorNumber)
        {
            this.floorNumber = floorNumber;
        }
        public IEnumerable<Human> GetHuman()
        {
            return human;
        }
        public void AddHuman(Human human)
        {
            if(human != null)
            {
                this.human.Add(human);
                human.ChangeStatus();
                if (human.DestinationFloor > floorNumber)
                    humanCountUp += 1;
                else if (human.DestinationFloor < floorNumber)
                    humanCountDown += 1;
            }
        }
        public void RemoveHuman(Human humans)
        {
            if(humans != null)
            {
                human.Remove(humans);
                if (humans.DestinationFloor > floorNumber)
                    humanCountUp -= 1;
                else if (humans.DestinationFloor < floorNumber)
                    humanCountDown -= 1;
            }
        }
        public void RemoveSomeHumans(Predicate<Human> predicate)
        {
            if(predicate != null)
            {
                this.human.RemoveWhere(predicate);
                humanCountUp = 0;
                humanCountDown = 0;
                foreach (Human i in human)
                    if (i.DestinationFloor > floorNumber)
                        humanCountUp += 1;
                    else if (i.DestinationFloor < floorNumber)
                        humanCountDown += 1;
            }
        }
        public int GetKeeperNumber()
        {
            return floorNumber;
        }

        public int GetKeepeFloor()
        {
            return floorNumber;
        }
        public int GetHumanCount() => humanCountUp + humanCountDown;
        public int getHumanCountUp() => humanCountUp;
        public int getHumanCountDown() => humanCountDown;
        public int getFullHumanCount() => human.Count;
        public void AddRangeHumans(IEnumerable<Human> human)
        {
            if (human != null)
                foreach (var humans in human)
                    this.AddHuman(humans);
        }
    }
}

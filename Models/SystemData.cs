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
        List<Elevator> Elevator = new List<Elevator>();
        List<Floor> Floor = new List<Floor>();
        //floors and elevators please
        public SystemData(ISettings settings)
        {
            this.settings = settings;
            this.CreateKeepers();
        }

        public void SetSettings(ISettings settings)
        {
            Elevator.Clear();
            Floor.Clear();
            this.settings = settings;
            Elevator = new List<Elevator>(settings.ElevatorsNumber);
            Floor = new List<Floor>(settings.FloorsNumber);
            this.CreateKeepers();
            //floors and elevators
        }

        public ISettings GetSettings()
        {
            return settings;
        }

        public void CreateHuman(int number, int locationFloor, int destinationFloor)
        {
            CreateHuman createHuman = new CreateHuman(number, destinationFloor, GetFloorByNumber(locationFloor));
        }
        public void CreateKeepers()
        {
            for (int i = 0; i < settings.FloorsNumber; i++)
                Floor.Add(new Floor(i));

            for (int i = 0; i < settings.ElevatorsNumber; i++)
                Elevator.Add(new Elevator(i, settings.SecondsToMove, settings.SecondsToWait));
        }

        //realization, its range counts, getters and movers:
        public void AddFloor(Floor floor) 
        {
            if (floor != null)
                Floor.Add(floor);
        }
        public void AddElevator(Elevator elevator) 
        {
            if (elevator != null)
                Elevator.Add(elevator);
        }
        public void AddRangeFloors(IEnumerable<Floor> floor)
        {
            if (floor != null)
                foreach (var fl in floor)
                    AddFloor(fl);
        }
        public void AddRangeLifts(IEnumerable<Elevator> elevator)
        {
            if (elevator != null)
                foreach (var elevators in elevator)
                    AddElevator(elevators);
        }
        public IEnumerable<Elevator> GetElevator() => Elevator;
        public IEnumerable<Floor> GetFloor() => Floor;
        public void RemoveFloor(Floor floor)
        {
            if (floor != null)
                if (Floor.Contains(floor))
                    this.Floor.Remove(floor);
        }

        public void RemoveLift(Elevator elevator)
        {
            if (elevator != null)
                if (Elevator.Contains(elevator))
                    this.Elevator.Remove(elevator);
        }
        public Floor GetFloorByNumber(int number)
        {
            if (number >= 0 && number < GetFloor().Count())
                return GetFloor().FirstOrDefault(f => f.GetKeeperNumber() == number);
            else
            {
                throw new Exception($"There is no such a floor:{number + 1}");
            }
        }
    }
}

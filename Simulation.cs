using Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Simulation : ISimulation
    {
        protected SystemData systemData;
        protected IService service;
        bool stop = true;

        public Simulation(int floorsNumber, int elevatorsNumber)
        {
            ISettings settings = new Settings();
            settings.ElevatorsNumber = elevatorsNumber;
            settings.FloorsNumber = elevatorsNumber;
            settings.SecondsToMove = 2;
            settings.SecondsToWait = 2;
            settings.ElevatorsSize = 7;
            systemData = new SystemData(settings);
        }

        public void Start()
        {
            if (stop)
            {
                stop = false;
            }
        }
        public void Pause()
        {

        }
        public bool Stop()
        {
            return false;
        }
        public void SetSpeed(decimal speed)
        {

        }

        public bool IsStoped()
        {
            return false;
        }

        public SystemData GetSystemData() => systemData;
        public void SetService(IService service)
        {
            this.service = service;
        }

        public IService GetService()
        {
            return service;
        }
    }
}

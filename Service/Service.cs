using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Service
{
    public class Service
    {
        private readonly ISimulation simulation;
        public Service(ISimulation simulation)
        {
            this.simulation = simulation;
        }
        public SystemData GetSystemData()
        {
            return simulation.GetSystemData();
        }
        public void StartSimulation()
        {
            simulation.Start();
        }
        public void PauseSimulation()
        {
            simulation.Pause();
        }
        public bool StopSimulation()
        {
            return simulation.Stop();
        }
        public void SetSimulationSpeed(decimal speed)
        {
            simulation.SetSpeed(speed);
        }
        public bool IsStoped()
        {
            return simulation.IsStoped();
        }
    }
}

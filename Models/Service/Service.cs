using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Service
{
    public class Service : IMainService
    {
        private readonly ISimulation simulation;

        public event Action<SystemData> UpdateSystemData;

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
        public void SetSpeed(decimal speed)
        {
            simulation.SetSpeed(speed);
        }
        public bool IsStoped()
        {
            return simulation.IsStoped();
        }
        public void ShowData(SystemData data)
        {
            this.UpdateSystemData.Invoke(data);
        }
        public SystemData ShowCurrentState()
        {
            return simulation.GetSystemData();
        }
    }
}

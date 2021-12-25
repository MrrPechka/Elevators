using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Service
{
    public interface IMainService : IService
    {
        SystemData ShowCurrentState();
        void StartSimulation();
        void PauseSimulation();
        bool StopSimulation();
        void SetSpeed(decimal speed);
        void ShowData(SystemData data);
        SystemData GetSystemData();
        bool IsStoped();
        public void UpdateCarriedHumans(int number);

        event Action<SystemData> UpdateSystemData;
        public event Action<int> UpdateNumberOfCarriedHumans;
    }
}

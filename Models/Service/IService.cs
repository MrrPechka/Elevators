using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Service
{
    public interface IService
    {
        SystemData ShowCurrentState();
        void StartSimulation();
        void PauseSimulation();
        bool StopSimulation();
        void SetSpeed(decimal speed);
        void ShowData(SystemData date);
        SystemData GetSystemData();
        bool IsStoped();

        event Action<SystemData> UpdateSystemData;
    }
}

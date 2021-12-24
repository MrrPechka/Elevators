using Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface ISimulation
    {
        public void Start();
        public void Pause();
        public bool Stop();
        public void SetSpeed(decimal speed);
        public bool IsStoped();
        public SystemData GetSystemData();
        IService GetService();
        public void SetService(IService service);
    }
}

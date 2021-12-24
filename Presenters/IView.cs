using Models;
using Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public interface IView
    {
        void ShowForm();
        void CloseForm();
        void ShowStatus(SystemData systemData); 

        public delegate bool Status();

        event Action StartSimulation;
        event Action StopSimulation;
        event Action PauseSimulation;
        event Action<decimal> SetSpeed;
    }
}
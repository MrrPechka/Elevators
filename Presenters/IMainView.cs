using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public interface IMainView : IView
    {
        void ShowStatus(SystemData systemData);

        public delegate bool Status();

        event Action StartSimulation;
        event Status StopSimulation;
        event Action PauseSimulation;
        event Action<decimal> SetSpeed;
    }
}

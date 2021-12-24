using Models;
using Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public class Presenter
    {
        private IService _service;
        private IView _view;

        public Presenter(IService service, IView view)
        {
            _service = service;
            _view = view;
        }
        private void InitEvents()
        {
            _view.StartSimulation += this.StartSimulation;
            //_view.StopSimulation += this.StopSimulation;
            _view.PauseSimulation += this.PauseSimulation;
            _view.SetSpeed += this.SetSpeed;
            _service.UpdateSystemData += this.ShowData;
        }
        
        public void ShowData(SystemData data)
        {
            _view.ShowStatus(data);
        }
        public void StartSimulation()
        {
            _service.StartSimulation();
        }
        public bool StopSimulation()
        {
            return _service.StopSimulation();
        }
        public void PauseSimulation()
        {
            _service.PauseSimulation();
        }
        public void SetSpeed(decimal speed)
        {
            _service.SetSpeed(speed);
        }
    }
}

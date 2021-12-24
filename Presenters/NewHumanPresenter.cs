using Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public class NewHumanPresenter
    {
        private IHumanCreateService _humanCreateService;
        private ICreateHumanAction _createHumanAction;

        public NewHumanPresenter(ICreateHumanAction action, IHumanCreateService service)
        {
            this._createHumanAction = action;
            this._humanCreateService = service;
            InitEvents();
        }

        public void CreateHuman(int number, int locationFloor, int destinationFloor)
        {
            _humanCreateService.CreateHuman(number, locationFloor - 1, destinationFloor - 1);
        }

        private void InitEvents()
        {
            _createHumanAction.CreateHuman += this.CreateHuman;
        }
    }
}

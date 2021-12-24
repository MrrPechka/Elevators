using Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public class SettingsPresenter
    {
        private ISettingsService _settingsService;
        private ISettingsView _view;
        private IMainService _service;

        public SettingsPresenter(ISettingsView view, ISettingsService settingsService, IMainService service)
        {
            _view = view;
            _settingsService = settingsService;
            _service = service;
        }

        public void GetParameters()
        {
            _view.LoadCurrentParameters(_settingsService.GetSettings());
        }
    }
}

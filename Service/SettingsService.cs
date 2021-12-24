using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Service
{
    public class SettingsService : ISettingsService
    {
        private SystemData systemData;
        public SettingsService(SystemData systemData)
        {
            this.systemData = systemData;
        }
        public ISettings GetSettings()
        {
            return systemData.GetSettings();
        }
    }
}

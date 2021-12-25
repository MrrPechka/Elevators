using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Service
{
    public interface ISettingsService : IService
    {
        public void SaveSystemParameters(ISettings settings);
        public ISettings GetSettings();
    }
}

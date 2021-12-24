using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public interface ISettingsView : IView
    {
        public void LoadCurrentParameters(ISettings settings);
    }
}

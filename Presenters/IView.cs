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
    }
}
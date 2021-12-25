using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IKeepHuman
    {
        IEnumerable<Human> GetHuman();
        void AddHuman(Human human);
        int GetKeeperNumber();
        int GetKeepeFloor();
        int GetHumanCount();
    }
}

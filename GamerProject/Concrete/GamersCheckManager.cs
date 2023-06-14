using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    public class GamersCheckManager : IGamersCheckService
    {
        public bool CheckRealIfGamer(Gamers gamers)
        {
            return true;
        }
    }
}

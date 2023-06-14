using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Abstract
{
    public interface IGamersService
    {
        void Add(Gamers gamers);
        void Delete(Gamers gamers);
        void Update(Gamers gamers);
    }
}

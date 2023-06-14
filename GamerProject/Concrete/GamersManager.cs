using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    public class GamersManager : IGamersService
    {
        IGamersCheckService _gamersCheckService;
        public GamersManager(IGamersCheckService gamersCheckService)
        {
            _gamersCheckService = gamersCheckService;
        }

        public void Add(Gamers gamers)
        {
            if (_gamersCheckService.CheckRealIfGamer(gamers))
            {
                Console.WriteLine(gamers.FirstName + " " + gamers.LastName + ":bilgileriniz kaydedildi.");
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

        public void Delete(Gamers gamers)
        {
            Console.WriteLine(gamers.FirstName + " " + gamers.LastName + ":bilgileriniz silindi.");
        }

        public void Update(Gamers gamers)
        {
            Console.WriteLine(gamers.FirstName + " " + gamers.LastName + ":bilgileriniz güncellendi.");
        }
    }
}

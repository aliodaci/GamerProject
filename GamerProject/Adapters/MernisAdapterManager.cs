using GamerProject.Abstract;
using GamerProject.Entities;
using GamerProject.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Adapters
{
    public class MernisAdapterManager : IGamersCheckService
    {
        public bool CheckRealIfGamer(Gamers gamers)
        {
            KPSPublicSoapClient client= new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(gamers.Identity),gamers.FirstName.ToLower(),gamers.LastName,gamers.DateOfBirth.Year);
        }
    }
}

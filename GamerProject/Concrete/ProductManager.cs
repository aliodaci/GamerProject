using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    public class ProductManager : IProductService
    {
        public void SellGame(Gamers gamers, Product product, Campaign campaign)
        {
            Console.WriteLine(gamers.FirstName + " " + product.ProductName + " "+ campaign.CampaignName + " " + (product.Price-(product.Price*(campaign.CampaignRatio/100))));
        }
    }
}

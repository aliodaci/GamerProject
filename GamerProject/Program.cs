using GamerProject.Abstract;
using GamerProject.Adapters;
using GamerProject.Concrete;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamers gamers1= new Gamers();
            gamers1.Id = 1;
            gamers1.Identity = "25633864928";
            gamers1.FirstName = "Ali";
            gamers1.LastName = "Odacı";
            gamers1.UserName = "AliOdaci";
            gamers1.DateOfBirth = new DateTime(1991, 1, 10);
            gamers1.Email = "aliodaci@gmail.com";

            IGamersService gamersService = new GamersManager(new MernisAdapterManager());
            gamersService.Add(gamers1);

            Product product1= new Product();
            product1.Id = 1;
            product1.ProductName = "Pubg Game Mobile";
            product1.Price = 1000;

            Campaign campaign1= new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "Yaz kampanyası";
            campaign1.CampaignRatio = 20; ;

            IProductService productService = new ProductManager();
            productService.SellGame(gamers1,product1, campaign1);

            ICampaignService campaignService = new CampaignManager();
            campaignService.Add(campaign1);
            campaignService.Delete(campaign1);
            campaignService.Update(campaign1);

            Console.ReadLine();
        }
    }
}

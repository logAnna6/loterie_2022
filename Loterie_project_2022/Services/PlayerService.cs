using System.Linq;
using System.Xml.Linq;
using CSharpVitamins;
using DataLayer;
using DataLayer.Models;
using Loterie_project_2022.Models.Game;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Win32;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Loterie_project_2022.Services
{
    public class PlayerService : IPlayerService
	{
        private readonly AppDbContext dbContext;

        public PlayerService(AppDbContext dbContext)
		{
			this.dbContext = dbContext;

		}


        [HttpPost]
        public ShowCodeViewModel CreatePlayer(CreatePlayerViewModel model)
        {

            List<int> numbers = model.isChecked;
            Guid guid = Guid.NewGuid();
            ShortGuid code = guid.ToString();
            var game = dbContext.Games.OrderBy(game => game.gameId).Last().gameId;
            Player player =  new Player()
            {


                player_num1 = numbers[0],
                player_num2 = numbers[1],
                player_num3 = numbers[2],
                player_num4 = numbers[3],
                player_num5 = numbers[4],
                player_num6 = numbers[5],
                player_prize = 10,
                player_code = code,
                player_reg_date = DateTime.Now,
                gameId = game

            };




            dbContext.Players.Add(player);


            dbContext.SaveChanges();

            return new ShowCodeViewModel()
            {
                playerCode = player.player_code
            };

             


        }

        
    }
}


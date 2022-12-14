using System.Data;
using System.Linq;
using System.Xml.Linq;
using CSharpVitamins;
using DataLayer;
using DataLayer.Models;
using Loterie_project_2022.Models.Game;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
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
            var game = dbContext.Games.OrderBy(game => game.gameId).Last();

            /*List<int> prizeCount = dbContext.Games.Where(q => q.gameId == game.gameId)
     .Select(q => new { q.game_num1,q.game_num2, q.game_num3, q.game_num4, q.game_num5, q.game_num6 })
     .ToList();*/

            List<int> gameNum = new List<int>();

            gameNum.Add(game.game_num1);
            gameNum.Add(game.game_num2);
            gameNum.Add(game.game_num3);
            gameNum.Add(game.game_num4);
            gameNum.Add(game.game_num5);
            gameNum.Add(game.game_num6);


            int rang = gameNum.Intersect(numbers).Count();
            int rangFinal = 0;


            if (rang == 6)
            {
                rangFinal = 1;
                
            }
            else if(rang == 5){

                rangFinal = 2;
            }
            else if (rang == 4)
            {
                rangFinal = 3;
            }



            Player player = new Player()
            {


                player_num1 = numbers[0],
                player_num2 = numbers[1],
                player_num3 = numbers[2],
                player_num4 = numbers[3],
                player_num5 = numbers[4],
                player_num6 = numbers[5],
               // player_prize = rang,
                player_rang = rangFinal,
                player_code = code,
                player_reg_date = DateTime.Now,
                gameId = game.gameId

            };





            game.game_prize = game.game_prize + 1;



            dbContext.Players.Add(player);


            dbContext.SaveChanges();

            return new ShowCodeViewModel()
            {
                playerCode = player.player_code
            };




        }



    }
}


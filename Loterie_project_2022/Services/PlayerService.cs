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

          

            List<int> gameNum = new List<int>();

            gameNum.Add(GetLastGame().game_num1);
            gameNum.Add(GetLastGame().game_num2);
            gameNum.Add(GetLastGame().game_num3);
            gameNum.Add(GetLastGame().game_num4);
            gameNum.Add(GetLastGame().game_num5);
            gameNum.Add(GetLastGame().game_num6);


            int rang = gameNum.Intersect(numbers).Count();
            int rangFinal = 0;
            int FinalGain = 0;
           
            int otherRangs = GetLastGame().game_prize * 20 / 100;


            // attribution de rang selon le nombre de chiffres gagnants
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
                player_prize = GetPrize(rangFinal),
                player_rang = rangFinal,
                player_code = code,
                player_reg_date = DateTime.Now,
                gameId = GetLastGame().gameId

            };


            

            //recuperation de 60 et 20 pourcents de la derniere cagnotte

           


            GetLastGame().game_prize = GetLastGame().game_prize + 1;



            dbContext.Players.Add(player);


            dbContext.SaveChanges();

            return new ShowCodeViewModel()
            {
                playerCode = player.player_code
            };
      



        }


        public Game GetLastGame()
        {

           return dbContext.Games.OrderBy(game => game.gameId).Last();

        }


        public int GetPrize( int rangFinal)
        {
            int firstRang = GetLastGame().game_prize * 60 / 100;
            int FirstRangNum = dbContext.Players.Where(g => g.gameId == GetLastGame().gameId).Where(p => p.player_rang == rangFinal).Count();
            if(FirstRangNum > 0) {
            return (int)Math.Floor((double)(firstRang / FirstRangNum));
            }

            return 0;

        }




    }
}


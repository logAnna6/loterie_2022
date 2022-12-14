using System;
using System.Numerics;
using DataLayer;
using DataLayer.Models;
using Loterie_project_2022.Models.Game;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Loterie_project_2022.Services
{
    public class HomeServices : IHomeService
    {
        private readonly AppDbContext dbContext;

        public HomeServices(AppDbContext dbContext)
        {
            this.dbContext = dbContext;

        }


        [HttpPost]
        public ResultViewModel Verify(IndexViewModel model)
        {
          
          var testcode = model.Code.Trim();
        
          var query = dbContext.Players.Where(player => player.player_code.Contains(testcode)).Include(game=>game.Game).SingleOrDefault();

          
            return new ResultViewModel() {
         
                playerNum1= query.player_num1,
                playerNum2 = query.player_num2,
                playerNum3 = query.player_num3,
                playerNum4 = query.player_num4,
                playerNum5 = query.player_num5,
                playerNum6 = query.player_num6,
                playerPrize = query.player_prize,
                gameNum1 = query.Game.game_num1,
                gameNum2 = query.Game.game_num2,
                gameNum3 = query.Game.game_num3,
                gameNum4 = query.Game.game_num4,
                gameNum5 = query.Game.game_num5,
                gameNum6 = query.Game.game_num6,
                gameEnddate = query.Game.game_enddate,
               

            };

          

        }


    }
}


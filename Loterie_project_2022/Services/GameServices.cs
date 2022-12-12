using System;
using System.Diagnostics;
using System.Threading;
using DataLayer;
using DataLayer.Models;
using Loterie_project_2022.Models.Game;
using Microsoft.AspNetCore.Mvc;

namespace Loterie_project_2022.Services
{
    public class GameServices
    {
        private readonly AppDbContext dbContext;

        public GameServices(AppDbContext dbContext)
        {
            this.dbContext = dbContext;

        }


        public void CreateGame()
        {
            var rnd = new Random();
            var randomNumbers = Enumerable.Range(1, 49).OrderBy(x => rnd.Next()).Take(6).ToList();


            dbContext.Games.Add(new Game()
            {
                game_num1 = randomNumbers[0],
                game_num2 = randomNumbers[1],
                game_num3 = randomNumbers[2],
                game_num4 = randomNumbers[3],
                game_num5 = randomNumbers[4],
                game_num6 = randomNumbers[5],
                game_startdate = DateTime.Now,
                game_enddate = DateTime.Now.AddMinutes(5)




            });


            dbContext.SaveChanges();


        }

       
    }
}


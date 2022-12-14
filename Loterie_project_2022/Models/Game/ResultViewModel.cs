using System;
namespace Loterie_project_2022.Models.Game
{
	public class ResultViewModel
	{
        public DateTime gameEnddate { get; set; }

        public int gameNum1 { get; set; }
        public int gameNum2 { get; set; }
        public int gameNum3 { get; set; }
        public int gameNum4 { get; set; }
        public int gameNum5 { get; set; }
        public int gameNum6 { get; set; }
        public int gamePrize { get; set; }

        public int playerNum1 { get; set; }
        public int playerNum2 { get; set; }
        public int playerNum3 { get; set; }
        public int playerNum4 { get; set; }
        public int playerNum5 { get; set; }
        public int playerNum6 { get; set; }

        public int playerPrize { get; set; }

    }
}


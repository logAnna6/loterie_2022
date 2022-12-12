using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{
	public class Game
    {
        [Key]
        public int gameId { get; set; }

		public int game_num1 { get; set; }
        public int game_num2 { get; set; }
        public int game_num3 { get; set; }
        public int game_num4 { get; set; }
        public int game_num5 { get; set; }
        public int game_num6 { get; set; }

        [DefaultValue(10)]
        public int game_prize { get; set; }

        public DateTime game_startdate { get; set; }
        public DateTime game_enddate { get; set; }

        public List<Player> Players { get; set; }

    }
}


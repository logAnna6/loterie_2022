using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace DataLayer.Models
{
	public class Player
	{
        [Key]
        public int playerId{ get; set; }

		public string player_code { get; set; }

        public int player_num1 { get; set; }
        public int player_num2 { get; set; }
        public int player_num3 { get; set; }
        public int player_num4 { get; set; }
        public int player_num5 { get; set; }
        public int player_num6 { get; set; }

        public int player_prize { get; set; }
        public DateTime player_reg_date { get; set; }


        public Game Game { get; set; }
        public int gameId { get; set; }

       
    }
}


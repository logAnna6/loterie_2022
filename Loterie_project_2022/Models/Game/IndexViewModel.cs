using System;
using System.ComponentModel.DataAnnotations;

namespace Loterie_project_2022.Models.Game
{
	public class IndexViewModel
	{


        [StringLength(22, ErrorMessage = "Votre code contient 22 charactères !")]
        public string Code { get; set; }
    }
}


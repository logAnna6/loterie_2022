using System;
using DataLayer.Models;
using Loterie_project_2022.Models.Game;

namespace Loterie_project_2022.Services
{
	public interface IPlayerService
	{
		ShowCodeViewModel CreatePlayer(CreatePlayerViewModel model);
		Game GetLastGame();

    }
}


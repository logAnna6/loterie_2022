﻿using System;
using Loterie_project_2022.Models.Game;

namespace Loterie_project_2022.Services
{
	public interface IPlayerService
	{
		void CreatePlayer(CreatePlayerViewModel model);
	}
}


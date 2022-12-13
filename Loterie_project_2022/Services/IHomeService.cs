using System;
using DataLayer.Models;
using Loterie_project_2022.Models.Game;

namespace Loterie_project_2022.Services
{
	public interface IHomeService
	{
        ResultViewModel Verify(IndexViewModel model);
    }
}


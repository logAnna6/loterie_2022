using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Loterie_project_2022.Models;
using Loterie_project_2022.Services;
using Loterie_project_2022.Models.Game;
using DataLayer.Models;
using System.Numerics;

namespace Loterie_project_2022.Controllers;


	public class PlayerController:Controller
	{
    private readonly IPlayerService playerSvc;

    public PlayerController(IPlayerService svc)
    {
        playerSvc = svc;

    }
        public IActionResult Play()
        {
            return View();
        }


    public IActionResult Create(CreatePlayerViewModel model)
    {
     

        if (ModelState.IsValid == false)
        {
            return View(model);
        }


        var player = playerSvc.CreatePlayer(model);

        return View("code",player);


    }

   




}


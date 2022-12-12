using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Loterie_project_2022.Models;
using Loterie_project_2022.Services;
using Loterie_project_2022.Models.Game;

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
      

        playerSvc.CreatePlayer(model);

        //traitement de la donnée reçu
        return RedirectToAction("index", "game");
    }




}


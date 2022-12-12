using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Loterie_project_2022.Models;
using Loterie_project_2022.Services;

namespace Loterie_project_2022.Controllers;

public class GameController : Controller
{
    private readonly ILogger<GameController> _logger;
    private readonly IGameServices gameSvc;

    public GameController(ILogger<GameController> logger, IGameServices svc)
    {
        _logger = logger;
        gameSvc = svc;

    }
  

    public IActionResult Index()
    {
        gameSvc.CreateGame();
       // Task.Run(gameSvc.CreateGameAsync);
        return View();
    }

    public IActionResult Code()
    {
        return View();
    }

    public IActionResult Result()
    {
        return View();
    }






    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

 
}

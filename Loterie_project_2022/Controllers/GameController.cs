using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Loterie_project_2022.Models;
using Loterie_project_2022.Services;
using Loterie_project_2022.Models.Game;


namespace Loterie_project_2022.Controllers;

public class GameController : Controller
{
    private readonly ILogger<GameController> _logger;
    private readonly IHomeService homeSvc;
    private readonly IPlayerService playerSvc;

    public GameController(ILogger<GameController> logger, IHomeService HSvc, IPlayerService Psvc)
    {
        _logger = logger;
        homeSvc = HSvc;
        playerSvc = Psvc;
   

    }

    
    public IActionResult Index(IndexViewModel model)
    {
        if (ModelState.IsValid == false)
        {
            ViewData["prize"] = playerSvc.GetLastGame().game_prize;
            ViewData["startGame"] = playerSvc.GetLastGame().game_startdate.ToString("o");
            ViewData["endGame"] = playerSvc.GetLastGame().game_enddate.ToString("o");
            return View();
        }

        
        var result = homeSvc.Verify(model);

        return View("result",result);
     
        

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

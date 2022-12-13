using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Loterie_project_2022.Models;
using Loterie_project_2022.Services;
using Loterie_project_2022.Models.Game;
using Microsoft.EntityFrameworkCore;

namespace Loterie_project_2022.Controllers;

public class GameController : Controller
{
    private readonly ILogger<GameController> _logger;
    private readonly IHomeService homeSvc;


    public GameController(ILogger<GameController> logger, IHomeService HSvc)
    {
        _logger = logger;
        homeSvc = HSvc;
   

    }

    
    public IActionResult Index(IndexViewModel model)
    {
        if (ModelState.IsValid == false || model.Code == null)
        {
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

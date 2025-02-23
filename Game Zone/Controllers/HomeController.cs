using System.Diagnostics;
using Game_Zone.Models;
using Microsoft.AspNetCore.Mvc;

namespace Game_Zone.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGamesService _gamesService;

        public HomeController(IGamesService gamesService)
        {
            _gamesService = gamesService;
        }

        public IActionResult Index()
        {
            var games = _gamesService.GetAll();
            return View(games);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

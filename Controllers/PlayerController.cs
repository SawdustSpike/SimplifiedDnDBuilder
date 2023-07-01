using Microsoft.AspNetCore.Mvc;
using Simple_DnD_Builder.Models.Player;

namespace Simple_DnD_Builder.Controllers
{
    public class PlayerController
        : Controller
    {
        
        public IActionResult Index()
        {
            Player.PlayerPurger();
            return (Player.Players.Count == 0) ? RedirectToAction("PlayerCreator") : RedirectToAction("PlayerChooser"); ;
        }
        public IActionResult ViewPlayer()
        {
            Player.PlayerPurger();
            return View(Player.Players[0]) ;
        }
        public IActionResult PlayerChooser() 
        {
            Player.PlayerPurger();
            return View(Player.Players);
        }
        public IActionResult PlayerCreator() 
        {
            Player.PlayerPurger();
            return View(new Player());

        }
        public IActionResult CreatePlayer(Player player) 
        { 
            if (player.PlayerName == null || player.Name== null || player.Gender == null) 
            {
                return RedirectToAction("PlayerCreator");
            }            
            Player.Players.Add(player);
            Player.PlayerPurger();
            return RedirectToAction("ViewPlayer");
        
        }

    }
}

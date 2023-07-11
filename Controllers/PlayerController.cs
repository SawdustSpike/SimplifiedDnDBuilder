using Microsoft.AspNetCore.Mvc;
using Simple_DnD_Builder.Models.Character_Data.Helpers;
using Simple_DnD_Builder.Models.Players;

namespace Simple_DnD_Builder.Controllers
{
    public class PlayerController
        : Controller
    {

        public IActionResult Index()
        {
            PlayerHelper.PlayerPurger();
            return (Player.Players.Count == 0) ? RedirectToAction("PlayerCreator") : RedirectToAction("PlayerChooser"); ;
        }
        public IActionResult ViewPlayer()
        {
            PlayerHelper.PlayerPurger();
            return View(Player.Players[0]);
        }
        public IActionResult PlayerChooser()
        {
            PlayerHelper.PlayerPurger();
            return View(Player.Players);
        }
        public IActionResult PlayerCreator()
        {
            PlayerHelper.PlayerPurger();
            return Player.Players.Count == 0? View(new Player()): View(Player.Players[0]);

        }
        public IActionResult CreatePlayer(Player player)
        {
            if (player.PlayerName == null || player.Name == null || player.Gender == null)
            {
                return RedirectToAction("PlayerCreator");
            }
            switch (player.Gender)
            {
                case "Male":
                    player.ImageURL = "https://lh6.googleusercontent.com/R58vQJ2Mh1Uf1QcsHi4Z9AbRI7Rhl4JBE4OwqNqX3ZWWWEj1dkVmxJzjzVr21S5JihueMFyzdDT2lDGAy3MuFBxZClVectkLtynH-E5v50hSOW9Sot1rqNaOaHDVtq_FPvaVx5W7";
                    break;
                case "Female":
                    player.ImageURL = "https://forgeofmyth.files.wordpress.com/2018/09/dnd_image_001.jpg";
                    break;
                default:
                    player.ImageURL = "https://pbs.twimg.com/media/Ec5pwCeXgAIEdcF.jpg";
                    break;
            }
            //AbilityHelper.AbilityAdder(player);
            //SkillHelper.SkillsAdder(player);
            Player.Players.Add(player);
            PlayerHelper.PlayerPurger();
            return RedirectToAction("ViewPlayer");

        }

    }
}

using Microsoft.AspNetCore.Mvc;
using Simple_DnD_Builder.Models.Players;
using Simple_DnD_Builder.Repositories.Interfaces;

namespace Simple_DnD_Builder.Controllers
{
    public class CharClassController : Controller
    {
        private readonly ICharClassRepository _repo;
        public CharClassController(ICharClassRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            var classes = _repo.GetAllCharClass();
            return View(classes);
        }
       
        [HttpPost]
        public IActionResult AddCharClass(string selectedCharClass)
        {
            Player.Players[0].CharClass = selectedCharClass;
            return RedirectToAction("ViewPlayer", "Player", Player.Players[0]);
        }
        public IActionResult ViewCharClass(string index)
        {
            var charClass = _repo.GetCharClassByIndex(index.ToLower());
            return View(charClass);
        }
    }
}

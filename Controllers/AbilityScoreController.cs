using Microsoft.AspNetCore.Mvc;
using Simple_DnD_Builder.Repositories.Interfaces;

namespace Simple_DnD_Builder.Controllers
{
    public class AbilityScoreController : Controller
    {
        private readonly IAbilityScoreRepository _repo;
        public AbilityScoreController(IAbilityScoreRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            var scores = _repo.GetAllAbilityScores();
            return View(scores);
        }
        public IActionResult ViewAbilityScore(string index)
        {
            var score = _repo.GetAbilityScoreByIndex(index.ToLower());
            return View(score);
        }
    }
}

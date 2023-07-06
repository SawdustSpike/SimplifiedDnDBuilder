using Microsoft.AspNetCore.Mvc;
using Simple_DnD_Builder.Repositories.Interfaces;

namespace Simple_DnD_Builder.Controllers
{
    public class SkillController : Controller
    {
        private readonly ISkillRepository _repo;
        public SkillController(ISkillRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index(string index)
        {
            var score = _repo.GetSkillByIndex(index.ToLower());
            return View(score);
        }
    }
}

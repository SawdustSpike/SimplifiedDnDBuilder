using Microsoft.AspNetCore.Mvc;
using Simple_DnD_Builder.Repositories.Interfaces;

namespace Simple_DnD_Builder.Controllers
{
    public class RaceController : Controller
    {
       private readonly IRaceRepository _repo;

        public RaceController(IRaceRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            var races = _repo.GetAllRaces();
            return View(races);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Simple_DnD_Builder.Models.Players;
using Simple_DnD_Builder.Repositories.Interfaces;

namespace Simple_DnD_Builder.Controllers
{
    public class AlignmentController : Controller
    {
        private readonly IAlignmentRepository _repo;
        public AlignmentController(IAlignmentRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            var alignments = _repo.GetAllAlignments();
            return View(alignments);
        }

        [HttpPost]
        public IActionResult AddAlignment(string selectedAlignment)
        {
            Player.Players[0].Alignment = selectedAlignment;
            return RedirectToAction("ViewPlayer", "Player", Player.Players[0]);
        }
        public IActionResult ViewAlignment(string index)
        {
            var Alignment = _repo.GetAlignmentByIndex(index.ToLower());
            return View(Alignment);
        }
    }
}

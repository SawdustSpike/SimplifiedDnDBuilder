﻿using Microsoft.AspNetCore.Mvc;
using Simple_DnD_Builder.Models.Players;
using Simple_DnD_Builder.Models.Races;
using Simple_DnD_Builder.Repositories.Interfaces;
using System.Numerics;

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
        [HttpPost]
        public IActionResult AddRace(string selectedRace)
        {
            if (Player.Players[0].Race != null) _repo.DecreasePlayerAbilityScore(Player.Players[0]);
            _repo.IncreasePlayerAbilityScore(Player.Players[0], selectedRace);        
            Player.Players[0].Race = selectedRace;
            return RedirectToAction("ViewPlayer", "Player", Player.Players[0]);
        }
        public IActionResult ViewRace(string index)
        {
            var race = _repo.GetRaceByIndex(index.ToLower());
            return View(race);
        }
    }
}

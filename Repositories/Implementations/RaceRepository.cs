using Newtonsoft.Json.Linq;
using Simple_DnD_Builder.Models.Players;
using Simple_DnD_Builder.Models.Races;
using Simple_DnD_Builder.Repositories.Interfaces;
using System;

namespace Simple_DnD_Builder.Repositories.Implementations
{
    public class RaceRepository : IRaceRepository
    {
        public List<Race> GetAllRaces()
        {
            var races = new List<Race>();           
            foreach (var race in Race.Races)
            {
                races.Add(GetRaceByIndex(race));
            }
            return races;
        }

        public Race GetRaceByIndex(string index)
        {
            var race = HttpHelper.Helper("races", index);
            return new Race(
                race["name"]?.ToString() ?? "None",
                race["speed"]?.Value<int>() ?? 0,
                race["alignment"]?.ToString() ?? "None",
                race["age"]?.ToString() ?? "None",
                race["size"]?.ToString() ?? "None",
                race["size_description"]?.ToString() ?? "None",
                race["language_desc"]?.ToString() ?? "None",
                race["url"]?.ToString() ?? "None"
                );

        }
        public void IncreasePlayerAbilityScore(Player player, string index)
        {           
            var race = HttpHelper.Helper("races", index);
            JArray scores = (JArray)race["ability_bonuses"];
            foreach (var score in scores)
            {
                player.AbilityScores[score["ability_score"]["index"].ToString()] += (int)score["bonus"];
            }
        }
        public void DecreasePlayerAbilityScore(Player player)
        {
            var race = HttpHelper.Helper("races", player.Race);
            JArray scores = (JArray)race["ability_bonuses"];
            foreach (var score in scores)
            {
                player.AbilityScores[score["ability_score"]["index"].ToString()] -= (int)score["bonus"];
            }
        }
    }
}

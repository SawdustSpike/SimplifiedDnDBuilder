using Newtonsoft.Json.Linq;
using Simple_DnD_Builder.Models.Races;
using Simple_DnD_Builder.Repositories.Interfaces;

namespace Simple_DnD_Builder.Repositories.Implementations
{
    public class RaceRepository : IRaceRepository
    {
        public List<Race> GetAllRaces()
        {
            var races = new List<Race>();
            var racs = new string[]
            {
                "dragonborn",
"dwarf",
"elf",
"gnome",
"half-elf",
"half-orc",
"halfling",
"human",
"tiefling"
            };
            foreach (var race in racs)
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
    }
}

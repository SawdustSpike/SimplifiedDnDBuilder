using Simple_DnD_Builder.Models.Players;
using Simple_DnD_Builder.Models.Races;

namespace Simple_DnD_Builder.Repositories.Interfaces
{
    public interface IRaceRepository
    {
        public List<Race> GetAllRaces();
        public Race GetRaceByIndex(string index);
        public void IncreasePlayerAbilityScore(Player player, string index);
        public void DecreasePlayerAbilityScore(Player player);

    }
}

using Simple_DnD_Builder.Models.Players;

namespace Simple_DnD_Builder.Models.Character_Data.Helpers
{
    public class AbilityHelper
    {
        public static Dictionary<string, int> AbilityAdder()
        {
            var abilityScores = new Dictionary<string, int>();
            foreach(var ability in AbilityScore.Abilities)
            {
                abilityScores[ability] = 10;
            }
            return abilityScores;
        }
    }
}

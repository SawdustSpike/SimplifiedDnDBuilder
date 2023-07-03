using Simple_DnD_Builder.Models.Players;

namespace Simple_DnD_Builder.Models.Character_Data.Helpers
{
    public class AbilityHelper
    {
        public static void AbilityAdder(Player player)
        {
            foreach(var ability in AbilityScore.Abilities)
            {
                player.AbilityScores[ability] = 10;
            }
            
        }
    }
}

using Simple_DnD_Builder.Models.Players;

namespace Simple_DnD_Builder.Models.Character_Data.Helpers
{
    public class SkillHelper
    {
        public static void SkillsAdder(Player player)
        {
            foreach(var skill in Skill.Skills)
            {
                player.SkillScores.Add(skill, 0);
            }
            
        }
    }
}

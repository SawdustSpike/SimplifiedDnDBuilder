using Simple_DnD_Builder.Models.Players;

namespace Simple_DnD_Builder.Models.Character_Data.Helpers
{
    public class SkillHelper
    {
        public static Dictionary<string, int> SkillsAdder()
        {
            var skillScores = new Dictionary<string, int>();
            foreach(var skill in Skill.Skills)
            {
                skillScores.Add(skill, 0);
            }
            return skillScores;
        }
    }
}

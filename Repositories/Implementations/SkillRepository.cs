using Newtonsoft.Json.Linq;
using Simple_DnD_Builder.Models;
using Simple_DnD_Builder.Repositories.Interfaces;

namespace Simple_DnD_Builder.Repositories.Implementations
{
    public class SkillRepository : ISkillRepository
    {
        public List<Skill> GetAllSkills()
        {
            var skillList = new List<Skill>();
            
            foreach (var skill in Skill.Skills)
            {
                skillList.Add(GetSkillByIndex(skill));
            }
            return skillList;
        }

        public Skill GetSkillByIndex(string index)
        {
            var repo = new AbilityScoreRepository();
            var skill = HttpHelper.Helper("skills", index);
            var descString = skill["desc"]?.ToString().Replace("[", "").Replace("]", "").Replace("\"", "") ?? "None";
            // JProperty abilityScoreProperty = skill.Property("ability_score");
            //string ind = abilityScoreProperty["index"]?.ToString() ?? "dex";
            return new Skill(
                skill["name"]?.ToString() ?? "None",
                descString,
                repo.GetAbilityScoreByIndex(skill["ability_score"]["index"].ToString())
            );

        }
    }
}

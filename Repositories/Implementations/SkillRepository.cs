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
            var skills = new string[]
            {
"acrobatics",
"animal-handling",
"arcana",
"athletics",
"deception",
"history",
"insight",
"intimidation",
"investigation",
"medicine",
"nature",
"perception",
"performance",
"persuasion",
"religion",
"sleight-of-hand",
"stealth",
"survival"
            };
            foreach (var skill in skills)
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

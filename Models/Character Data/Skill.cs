using System.Runtime.CompilerServices;

namespace Simple_DnD_Builder.Models
{
    public class Skill
    {
        static public readonly List<string> Skills = new List<string>()
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
        public Skill(string name, string desc, AbilityScore ability)
        {
            Name = name;
            Desc = desc;
            Ability = ability;
        }
        public Skill(string name, string desc)
        {
            Name = name;
            Desc = desc;
        }
        public string Name { get; set; }
        public string Desc { get; set; }
        public AbilityScore Ability { get; set; }

       
    }

}


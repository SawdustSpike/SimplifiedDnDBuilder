using System.Runtime.CompilerServices;

namespace Simple_DnD_Builder.Models
{
    public class Skill
    {
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

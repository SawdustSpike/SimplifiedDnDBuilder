using Simple_DnD_Builder.Models.Character_Data;
using Simple_DnD_Builder.Models.Class;
using Simple_DnD_Builder.Models.Races;

namespace Simple_DnD_Builder.Models.Player
{
    public class Player
    {
        public string Name { get; set; }
        public string PlayerName { get; set; }
        public Race Race { get; set; }
        public CharClass CharClass { get; set; }
        public Dictionary<AbilityScore, int> AbilityScores { get; set; } 
        public Alignment Alignment { get; set; }
        public List<Language> Languages { get; set; }
        public Dictionary<Skill, int> SkillScores { get; set;}

    }
}

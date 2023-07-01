using Simple_DnD_Builder.Models.Character_Data;
using Simple_DnD_Builder.Models.Class;
using Simple_DnD_Builder.Models.Races;

namespace Simple_DnD_Builder.Models.Player
{
    public class Player
    {
        public static List<Player> Players = new List<Player>();
        public Player()
        {
          
        }
        public string Name { get; set; }
        public string PlayerName { get; set; }
        public string Gender { get; set; }
        public Race Race { get; set; }
        public CharClass CharClass { get; set; }
        public Dictionary<AbilityScore, int> AbilityScores { get; set; }
        public Alignment Alignment { get; set; }
        public List<Language> Languages { get; set; }
        public Dictionary<Skill, int> SkillScores { get; set; }
        public string ImageURL { get; set; }

        public static void PlayerPurger()
        {
           for(int i = Players.Count - 1; i > 0; i--)
            {
                Players.RemoveAt(i);
            }
            
        }

    }
}

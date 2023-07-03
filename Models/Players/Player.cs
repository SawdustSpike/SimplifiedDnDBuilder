﻿using Simple_DnD_Builder.Models.Character_Data;
using Simple_DnD_Builder.Models.Class;
using Simple_DnD_Builder.Models.Races;

namespace Simple_DnD_Builder.Models.Players
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
        public Dictionary<string, int> AbilityScores { get; set; } = new Dictionary<string, int>();
        public Alignment Alignment { get; set; }
        public List<Language> Languages { get; set; }
        public Dictionary<string, int> SkillScores { get; set; } = new Dictionary<string, int>();
        public string ImageURL { get; set; }

        

    }
}
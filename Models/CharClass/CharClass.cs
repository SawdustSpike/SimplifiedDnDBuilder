namespace Simple_DnD_Builder.Models.Class
{
    public class CharClass
    {
        public static readonly string[] Classs = new string[] {
                "barbarian",
                "bard",
                "cleric",
                "druid",
                "fighter",
                "monk",
                "paladin",
                "ranger",
                "rogue",
                "sorcerer",
                "warlock",
                "wizard"};
        public CharClass(string name, int hitDice) 
        {
            Name = name;
            HitDice = hitDice;
        }
        public int Level { get; set; }
        public string Name { get; set; }
        public int HitDice { get; set; }
        public AbilityScore[] SavingThrows { get; set; }

    }
}

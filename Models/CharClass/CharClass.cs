namespace Simple_DnD_Builder.Models.CharClass
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
        public CharClass(string name, int hitDice, List<string> savingthrows) 
        {
            Name = name;
            HitDice = hitDice;
            SavingThrows = savingthrows.ToArray();
        }
        public int Level { get; set; }
        public string Name { get; set; }
        public int HitDice { get; set; }
        public string[] SavingThrows { get; set; }

    }
}

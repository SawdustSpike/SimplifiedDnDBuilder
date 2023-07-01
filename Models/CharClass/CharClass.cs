namespace Simple_DnD_Builder.Models.Class
{
    public class CharClass
    {
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

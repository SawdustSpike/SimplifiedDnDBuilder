namespace Simple_DnD_Builder.Models
{
    public class AbilityScore
    {
       static public readonly List<string> Abilities = new List<string>()
        {
            "cha","con","dex","int", "str", "wis"
        };
        public AbilityScore(string name, string description, string abbr)
        {
            this.Name = name;
            this.Description = description;
            this.Abbr = abbr;
            
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Abbr { get; set; }
        public string[] Skills {  get; set; }

       


    }
}

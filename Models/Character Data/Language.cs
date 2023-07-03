namespace Simple_DnD_Builder.Models.Character_Data
{
    public class Language
    {
        public static readonly string[] Languages = new string[]
           {
                "abyssal",
"celestial",
"common",
"deep-speech",
"draconic",
"dwarvish",
"elvish",
"giant",
"gnomish",
"goblin",
"halfling",
"infernal",
"orc",
"primordial",
"sylvan",
"undercommon"
           };
        public Language(string name, string desc, string type)
        {
            Name = name;
            Desc = desc;
            Type = type;
        }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Type { get; set; }
    }
}

namespace Simple_DnD_Builder.Models.Races
{
    public class Race
    {
        public static readonly string[] Races = new string[]
            
            {
                "dragonborn",
"dwarf",
"elf",
"gnome",
"half-elf",
"half-orc",
"halfling",
"human",
"tiefling"
            };
    public Race(string name, int speed, string alignment, string age, string size, string sizeDecription, string languageDescription, string url)
        {
            Name = name;
            Speed = speed;
            Alignment = alignment;
            Age = age;
            Size = size;
            SizeDescription = sizeDecription;
            LanguageDescription = languageDescription;
            Url = url;
        }
     
    
        public string Name { get; set; }
        public int Speed { get; set; }
        public string Alignment { get; set; }
        public string Age { get; set; }
        public string Size { get; set; }
        public string SizeDescription { get; set; }
        public string LanguageDescription { get; set; }
        public string Url { get; set; }

    }
}

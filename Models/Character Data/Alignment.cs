namespace Simple_DnD_Builder.Models.Character_Data
{
    public class Alignment
    {
       public readonly static string[] Alignments = new string[] {
           "chaotic-neutral",
            "chaotic-evil",
            "chaotic-good",
            "lawful-neutral",
            "lawful-evil",
            "lawful-good",
            "neutral",
            "neutral-evil",
            "neutral-good"};
        public Alignment(string index, string name, string abbr, string desc, string url)
        {
            Index = index;
            Name = name;
            Abbr = abbr;
            Desc = desc;
            Url = url;
        }
        public string Name { get; set; }
        public string Abbr { get; set; }
        public string Desc { get; set; }
        public string Url { get; set; }
        public string Index { get; set; }
    }
}

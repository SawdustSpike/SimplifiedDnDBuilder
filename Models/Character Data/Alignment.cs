namespace Simple_DnD_Builder.Models.Character_Data
{
    public class Alignment
    {
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

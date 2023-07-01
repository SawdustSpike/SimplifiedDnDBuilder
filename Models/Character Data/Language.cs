namespace Simple_DnD_Builder.Models.Character_Data
{
    public class Language
    {
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

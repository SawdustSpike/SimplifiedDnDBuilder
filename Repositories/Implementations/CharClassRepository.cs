using Newtonsoft.Json.Linq;
using Simple_DnD_Builder.Models.Class;
using Simple_DnD_Builder.Repositories.Interfaces;

namespace Simple_DnD_Builder.Repositories.Implementations
{
    public class CharClassRepository : ICharClassRepository
    {
        public List<CharClass> GetAllCharClass()
        {
            var classes = new List<CharClass>();
            var classs = new string[] {
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
            foreach(var a  in classs)
            {
                classes.Add(GetCharClassByIndex(a));
            }
            return classes;
        }

        public CharClass GetCharClassByIndex(string index)
        {
            var charClass = HttpHelper.Helper("classes", index);
            return new CharClass(
                charClass["name"]?.ToString() ?? "None",
                charClass["hit_die"]?.Value<int>() ?? 0
                );
        }
    }
}

using Newtonsoft.Json.Linq;
using Simple_DnD_Builder.Models.CharClass;

using Simple_DnD_Builder.Repositories.Interfaces;

namespace Simple_DnD_Builder.Repositories.Implementations
{
    public class CharClassRepository : ICharClassRepository
    {
        public List<CharClass> GetAllCharClass()
        {
            var classes = new List<CharClass>();           
            foreach(var a  in CharClass.Classs)
            {
                classes.Add(GetCharClassByIndex(a));
            }
            return classes;
        }

        public CharClass GetCharClassByIndex(string index)
        {
            var charClass = HttpHelper.Helper("classes", index);
            var savingThrows = (JArray)charClass["saving_throws"];
            var abil = new List<string>();
            foreach (var save in savingThrows)
            {
                abil.Add((string)save["index"]);
            }
            return new CharClass(
                charClass["name"]?.ToString() ?? "None",
                charClass["hit_die"]?.Value<int>() ?? 0,
                abil
                );
        }
    }
}

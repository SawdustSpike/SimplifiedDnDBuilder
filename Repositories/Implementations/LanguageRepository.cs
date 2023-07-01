using Simple_DnD_Builder.Models.Character_Data;
using Simple_DnD_Builder.Repositories.Interfaces;

namespace Simple_DnD_Builder.Repositories.Implementations
{
    public class LanguageRepository : ILanguageRepository
    {
        public Language GetLanguageByIndex(string index)
        {
            var lang = HttpHelper.Helper("languages", index);
            return new Language
                (
                lang["name"]?.ToString() ?? "None",
                lang["desc"]?.ToString() ?? "None",
                lang["type"]?.ToString() ?? "None"
                ); 
            ;

        }

        public List<Language> GetAllLanguages()
        {
            var languages = new List<Language>();
            var langs = new string[]
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
            foreach ( var lan in langs )
            {
                languages.Add(GetLanguageByIndex(lan));
            }
            return languages;
        }
    }
}

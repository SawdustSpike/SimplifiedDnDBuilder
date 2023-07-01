using Simple_DnD_Builder.Models.Character_Data;

namespace Simple_DnD_Builder.Repositories.Interfaces
{
    public interface ILanguageRepository
    {
        public List<Language>GetAllLanguages();
        public Language GetLanguageByIndex(string index);
    }
}



using Simple_DnD_Builder.Models.CharClass;

namespace Simple_DnD_Builder.Repositories.Interfaces
{
    public interface ICharClassRepository
    {
        public List<CharClass> GetAllCharClass();
        public CharClass GetCharClassByIndex(string index);
    }
}

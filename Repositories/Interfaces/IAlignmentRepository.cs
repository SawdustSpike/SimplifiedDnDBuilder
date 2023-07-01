using Simple_DnD_Builder.Models.Character_Data;

namespace Simple_DnD_Builder.Repositories.Interfaces
{
    public interface IAlignmentRepository
    {
        public List<Alignment>GetAllAlignments();
        public Alignment GetAlignmentByIndex(string index);
    }
}

using Simple_DnD_Builder.Models;

namespace Simple_DnD_Builder.Repositories.Interfaces
{
    public interface ISkillRepository
    {
        public List<Skill> GetAllSkills();
        public Skill GetSkillByIndex(string index);
    }
}

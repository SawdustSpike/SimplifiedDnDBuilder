using Simple_DnD_Builder.Models;

namespace Simple_DnD_Builder.Repositories.Interfaces
{
    public interface IAbilityScoreRepository
    {
        public List<AbilityScore> GetAllAbilityScores();
        public AbilityScore GetAbilityScoreByIndex (string index);
       
    }
}

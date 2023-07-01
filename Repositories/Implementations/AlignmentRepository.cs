using Simple_DnD_Builder.Models;
using Simple_DnD_Builder.Models.Character_Data;
using Simple_DnD_Builder.Repositories.Interfaces;

namespace Simple_DnD_Builder.Repositories.Implementations
{
    public class AlignmentRepository : IAlignmentRepository
    {
        public Alignment GetAlignmentByIndex(string index)
        {
            //throw new NotImplementedException();
            var alignment = HttpHelper.Helper("alignments", index);
            //var descString = ability["desc"].ToString().Replace("[", "").Replace("]", "").Replace("\"", "");

            return new Alignment(
                alignment["index"]?.ToString() ?? "None",
                alignment["name"]?.ToString() ?? "None",
                alignment["abbreviation"]?.ToString() ?? "None",
                alignment["desc"]?.ToString() ?? "None",
                alignment["url"]?.ToString() ?? "None"
                ); ;
        }

        public List<Alignment> GetAllAlignments()
        {
            var alignments = new List<Alignment>();
            var alis = new string[] {"chaotic-neutral",
            "chaotic-evil",
            "chaotic-good",
            "lawful-neutral",
            "lawful-evil",
            "lawful-good",
            "neutral",
            "neutral-evil",
            "neutral-good"};
            foreach (var a in alis)
            {
                alignments.Add(GetAlignmentByIndex(a));
            }
            return alignments;

        }
    }
}

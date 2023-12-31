﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Simple_DnD_Builder.Models;
using Simple_DnD_Builder.Repositories.Interfaces;
using System;
using static System.Formats.Asn1.AsnWriter;

namespace Simple_DnD_Builder.Repositories.Implementations
{
    public class AbilityScoreRepository : IAbilityScoreRepository
    {
        
        public AbilityScore GetAbilityScoreByIndex(string index)
        {
            //throw new NotImplementedException();
            var ability = HttpHelper.Helper("ability-scores", index);
            var descString = ability["desc"]?.ToString().Replace("[", "").Replace("]", "").Replace("\"", "") ?? "None";
            //var descArray = descString.Split(new[] { '.', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return new AbilityScore(
                ability["full_name"]?.ToString() ?? "None", 
                descString, 
                ability["name"]?.ToString() ?? "None"
                );   
        }

        public List<AbilityScore> GetAllAbilityScores()
        {
            
            var abilities = new List<AbilityScore>();
            foreach (var index in AbilityScore.Abilities)
            {
                var ability = HttpHelper.Helper("ability-scores", index);
                var descString = ability["desc"].ToString().Replace("[", "").Replace("]","").Replace("\"", "");
                
                abilities.Add(new AbilityScore(
                    ability["full_name"].ToString(),
                    descString,
                    ability["name"].ToString()
                    ));
            }
            return abilities;
        }
        
    }
}

using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Suggestions
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public string Duid { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int SuggestionTypeid { get; set; }
        public int Operatorid { get; set; }
        public int SuggestionStatusid { get; set; }

        public virtual Operator Operator { get; set; }
        public virtual SuggestionStatus SuggestionStatus { get; set; }
        public virtual SuggestionType SuggestionType { get; set; }
    }
}

using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace sykeplayer_1.Models
{
    public class viewModel
    {
        public List<Questions> QuestionList { get; set; }
        
        public Questions Questions { get; set; }
        
        public List<Character> Characters { get; set; }

        public string Id { get; set; }
        
        public int Version { get; set; }
        
        public string Description { get; set; }
    }
}
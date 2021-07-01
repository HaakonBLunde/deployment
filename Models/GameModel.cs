using System;
using System.Collections.Generic;

namespace sykeplayer_1.Models
{
    public class GameModel
    {
        
        public string DisplayName { get; set; }
        public string Id { get; set; }
        
        public int MaxPoints { get; set; }

        public string Description { get; set; }
        
        public DateTime LastModified { get; set; }
        
        public int Version { get; set; }
        
        //public List<string> Characters { get; set; }
        
        public virtual ICollection<Questions> QuestionsCollection { get; set; }
        
        public virtual ICollection<Character> Characters { get; set; }

        //public List<Character> Characters { get; set; }

        public bool Visible { get; set; }
        
        public string GoodEnd { get; set; }
        
        public string BadEnd { get; set; }
        
        public string MediumEnd { get; set; }
        //Har ikke tid hacky løsning
        /*
        public Character Char1 { get; set; }
        
        public Character Char2 { get; set; }
        
        public Character Char3 { get; set; }
        
        public Character Char4 { get; set; }
        
        public Character Char5 { get; set; }*/
        
    }
}
using System.Collections.Generic;

namespace sykeplayer_1.Models
{
    public class Character
    {
        public string Id { get; set; }
        
        public string Description { get; set; }
        
        public string ImageUrl { get; set; }

        public virtual ICollection<GameModel> GameModel { get; set; }
    }
}
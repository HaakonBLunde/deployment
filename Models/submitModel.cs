using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace sykeplayer_1.Models
{
    public class submitModel
    {
      
        public List<Questions> QuestionList { get; set; }
        
        public Questions Questions { get; set; }
        
        public GameModel GameModel { get; set; }

        public List<string> IdOfCharacters { get; set; }

        public List<string> ImageURLs { get; set; }

        public void GetFileNames()
        {
            var filenameList = new List<string>();
            foreach (var fileName in this.ImageURLs)
            {
                filenameList.Add(fileName.Split("/").Last());
            }

            this.ImageURLs = filenameList;
        }
    }
}
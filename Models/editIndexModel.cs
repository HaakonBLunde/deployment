using System.Collections.Generic;

namespace sykeplayer_1.Models
{
    public class editIndexModel
    {
        public IndexInfo IndexInfo { get; set; }

        public List<string> Images { get; set; }
        
        public void CorrectPaths()
        {
            var fixedList = new List<string>();
            foreach (var filePath in this.Images)
            {
                var fixedString = filePath.Remove(0, 7);
                fixedList.Add(fixedString);
            }

            this.Images = fixedList;
        }
    }
}
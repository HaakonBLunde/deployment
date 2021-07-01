using System.Collections.Generic;

namespace sykeplayer_1.Models
{
    public class FileModel
    {
        public List<string> FilePaths { get; set; }

        public void CorrectPaths()
        {
            var fixedList = new List<string>();
            foreach (var filePath in this.FilePaths)
            {
                var fixedString = filePath.Remove(0, 7);
                fixedList.Add(fixedString);
            }

            this.FilePaths = fixedList;
        }
    }
}
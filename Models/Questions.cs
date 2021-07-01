using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text.Unicode;
using System.Xml.XPath;
using Microsoft.AspNetCore.Html;

namespace sykeplayer_1.Models
{
    public class Questions
    {
        public Questions(){}
        
        public Questions(int number, string question, string answer1, string answer2, string answer3, string answer4,
            int next1, int next2, int next3, int next4, string image)
        {
            this.Nr = number;
            this.Question = question;
            this.Answer1 = answer1;
            this.Answer2 = answer2;
            this.Answer3 = answer3;
            this.Answer4 = answer4;
            this.Next1 = next1;
            this.Next2 = next2;
            this.Next3 = next3;
            this.Next4 = next4;
            this.Image = image;
        }
        
        public string Id { get; set; }
        public int Nr { get; set; }
        
        public string Question { get; set; }
        
        public string Answer1 { get; set; }

        public string Answer2 { get; set; }
        
        public string Answer3 { get; set; }
        
        public string Answer4 { get; set; }
        
        public int Next1 { get; set; }
        
        public int Next2 { get; set; }
        
        public int Next3 { get; set; }
        
        public int Next4 { get; set;}
        
        public string Image { get; set; }
        
        public int Points1 { get; set; }
        
        public int Points2 { get; set; }
        
        public int Points3 { get; set; }
        
        public int Points4 { get; set; }
        
        public string Background { get; set; }

        public enum QuestionType
        {
            Standard,
            Character,
            TextBox,
            LastQuestion,
            Quiz
        }
        
        public QuestionType Type { get; set; }
        
        public GameModel GameModel { get; set; }
        
        public string AudioURL { get; set; }
        
    }
}
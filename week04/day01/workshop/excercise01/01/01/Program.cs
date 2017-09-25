using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    public struct PostIt
    {
        public string BackgroundColor;
        public string Text;
        public string TextColor;
    }

    class Program
    {
        static PostIt Define (PostIt paper, string backgroundColor, string text, string textColor)
        {
            paper.BackgroundColor = backgroundColor;
            paper.Text = text;
            paper.TextColor = textColor;
            return paper;
        }

        static void Main(string[] args)
        {
            PostIt paper1 = new PostIt();
            PostIt paper2 = new PostIt();
            PostIt paper3 = new PostIt();

            Define(paper1, "Orange", "Idea1", "Blue");
            Define(paper2, "Pink", "Awesome", "Black");
            Define(paper3, "Yellow", "Superb!", "Green");
        }
    }
}

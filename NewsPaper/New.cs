using System;
using System.Collections.Generic;
using System.Text;

namespace New
{
    public class New
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Writer { get; set; }

        public New(string title, string text, string writer)
        {
            Title = title;
            Text = text;
            Writer = writer;
        }

        public void Edit(string newText)
        {
            Text = newText;
        }
        public void ChangeWriter(string newWriter)
        {
            Writer = newWriter;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return string.Format($"{Title} - {Text}: {Writer}");
        }
    }
}

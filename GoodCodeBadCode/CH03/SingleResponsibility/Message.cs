using System;
using System.Collections.Generic;
using System.Text;

namespace GoodCodeBadCode.CH03.SingleResponsibility
{
    public struct Message
    {
        public string Title { get; }
        public string Text { get; }

        public Message(string title, string text)
        {
            Title = title;
            Text = text;
        }
    }
}

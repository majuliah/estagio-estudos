using System;
using System.Collections.Generic;

namespace StringBuilder.Entities
{
    class Comments 
    {
        public string Text  { get; set; }

        public Comments(){}
        public Comments(string text)
        {
            Text = text;
        }
    }
}
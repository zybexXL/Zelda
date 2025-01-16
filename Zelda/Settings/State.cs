using System;
using System.Collections.Generic;
using System.Drawing;

namespace Zelda
{
    public class State : ConfigFile
    {
        public List<TabExpression> Tabs { get; set; } = new List<TabExpression>();
        public int CurrentTab { get; set; } = 0;
        public int OutputTab { get; set; } = 0;
        public bool FunctionHelper { get; set; } = true;
        public bool LineWrap { get; set; } = false;
        public bool Whitespace { get; set; } = false;
        public bool TableShowAll { get; set; } = false;
        public List<string> TableFields { get; set; } = new List<string>();
        public int Zoom { get; set; } = 0;
        public string Playlist { get; set; }
        public string Filename { get; set; }
        public Rectangle Dimensions { get; set; } = Rectangle.Empty;
        public bool Maximized { get; set; } = false;
        public int SplitPosition { get; set; } = 0;

        public State() { }

        public static State Load()
        {
            return Load<State>(Constants.StateFile);
        }

        public bool Save()
        {
            return Save(Constants.StateFile);
        }
    }

    public class TabExpression
    {
        public string name { get; set; }
        public string content { get; set; }
        public int position { get; set; }
        public string linkedField { get; set; }

        public TabExpression() { }

        public TabExpression(string title, string text, int pos, string field = null)
        {
            name = title;
            content = text;
            position = pos;
            linkedField = field;
        }
    }
}

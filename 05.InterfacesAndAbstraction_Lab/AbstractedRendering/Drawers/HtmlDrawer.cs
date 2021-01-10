using AbstractedRendering.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AbstractedRendering.Drawers
{
    class HtmlDrawer : IDrawer
    {
        private string path;
        private StringBuilder result;

        public HtmlDrawer(string path)
        {
            this.path = path;
            result = new StringBuilder();
        }

        public void Write(string input)
        {
            using (StreamWriter writer = new StreamWriter(path + ".html", false))
            {
                result.Append(input);
                writer.Write($"<html><head><body><h1>Best Game!!!</h1><p>${result.ToString()}</p></body></head></html>");
            }
        }

        public void WriteLine(string input)
        {
            using (StreamWriter writer = new StreamWriter(path + ".html", false))
            {
                result.Append(input);
                writer.Write($"<html><head><body><h1>Best Game!!!</h1><p>${result.ToString()}</p></body></head></html>");
            }
        }
    }
}

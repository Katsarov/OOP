using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractedRendering.Contracts
{
    public interface IDrawer
    {
        void Write(string input);

        void WriteLine(string input);
    }
}

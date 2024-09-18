using NumberGame.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame.Main.Classes
{
    internal class OutputConsole : IOutput
    {
        public void Output(string text)
        {
            Console.WriteLine(text);
        }




    }
}

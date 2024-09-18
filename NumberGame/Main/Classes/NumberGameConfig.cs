using NumberGame.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame.Main.Classes
{
    internal class NumberGameConfig
    {
        public int Min { get; set; } = 1;
        public int Max { get; set; } = 10;
        public int Attempts { get; set; } = 3;
    }
}

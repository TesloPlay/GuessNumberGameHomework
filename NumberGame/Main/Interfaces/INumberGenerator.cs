using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame.Main.Interfaces
{
    internal interface INumberGenerator
    {
        public int Generate(int min, int max);
    }
}

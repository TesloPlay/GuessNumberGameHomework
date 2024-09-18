using NumberGame.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame.Main.Classes
{
    internal class NumberGenerator : INumberGenerator
    {
        private Random _random;
        public int Generate(int min, int max)
        {
            return _random.Next(min, max);
        }

        public NumberGenerator() 
        { 
            _random = new Random();
        }



    }
}

using NumberGame.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame.Main.Classes
{
    internal class InputConsole : IInput
    {
        public int Input()
        {
            while (true)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    return number;
                }
                catch
                {
                    Console.WriteLine("Введёное значение не является целым числом. Попробуйте ещё раз.");
                }
            }
        }





    }
}

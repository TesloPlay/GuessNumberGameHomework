using NumberGame.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame.Main.Classes
{
    internal class GameNumber : IGame
    {
        private IOutput _output;

        private IInput _input;
        private NumberGameConfig _config;
        private INumberGenerator _numberGenerator;

        public GameNumber(IOutput output, IInput input, NumberGameConfig config, INumberGenerator numberGenerator)
        {
            _output = output;
            _input = input;
            _config = config;
            _numberGenerator = numberGenerator;
        }

        public void Run()
        {
            int inputNumber = 0;
            while(true)
            {
                _output.Output("Главное меню:\n[1] Начать.\n[2] Настроить.\n[3] Выход.");
                inputNumber = _input.Input();
                switch (inputNumber)
                {
                    case 1:
                        Play();
                        break;
                    case 2:
                        Settings();
                        break;
                    case 3:
                        return;
                    default:
                        _output.Output("Данного пункта нет в меню. Введите заново.");
                        break;
                }
            }
        }

        private void Play()
        {
            int attempts = _config.Attempts;
            int number = _numberGenerator.Generate(_config.Min, _config.Max);

            _output.Output($"Угадайте целое число, загаданное в промежутке от {_config.Min} до {_config.Max}. Всего попыток:{attempts}.");
            while (attempts > 0)
            {
                int playerNumber = _input.Input();
                if (playerNumber == number)
                {
                    _output.Output($"Правильно. Это было число {number}");
                    return;
                }
                else if (playerNumber > number)
                {
                    _output.Output($"Неверно. Ваше число больше загаданного. Всего попыток:{--attempts}.");
                } else
                {
                    _output.Output($"Неверно. Ваше число меньше загаданного. Всего попыток:{--attempts}.");
                }
            }

            _output.Output("Игра окончена. Попытки закончились.");
            return;
        }
        private void Settings()
        {
            while (true)
            {
                _output.Output($"Настройки:\n[1] Максимальное значение.\n[2] Минимальное значение.\n[3] Количество попыток.\n[4] Восстановить настройки по умолчанию.\n[5] В главное меню.");
                int inputNumber = _input.Input();
                switch (inputNumber)
                {
                    case 1:
                        _output.Output("Введите целое максимальное значение для загаданного числа:");
                        _config.Max = _input.Input();
                        break;
                    case 2:
                        _output.Output("Введите целое минимальное значение для загаданного числа:");
                        _config.Min = _input.Input();
                        break;
                    case 3:
                        _output.Output("Введите количество попыток для игрока:");
                        _config.Attempts = _input.Input();
                        break;
                    case 4:
                        _config.Max = 10;
                        _config.Min = 1;
                        _config.Attempts = 3;
                        _output.Output("Настройки восстановлены по умолчанию.");
                        break;
                    case 5:
                        return;
                        break;
                    default:
                        _output.Output("Данного пункта нет в меню. Введите заново.");
                        break;
                }
            }
        }





    }
}

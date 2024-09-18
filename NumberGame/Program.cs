using NumberGame.Main.Classes;

namespace NumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new GameNumber(new OutputConsole(), new InputConsole(), new NumberGameConfig(), new NumberGenerator());
            game.Run();
        }
    }
}

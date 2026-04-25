/*
 * Author: Ryan MacDonald
 * Date: 20/04/2026
 * Description: This is my own mini version of the game "Rogue".
 */
namespace MiniRogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Initialize();
            game.Run();
        }
    }
}

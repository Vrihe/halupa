using X_O;

namespace main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            Logic game = new Logic();
            // Main loop
            while (isRunning)
            {
                game.Update();
            }
        }
    }
}

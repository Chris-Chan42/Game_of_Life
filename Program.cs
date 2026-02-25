using System.Threading;

namespace Game_of_Life
{
    public class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(20, 40);
            board.RandomizeBoard();

            while (true) 
            { 
                board.PrintBoard();
                board.NextGeneration();

                Thread.Sleep(200); // control speed of the simulation

                if (Console.KeyAvailable)
                {
                    break; // exit the loop if any key is pressed
                }
            }

            board.PrintBoard();

            int liveNeighbors = board.CountLiveNeighbors(10, 20);
            Console.WriteLine($"Live neighbors around (10, 20): {liveNeighbors}");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            board.ClearBoard();
            board.PrintBoard();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}

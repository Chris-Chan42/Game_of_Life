namespace Game_of_Life
{
    public class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(20, 40);

            board.SetCell(09, 20);
            board.SetCell(10, 20);
            board.SetCell(11, 20);

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life
{
    public class Board
    {
        private bool[,] grid;
        private int rows;
        private int columns;

        public Board(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            grid = new bool[rows, columns];
        }

        public void PrintBoard()
        {
            Console.Clear();

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Console.Write(grid[r, c] ? "O " : ". ");
                }
                Console.WriteLine();
            }
        }

        public void ClearBoard()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    grid[r, c] = false;
                }
            }
        }

        public void SetCell(int row, int column)
        {
            if (row >= 0 && row < rows && column >= 0 && column < columns)
            {
                grid[row, column] = true;
            }
        }

        public int CountLiveNeighbors(int row, int column)
        {
            int count = 0;
            for (int r = row - 1; r <= row + 1; r++)
            {
                for (int c = column - 1; c <= column + 1; c++)
                {
                    if (r == row && c == column) continue; // Skip the cell itself

                    if (r >= 0 && r < rows && c >= 0 && c < columns)
                    {
                        if (grid[r, c])
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }


        public void NextGeneration()
        {
            bool[,] newGrid = new bool[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    int liveNeighbors = CountLiveNeighbors(r, c);
                    if (grid[r, c])
                    {
                        // Current cell is alive
                        newGrid[r, c] = liveNeighbors == 2 || liveNeighbors == 3;
                    }
                    else
                    {
                        // Current cell is dead
                        newGrid[r, c] = liveNeighbors == 3;
                    }
                }
            }
            grid = newGrid;
        }

        public void RandomizeBoard(double aliveChance = 0.3)
        {
            Random rand = new Random();
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    grid[r, c] = rand.NextDouble() < aliveChance;
                }
            }
        }

    }

}

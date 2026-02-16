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
    }
}

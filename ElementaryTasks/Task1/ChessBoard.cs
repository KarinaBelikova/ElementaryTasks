using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryTasks
{
    class ChessBoard
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public char Icon { get; set; }

        public ChessBoard()
        {
            Width = 1;
            Height = 1;
            Icon = '*';
        }

        public ChessBoard(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Print()
        {
           
        }
    }
}

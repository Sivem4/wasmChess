using System;
using System.Collections.Generic;
using System.Text;

namespace wasmChess.Shared
{
    public class Chessboard
    {
        private const int FilesNumber = 8;
        private const int RanksNumber = 8;
        private string whiteColor = "#e1e6e8";
        private string blackColor = "#7f7fce";

        private enum fileNames
        {
            A, B, C, D, E, F, G, H
        }

        public Square[,] squares;

        public Chessboard()
        {
            squares = new Square[FilesNumber, RanksNumber];

            for(int i = 0; i < FilesNumber; i++)
            {
                for(int j = 0; j < RanksNumber; j++)
                {
                    squares[i, j] = new Square(Char.Parse(Enum.GetName(typeof(fileNames), i)), j + 1, (i + j) % 2 == 0 ? blackColor : whiteColor);
                }
            }
        }


    }
}

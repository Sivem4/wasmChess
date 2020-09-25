using System;
using System.Collections.Generic;
using System.Text;

namespace wasmChess.Shared
{
    public class Square
    {
        private char file;
        private int rank;
        private string color;
        public string FileName { get => "file-" + file; }
        public string RankName { get => "rank-" + rank; }
        public string Color { get => color; }
        private bool isAvailable { get; set; }
        public Square(char file, int rank, string color)
        {
            this.file = file;
            this.rank = rank;
            this.color = color;
        }
    }
}

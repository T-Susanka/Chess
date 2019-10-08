using System;
using System.Diagnostics.Tracing;

namespace Chess5Library
{
    public class SquareEventArgs: EventArgs
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Player Player { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess5Library
{
    public class ChessPiece
    {
        public Form1 Game { get; set; }
        public Player Owner { get; set; }
        public Color Color { get; set; }
        public Image Model { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public ChessPiece(Player owner, Square square)
        {
            Owner = owner;
            X = square.X;
            Y = square.Y;
            Game = owner.Game;
        }

        public virtual bool ValidateMove(Square start, Square end) {
            return true;
        }
    }
}

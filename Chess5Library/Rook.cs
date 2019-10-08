using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chess5Library
{
    class Rook:ChessPiece
    {
        public Rook(Player owner, Square square): base(owner, square)
        {
            if (owner.Color == Color.White)
            {
                X = square.X;
                Y = square.Y;
                Model = Properties.Resources.White_Rook;
                square.ChessPiece = this;
            }
            else
            {
                X = square.X;
                Y = square.Y;
                Model = Properties.Resources.Black_Rook;
                square.ChessPiece = this;
            }
        }
    }
}

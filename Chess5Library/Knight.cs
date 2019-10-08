using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Chess5Library
{
    class Knight: ChessPiece
    {
        public Knight(Player owner, Square square) : base(owner, square)
        {
            if (owner.Color == Color.White)
            {
                X = square.X;
                Y = square.Y;
                Model = Properties.Resources.White_Knight;
                square.ChessPiece = this;
            }
            else
            {
                X = square.X;
                Y = square.Y;
                Model = Properties.Resources.Black_Knight;
                square.ChessPiece = this;
            }

        }
        public override bool ValidateMove(Square SquareFrom, Square SquareTo) {
            int X1 = SquareFrom.X; int X2 = SquareTo.X;
            int Y1 = SquareFrom.Y; int Y2 = SquareTo.Y;
            if (X1 == X2 && Y1 == Y2) {
                return true;
            }
            if (((X1 - X2) * (X1 - X2)) + ((Y1 - Y2) * (Y1 - Y2)) - 5 == 0) {
                //ChessBoard.Tah++;
                return true;
            }
            else {
                return false;
            }
        }
    }
}

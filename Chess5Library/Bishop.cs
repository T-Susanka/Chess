using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chess5Library
{
    class Bishop: ChessPiece
    {
        public Bishop(Player owner, Square square) : base(owner, square)
        {
            if (owner.Color == Color.White)
            {
                X = square.X;
                Y = square.Y;
                Model = Properties.Resources.White_Bishop;
                square.ChessPiece = this;
            }
            else
            {
                X = square.X;
                Y = square.Y;
                Model = Properties.Resources.Black_Bishop;
                square.ChessPiece = this;
            }

        }
        public override bool ValidateMove(Square SquareFrom, Square SquareTo) {
            int X1 = SquareFrom.X; int X2 = SquareTo.X;
            int Y1 = SquareFrom.Y; int Y2 = SquareTo.Y;
            bool PathValid = true;
            if (X1 == X2 && Y1 == Y2) {
                return true;
            }
            else if (Math.Abs(X1 - X2) == Math.Abs(Y1 - Y2)) {
                if (X1 > X2 && Y1 > Y2) {
                    int j = 1;
                    for (int i = X1 - 1; i > X2; i--) {
                        if (Game.Square[i, Y1 - j++].ChessPiece !=null) {
                            PathValid = false;
                        }
                    }
                }
                else if (X1 < X2 && Y1 < Y2) {
                    int j = 1;
                    for (int i = X1 + 1; i < X2; i++) {
                        if (Game.Square[i, Y1 + j++].ChessPiece != null) {
                            PathValid = false;
                        }
                    }
                }
                else if (X1 > X2 && Y1 < Y2) {
                    int j = 1;
                    for (int i = X1 - 1; i > X2; i--) {
                        if (Game.Square[i, Y1 + j++].ChessPiece != null) {
                            PathValid = false;
                        }

                    }
                }
                else if (X1 < X2 && Y1 > Y2) {
                    int j = 1;
                    for (int i = X1 + 1; i < X2; i++) {
                        if (Game.Square[i, Y1 - j++].ChessPiece != null) {
                            PathValid = false;
                        }
                    }

                }
            }
            else {
                PathValid = false;
            }
            if (PathValid) {
                //Game.Tah++;
                return true;
            }
            else {
                return false;
            }
        }
    }
}

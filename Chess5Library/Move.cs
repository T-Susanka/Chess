using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess5Library
{
    public class Move {
        public int MoveNumber { get; set; }
        public Square Start { get; set; }
        public Square End { get; set; }
        public Player MadeBy { get; set; }
        public ChessPiece ChessPiece { get; set; }
        public Move PreviousMove { get; set; }
        public Form1 Form { get; set; }
        public Move(Square start, Square end, ChessPiece chesspiece) {
            Start = start;
            End = end;
            ChessPiece = chesspiece;
            Form = ChessPiece.Owner.Game;
        }
        public bool IsValid() {
            return ChessPiece.ValidateMove(Start, End);
        }
        public void Execute() {
            Start.ChessPiece = null;
            End.ChessPiece = ChessPiece;
            Start.BackColor = Start.DefaultColor;
            ChessPiece.Owner.ActivePiece = null;
            if (Form.ActivePlayer == Form.player1) {
                Form.ActivePlayer = Form.player2;
            }
            else {
                Form.ActivePlayer = Form.player1;
            }
        }
    }
}

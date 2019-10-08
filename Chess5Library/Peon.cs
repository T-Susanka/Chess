using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chess5Library
{
    public class Peon: ChessPiece
    {
        public Peon(Player owner, Square square):base(owner, square)
        {
            if (owner.Color == Color.White)
            {
                X = square.X;
                Y = square.Y;                
                Model = Properties.Resources.White_Peon;
                square.ChessPiece = this;
            }
            else
            {
                X = square.X;
                Y = square.Y;
                Model = Properties.Resources.Black_Peon;
                square.ChessPiece = this;
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess5Library
{
    public class Square : PictureBox
    {
        public Form1 ParentForm { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        private ChessPiece chessPiece;
        bool ContestedByBlack;
        bool ContestedByWhite;
        public Color DefaultColor { get; set; }
        public ChessPiece ChessPiece
        {
            get { return chessPiece; }
            set
            {
                chessPiece = value;
                if (!(value == null)) {
                    this.Image = chessPiece.Model;
                    value.X = X;
                    value.Y = Y;
                }
                else {
                    this.Image = null; 
                }
                
            }
        }

        public Square(int x, int y, Color color, int size, Form1 parent)
        {
            ParentForm = parent;
            X = x / 80;
            Y = y / 80;
            this.Top = x;
            this.Left = y;
            this.Height = size;
            this.Width = size;
            this.BackColor = color;
            DefaultColor = color;
            Click += Square_Click;
        }

        private void Square_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Kliknuto");
            Square square = (Square)sender;
            if (ParentForm.ActivePlayer.ActivePiece == null && square.ChessPiece != null && square.ChessPiece.Owner == ParentForm.ActivePlayer) {
                square.BackColor = Color.Yellow;
                ParentForm.ActivePlayer.ActivePiece = square.ChessPiece;
                ParentForm.ActivePlayer.StartSquare = square;
            }
            else if (ParentForm.ActivePlayer.ActivePiece != null){
                ParentForm.ActivePlayer.EndSquare = square;
            }

        }
    }
}

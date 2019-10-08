using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess5Library {
    public class Player {
        public string Name { get; set; }
        public Color Color { get; set; }
        public Form1 Game { get; set; }
        public List<ChessPiece> ChessPiecesOwned { get; set; }
        public List<ChessPiece> ChessPiecesLost { get; set; }
        public ChessPiece ActivePiece { get; set; }
        public bool MyTurn { get; set; }
        public Move IntendedMove { get; set; }
        private Square startSquare;

        public Square StartSquare {
            get { return startSquare; }
            set { startSquare = value;
                ActivePiece = value.ChessPiece;
            }
        }

        private Square endSquare;

        public Square EndSquare {
            get { return endSquare; }
            set {
                endSquare = value;
                IntendedMove = new Move(startSquare, endSquare, ActivePiece);
                if (IntendedMove.IsValid()) {
                    IntendedMove.Execute();
                }                
            }
        }



        public Player(Color color, Form1 game) {
            Color = color;
            this.Game = game;
            ChessPiecesOwned = new List<ChessPiece>();
            ChessPiecesLost = new List<ChessPiece>();
            MyTurn = (color == Color.White ? true : false);
            CreateMyPieces();
        }

        private void CreateMyPieces() {
            if (Color == Color.White) {
                for (int i = 0; i < 8; i++) {
                    ChessPiecesOwned.Add(new Peon(this, Game.Square[6, i]));
                }

                ChessPiecesOwned.Add(new Rook(this, Game.Square[7, 0]));
                ChessPiecesOwned.Add(new Rook(this, Game.Square[7, 7]));
                ChessPiecesOwned.Add(new Knight(this, Game.Square[7, 1]));
                ChessPiecesOwned.Add(new Knight(this, Game.Square[7, 6]));
                ChessPiecesOwned.Add(new Bishop(this, Game.Square[7, 2]));
                ChessPiecesOwned.Add(new Bishop(this, Game.Square[7, 5]));
                ChessPiecesOwned.Add(new Queen(this, Game.Square[7, 3]));
                ChessPiecesOwned.Add(new King(this, Game.Square[7, 4]));
            }
            else {
                for (int i = 0; i < 8; i++) {
                    new Peon(this, Game.Square[1, i]);
                }
                ChessPiecesOwned.Add(new Rook(this, Game.Square[0, 0]));
                ChessPiecesOwned.Add(new Rook(this, Game.Square[0, 7]));
                ChessPiecesOwned.Add(new Knight(this, Game.Square[0, 1]));
                ChessPiecesOwned.Add(new Knight(this, Game.Square[0, 6]));
                ChessPiecesOwned.Add(new Bishop(this, Game.Square[0, 2]));
                ChessPiecesOwned.Add(new Bishop(this, Game.Square[0, 5]));
                ChessPiecesOwned.Add(new Queen(this, Game.Square[0, 3]));
                ChessPiecesOwned.Add(new King(this, Game.Square[0, 4]));
            }
        }
    }
}

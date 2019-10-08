using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess5Library
{
    public class Form1 : Form
    {
        public Player player1 { get; set; }
        public Player player2 { get; set; }
        public Player ActivePlayer { get; set; }
        private bool firstClick = true;

        public bool FirstClick
        {
            get { return firstClick; }
            set { firstClick = value; }
        }

        public Square[,] Square { get; set; } = new Square[8, 8];
        public Form1()
        {
            InitializeComponent();
            InitializeSquares();
            InitializePlayers();
        }

        private void InitializePlayers()
        {
            player1 = new Player(Color.White, this);
            ActivePlayer = player1;
            player2 = new Player(Color.Black, this);
        }

        private System.ComponentModel.IContainer components = null;
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 753);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeSquares()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            Square[i, j] = new Square(i * 80, j * 80, Color.White, 80, this);
                        }
                        else
                        {
                            Square[i, j] = new Square(i * 80, j * 80, Color.Black, 80, this);
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            Square[i, j] = new Square(i * 80, j * 80, Color.Black, 80, this);
                        }
                        else
                        {
                            Square[i, j] = new Square(i * 80, j * 80, Color.White, 80, this);
                        }
                    }
                    this.Controls.Add(Square[i, j]);
                    //Square[i, j].Click += Square_click;
                    //Square[i, j].Click += Square_SUPERCLICK;
                    Square[i, j].SizeMode = PictureBoxSizeMode.CenterImage;
                }
            }
        }


    }
}

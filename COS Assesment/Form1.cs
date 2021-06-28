using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace COS_Assesment
{
    public partial class Form1 : Form
    {
        int Roll = 0;
        Random rollRnd = new Random();

        int currentPlace = 1;

        Image dice1 = Image.FromFile(Application.StartupPath + @"\dice1.jpg");
        Image dice2 = Image.FromFile(Application.StartupPath + @"\dice2.jpg");
        Image dice3 = Image.FromFile(Application.StartupPath + @"\dice3.jpg");
        Image dice4 = Image.FromFile(Application.StartupPath + @"\dice4.jpg");
        Image dice5 = Image.FromFile(Application.StartupPath + @"\dice5.jpg");
        Image dice6 = Image.FromFile(Application.StartupPath + @"\dice6.jpg");

        const int squareWidth = 54; // change to pnlwidth/10 later
        const int squareHeight = 60;

        int x;
        int y;
        int square = 1; // square num of player

        //public delegate int p (int x, int y);

        public Form1()
        {
            InitializeComponent();
        }



        private void mainPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Roll = rollRnd.Next(1, 7);

            if (Roll == 1)
            {
                PicDice.BackgroundImage = dice1;
            }
            else if (Roll == 2)
            {
                PicDice.BackgroundImage = dice2;
            }
            else if (Roll == 3)
            {
                PicDice.BackgroundImage = dice3;
            }
            else if (Roll == 4)
            {
                PicDice.BackgroundImage = dice4;
            }
            else if (Roll == 5)
            {
                PicDice.BackgroundImage = dice5;
            }
            else if (Roll == 6)
            {
                PicDice.BackgroundImage = dice6;
            }

            movePiece(Roll);
        }

        public void movePiece(int Roll)
        {
            square += Roll;
            int x = piece1.Location.X;
            currentPlace = piece1.Location.X;
            int y = piece1.Location.Y;

            currentPlace += Roll;

            x = square * squareWidth;

            Point Point = new Point(x, y);

            // if square is between 1-10, 21-30 etc
            // else if between 11-20, 31-40 etc
            piece1.Location = Point;
        }
    }

}

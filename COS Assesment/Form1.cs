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
        int snakeheads;
        int ladders;
        int num = 1;
        int[] pos;

        int currentPlace = 1;
        //const int pnlwidth = 600;

        Image dice1 = Image.FromFile(Application.StartupPath + @"\dice1.jpg");
        Image dice2 = Image.FromFile(Application.StartupPath + @"\dice2.jpg");
        Image dice3 = Image.FromFile(Application.StartupPath + @"\dice3.jpg");
        Image dice4 = Image.FromFile(Application.StartupPath + @"\dice4.jpg");
        Image dice5 = Image.FromFile(Application.StartupPath + @"\dice5.jpg");
        Image dice6 = Image.FromFile(Application.StartupPath + @"\dice6.jpg");

        const int squareWidth = 60;
        const int squareHeight = 60;

        int p = 1;
        int x;
        int y;
        int xpos = 1; // numbered square on x
        int square = 0; // square num of player

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

            for (int i = 0; i < Roll; i++)
            {
                MoveOne();

            }

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

            Snakeheads(Roll);
            Ladders(Roll);

        }



        private void MoveOne()
        {
            num += 1;
            p += 1;
            square = p - 1;

            int x = piece1.Location.X;
            int y = piece1.Location.Y;

            if (square % 10 == 0)
            {
                y -= 60;
            }

            if (square <= 10)
            {
                x = square * squareWidth;
            }

            else if (square >= 10 && square <= 20)
            {

                x = (square % 10) * squareWidth;

            }
            else if (square >= 20 && square <= 30)
            {

                x = (square % 10) * squareWidth;

            }
            else if (square >= 30 && square <= 40)
            {

                x = (square % 10) * squareWidth;

            }
            else if (square >= 40 && square <= 50)
            {

                x = (square % 10) * squareWidth;

            }
            else if (square >= 50 && square <= 60)
            {

                x = (square % 10) * squareWidth;

            }
            else if (square >= 60 && square <= 70)
            {

                x = (square % 10) * squareWidth;

            }
            else if (square >= 70 && square <= 80)
            {

                x = (square % 10) * squareWidth;

            }
            else if (square >= 80 && square <= 90)
            {

                x = (square % 10) * squareWidth;

            }
            else if (square >= 90 && square <= 100)
            {

                x = (square % 10) * squareWidth;

            }


            Point Point = new Point(x, y);
            piece1.Location = Point;


        } //--------------------------------------------------------------------snakes-----------------------------------------------------------------------------//
        private void Snakeheads(int Roll)
        {

            int x = piece1.Location.X;
            int y = piece1.Location.Y;
            Point Point = new Point(x, y);
            piece1.Location = Point;


            if (p == 25)
            {
                x = 250;
                y = 550;
                p = 5;


            }
            else if (p == 34)
            {
                x = 3;
                y = 550;
                p = 1;

            }
            else if (p == 47)
            {
                x = 480;
                y = 490;
                p = 19;

            }
            else if (p == 65)
            {
                x = 70;
                y = 260;
                p = 52;

            }
            else if (p == 87)
            {
                x = 370;
                y = 260;
                p = 57;

            }
            else if (p == 91)
            {
                x = 10;
                y = 200;
                p = 61;

            }
            else if (p == 99)
            {
                x = 490;
                y = 190;
                p = 69;

            }
            piece1.Location = new Point(x, y);




        }

        private void Ladders(int Roll)
        {

            int x = piece1.Location.X;
            int y = piece1.Location.Y;
            Point Point = new Point(x, y);
            piece1.Location = Point;

            if (p == 3)
            {
                x = 3;
                y = 260;
                p = 51;

            }
            else if (p == 6)
            {
                x = 370;
                y = 440;
                p = 27;


            }
            else if (p == 20)
            {
                x = 550;
                y = 200;
                p = 70;

            }
            else if (p == 36)
            {
                x = 260;
                y = 260;
                p = 55;

            }
           
            else if (p == 63)
            {
                x = 250;
                y = 20;
                p = 95;

            }
            else if (p == 68)
            {
                x = 420;
                y = 20;
                p = 98;

            }
            else if(p == 100)
            {

                MessageBox.Show("Congratulations! You Win!");
                

            }
            else if (p > 100)
            {

                MessageBox.Show("cannot move");
                

            }
            piece1.Location = new Point(x, y);




        }


        //-------------------------------------------------------------------------Ladders------------------------------------------------------------------------------------------//




    }
}








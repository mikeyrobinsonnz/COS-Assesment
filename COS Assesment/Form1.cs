﻿using System;
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
        int[] pos = new int[100];
        int p = 1;
        int Roll = 0;
        Random rollRnd = new Random();
        int snakeheads;
        int ladders;
        int num = 1;
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

            //movePiece(Roll);
        }

        public void movePiece(int Roll)
        {
            square += Roll;
            int x = piece1.Location.X;
            //currentPlace = piece1.Location.X;
            int y = piece1.Location.Y;
            //  currentPlace = piece1.Location.Y;

            //currentPlace += Roll;




            if (square > 10)
            {
                x += square * squareWidth;

            }

            else if (square >= 10 && square <= 20)
            {
                x = square * squareWidth;
            }
            y -= 60;
            //currentPlace -= Roll*2;
            //x = currentPlace;

            // else if between 11-20, 31-40 etc


        }

        private void MoveOne()
        {
            square += 1;
            num += 1;

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

                if (num == 43)
                {
                    num = 17;
                }
                else if (num == 50)
                {
                    num = 5;
                }
                else if (num == 56)
                {
                    num = 8;
                }
                else if (num == 84)
                {
                    num = 58;
                }
                else if (num == 87)
                {
                    num = 49;
                }
                else if (num == 98)
                {
                    num = 40;
                }

            }















            //void snakeheads(int Roll)

            //{
            //pos[p] = 1;
                //int[] moves = new int[N];
                //for (int i = 0; i < N; i++)
                    //moves[i] = -1;


               // pos[43] =- 17;
               // pos[50] =- 5;
               // pos[56] =- 8;
               // pos[84] =- 58;
               // pos[87] =- 49;
               // pos[98] =- 40;
            //}        
        }
    }




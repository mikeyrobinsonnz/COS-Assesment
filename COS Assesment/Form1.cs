using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace COS_Assesment
{
    public partial class Form1 : Form
    {
        int Roll = 0; //initially set roll to 0
        Random rollRnd = new Random();
        int snakeheads; // declares snakes
        int ladders;    // declares ladders
        int num = 1; //declares number of players
        int[] pos; //sets position array

        string name = ""; 

        bool GameStart = false; //sets the game start to false
        int seconds = 0; //starts seconds at zero and syncs with timergame

        int currentPlace = 1; //player starts at position 1 on board
        
        //dice images (copyrightfree)
        Image dice1 = Image.FromFile(Application.StartupPath + @"\dice1.jpg"); 
        Image dice2 = Image.FromFile(Application.StartupPath + @"\dice2.jpg");
        Image dice3 = Image.FromFile(Application.StartupPath + @"\dice3.jpg");
        Image dice4 = Image.FromFile(Application.StartupPath + @"\dice4.jpg");
        Image dice5 = Image.FromFile(Application.StartupPath + @"\dice5.jpg");
        Image dice6 = Image.FromFile(Application.StartupPath + @"\dice6.jpg");

        //declares width and height of squares in pixels
        const int squareWidth = 60;
        const int squareHeight = 60;

        int p = 1; //starts at position 1
        int x; //x movement axis
        int y; //y movement axis
        int xpos = 1; // numbered square on x
        int square = 0; // square num of player

        bool check = false; //checks boolean method to false when game initializes.
       

        public Form1()
        {
            InitializeComponent(); //initializes panel
            ListBoxHighScores.Visible = false; //hides highscore box
        }



        private void mainPnl_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Thread.Sleep(200); //Roll button has 200ms delay between clicks
            check = false; //checks bool
            if(GameStart == false) //checks that game start is false and on first click of ROLL button sets all to true.
            {
                TimerGame.Enabled = true;
                GameStart = true;
                TimerGame.Interval = 1000;
            }
            Roll = rollRnd.Next(1, 7); //picks dice between 1-6


            if (Roll == 1) //displays correct dice image depending on what the randomizer picks
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

            for (int i = 0; i < Roll; i++) //Roll Method parsed to Move Method
            {

                MoveOne();  //main method for player movment, is multiplied by dice later on.
                
            }

            Snakeheads(Roll); //parses roll through snake method
            Ladders(Roll); //parses roll through ladders method

        }



        private void MoveOne() //Movement Code
        {
            num += 1; //adds 1 to number of moves each time code is called
            p += 1; //increases player position each time it is called
            square = p - 1; //because board does not include zero make p = to -1 of current square

            int x = piece1.Location.X; //tells board where the pieces are on x axis
            int y = piece1.Location.Y; //tells board where the pieces are on y axis

            if (square % 10 == 0)
            {
                y -= 60; //moves player up one row if piece reaches the end
            }

            if (square <= 10)
            {
                x = square * squareWidth; //if more room on row it moves by x amount of spaces according to (Roll)
            }

            else if (square >= 10 && square <= 20) //if between square 10 and 20 , move along the x axis
            {

                x = (square % 10) * squareWidth;

            }
            else if (square >= 20 && square <= 30) //if between square 20 and 30 , move along the x axis
            {

                x = (square % 10) * squareWidth;

            }
            else if (square >= 30 && square <= 40) //if between square 30 and 40 , move along the x axis
            {

                x = (square % 10) * squareWidth;

            }
            else if (square >= 40 && square <= 50) //if between square 40 and 50 , move along the x axis
            {

                x = (square % 10) * squareWidth;

            }
            else if (square >= 50 && square <= 60) //if between square 50 and 60 , move along the x axis
            {

                x = (square % 10) * squareWidth;

            }
            else if (square >= 60 && square <= 70) //if between square 60 and 70 , move along the x axis
            {

                x = (square % 10) * squareWidth;

            }
            else if (square >= 70 && square <= 80) //if between square 70 and 80 , move along the x axis
            {

                x = (square % 10) * squareWidth;

            }
            else if (square >= 80 && square <= 90) //if between square 80 and 90 , move along the x axis
            {

                x = (square % 10) * squareWidth;

            }
            else if (square >= 90 && square <= 100) //if between square 90 and 100 , move along the x axis
            {

                x = (square % 10) * squareWidth;

            }
            if (p == 100) //winning square
            {

                MessageBox.Show("Congratulations! You Win!"); //display message box
                TimerGame.Enabled = false; //stops timer
                updateHighScores(name, seconds); //pulls Name from entry box and current timer value and writes to highscores.txt
            }
            

            Point Point = new Point(x, y); //keeps track of x and y position
            piece1.Location = Point; //sets new point to x and y position designated by move code


        } //--------------------------------------------------------------------snakes-----------------------------------------------------------------------------//
        private void Snakeheads(int Roll) //snakeheads code, parsed with roll so it recognises how many spaces
        {

            int x = piece1.Location.X;
            int y = piece1.Location.Y;
            Point Point = new Point(x, y);
            piece1.Location = Point;


            if (p == 25) //if it lands on xx exactly, move, if not continue with MoveOne
            {
                x = 250;
                y = 550;
                p = 5;
                //x,y & p are updated based on where snake leads

            }
            else if (p == 34) //if it lands on xx exactly, move, if not continue with MoveOne
            {
                x = 3;
                y = 550;
                p = 1;
                //x,y & p are updated based on where snake leads
            }
            else if (p == 47) //if it lands on xx exactly, move, if not continue with MoveOne
            {
                x = 480;
                y = 490;
                p = 19;
                //x,y & p are updated based on where snake leads
            }
            else if (p == 65) //if it lands on xx exactly, move, if not continue with MoveOne
            {
                x = 70;
                y = 260;
                p = 52;
                //x,y & p are updated based on where snake leads
            }
            else if (p == 87) //if it lands on xx exactly, move, if not continue with MoveOne
            {
                x = 370;
                y = 260;
                p = 57;
                //x,y & p are updated based on where snake leads
            }
            else if (p == 91) //if it lands on xx exactly, move, if not continue with MoveOne
            {
                x = 10;
                y = 200;
                p = 61;
                //x,y & p are updated based on where snake leads
            }
            else if (p == 99) //if it lands on xx exactly, move, if not continue with MoveOne
            {
                x = 490;
                y = 190;
                p = 69;
                //x,y & p are updated based on where snake leads

            }
            piece1.Location = new Point(x, y);




        }

        private void Ladders(int Roll) //looks at where ladders lead and move only if landed on perfectly
        {

            int x = piece1.Location.X;
            int y = piece1.Location.Y;
            Point Point = new Point(x, y);
            piece1.Location = Point;

            if (p == 3) //if square x is landed on move to newpos and updates position
            {
                x = 3;
                y = 260;
                p = 51;

            }
            else if (p == 6)//if square x is landed on move to newpos and updates position
            {
                x = 370;
                y = 440;
                p = 27;


            }
            else if (p == 20)//if square x is landed on move to newpos and updates position
            {
                x = 550;
                y = 200;
                p = 70;

            }
            else if (p == 36)//if square x is landed on move to newpos and updates position
            {
                x = 260;
                y = 260;
                p = 55;

            }
           
            else if (p == 63)//if square x is landed on move to newpos and updates position
            {
                x = 250;
                y = 20;
                p = 95;

            }
            else if (p == 68)//if square x is landed on move to newpos and updates position
            {
                x = 420;
                y = 20;
                p = 98;

            }
            piece1.Location = new Point(x, y);




        }

        private void TxtName_TextChanged(object sender, EventArgs e) //detects when the Textbox for Username is changed
        {
            // sets string text to thetext box
            string text = TxtName.Text;
            // checks for null value
            if (text.Trim() == "") return;
            for (int i = 0; i < text.Length; i++)
            {
                // if not a letter, not let it be entered
                if (!char.IsLetter(text[i]))
                {
                    MessageBox.Show("Please enter a valid username, one with only letters"); //error box
                    TxtName.Text = "";
                    return; //returns blank box for another attempt
                }

            }
        }

        private void BtnName_Click(object sender, EventArgs e)
        {
            name = TxtName.Text; // sets username to the text box's text
            MessageBox.Show("Username Set");
        }

        private void TimerGame_Tick(object sender, EventArgs e) 
        {
            seconds++; //increases time in seconds at 1000ms tick
        }

        private void finish_Click(object sender, EventArgs e) //debug button added for testing, can be removed as it has no real use apart from quick finishes to test new features
        {
            Random debug = new Random(); //debugs timer at random
            seconds = debug.Next(50, 100); //picks a time between 50 and 100 seconds
            MessageBox.Show("Congratulations! You Win!");
            TimerGame.Enabled = false; //disables timer and sends value to writer
            updateHighScores(name, seconds); //writer updates highscores.txt
        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            TimerGame.Enabled = false; // pauses timer

            MessageBoxButtons buttons = MessageBoxButtons.OK; // set buttons to OK
            string msg = "The game is paused. Press OK to unpause the game."; // declare msg string
            string title = "Paused"; // declare title
            DialogResult result = MessageBox.Show(msg, title, buttons); // display msg box

            if (result == DialogResult.OK) // if OK pressed, resume timer and game
            {
                TimerGame.Enabled = true;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            TimerGame.Enabled = false; //pause timer
            MessageBoxButtons buttons = MessageBoxButtons.YesNo; // set buttons to OK
            string msg = "Do you want to exit the game? Your score will NOT be recorded."; // declare msg 
            string title = "Exit Game?"; // declare title
            DialogResult result = MessageBox.Show(msg, title, buttons); // display msg box

            if (result == DialogResult.Yes) // if yes pressed, do not send to writer and close game safely
            {
                Application.Exit();
            }
            else if(result == DialogResult.No) //if no, resume game and timer
            {
                TimerGame.Enabled = true;
            }

        }

        private void BtnInstructions_Click(object sender, EventArgs e) //instructions button
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK; // set buttons to OK
            string title = "Game Instructions"; // declare title
            string msg = "To Play The Game Type Your Name Into the Box and Click Submit. To Start The Timer Click Roll and Play as Normal , You must reach 100 to Win";
            DialogResult result = MessageBox.Show(msg, title, buttons); // display msg box
        }




        




    }
}








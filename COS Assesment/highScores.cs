using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace COS_Assesment
{
    public partial class Form1
    {
        public void updateHighScores(string name, int seconds)
        {
            ListBoxHighScores.Visible = true;
            StreamWriter writer;
            StreamReader reader;

            string binPath = "";

            binPath = Application.StartupPath + @"\highscores.txt";

            // declare list of high scores
            List<(string, int)> highScores = new List<(string, int)>();

            // declares necessary variables to read the text file:
            // each line of data
            string line = "";
            // each split, saved as an array
            string[] values;
            // names from the split
            string names = "";
            // scores from the split
            int scores = 0;
            // lowest score to compare to the users score
            int highestScore = 0;
            // a counter
            int counter = 0;
            // appends text to file
            writer = File.AppendText(binPath);

            // if score is not 0, write it to text file
            if (seconds != 0)
            {
                writer.WriteLine(name + "," + seconds.ToString());
            }
            writer.Close();

            reader = File.OpenText(binPath);

            // while not end of file:
            while (!reader.EndOfStream)
            {
                // read the line, split it off a comma
                line = reader.ReadLine();
                values = line.Split(',');
                // saves values into names, and scores respectively
                names = values[0];
                scores = int.Parse(values[1]);
                // adds name and score to list
                highScores.Add((names, scores));

                // make it so it only enters once - fixes a bug
                if (seconds > highestScore || counter == 0)
                {
                    highestScore = seconds;
                }
                counter++;

            }

            reader.Close();

            highScores = highScores.OrderBy(x => x.Item2).Take(10).ToList();
            ListBoxHighScores.Items.Clear(); // clear the listbox before inputting the new high scores

            foreach (var (username, score2) in highScores) // for each instance of a name with its corresponding score in high scores
            {
                ListBoxHighScores.Items.Add(username.PadRight(10) + score2); // add to listbox
            }


        }
    }
}

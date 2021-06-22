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

            }
            else if (Roll == 2)
            {

            }
            else if (Roll == 3)
            {

            }
            else if (Roll == 4)
            {

            }
            else if (Roll == 5)
            {

            }
            else if (Roll == 6);

        }
    }

}

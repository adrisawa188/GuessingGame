using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class guessingGame : Form
    {
        public static List<string> oOrder = new List<string>();
        public static List<string> sOrder = new List<string>();
        public static int guessCounter = 0; 

        //declare global variables 
        Random randGen = new Random();
        int randomValue;

        public guessingGame()
        {
            InitializeComponent();

            //pick random number
            randomValue = randGen.Next(1, 101); 

        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            //Form1.guessCounter++;
            //check if a number has been entered, if not, display error message
            try
            {
                //make sure that label is visbile after reset
                outputLabel.Visible = true;

                //declare local varables and assing values to global ones
                int userGuess = Convert.ToInt32(inputBox.Text);
               

                //check if the users answer is too high, too low, or right on
                if (userGuess > randomValue)
                {
                    outputLabel.Text = "Too High!";
                }
                else if (userGuess < randomValue)
                {
                    outputLabel.Text = "Too Low!";
                }
                else 
                {
                    ChangeScreen(this, new Results()); 
                }

            }
            catch
            {
                outputLabel.Text = "Please Enter A Number";            
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            randomValue = randGen.Next(1, 11);
            inputBox.Text = "0";
            outputLabel.Visible = false;
        }
        public static void ChangeScreen(object sender, UserControl next)

        {

            Form f; // will either be the sender or parent of sender 

            if (sender is Form)
            {
                f = (Form)sender;                          //f is sender 
            }

            else
            {
                UserControl current = (UserControl)sender;  //create UserControl from sender 

                f = current.FindForm();                     //find Form UserControl is on 

                f.Controls.Remove(current);                 //remove current UserControl 
            }

            // add the new UserControl to the middle of the screen and focus on it 
            next.Location = new Point((f.ClientSize.Width - next.Width) / 2,

                (f.ClientSize.Height - next.Height) / 2);

            f.Controls.Add(next);

            next.Focus();
        }
    }
}

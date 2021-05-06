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
                    outputLabel.Text = "You Got It!";
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
    }
}

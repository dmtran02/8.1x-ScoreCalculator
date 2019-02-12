using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Duc Tran
 * Professor Frank Friedman
 * CIS 3309 - 8.1X: Score Calculator
 * Last Updated: February 11, 2019
 */

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        /*
         * Class variables for the sake of operation of program running as a success
         */

        private static int scoreTotal = 0;
        //private static int scoreCount = 0;
        private static List<int> myData = new List<int>();
        //private static int counter = 0; // for debugging scoreCount

        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = txtScore;
        }

        /*
         * If unable to parse score, message box will notify user to enter a valid 'numeric' score
         * Otherwise, score is parsed successfully and is added onto 'myData' list and the count is tracked by how many elements are in myData list.
         * 
         * The text of txtScoreCount is set to the count of myData and average is the division of parsed 'scoreTotal' and 'scoreCount' which is then set as the text of txtAvg.
         *  -There are if statements depending if there was a value inputted before or not to provide appropriate display, functionality and calculation.
         */

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtScore.Text, out int n))
            {
                MessageBox.Show("Please enter a valid integer value in the text box.");
            }
            else
            {
                scoreTotal = int.Parse(txtScore.Text);
                if (!string.IsNullOrEmpty(txtScoreTotal.Text))
                {
                    int scoreHolder = int.Parse(txtScoreTotal.Text);
                    myData.Add(int.Parse(txtScore.Text));
                    scoreHolder += scoreTotal;
                    txtScoreTotal.Text = scoreHolder.ToString();
                    //scoreCount++;
                    txtScoreCount.Text = myData.Count.ToString();
                    //Console.WriteLine("Total Score: " + int.Parse(txtScoreTotal.Text));
                    //Console.WriteLine("Score Count: " + int.Parse(txtScoreCount.Text));
                    int average = int.Parse(txtScoreTotal.Text) / int.Parse(txtScoreCount.Text);
                    //Console.WriteLine("Average: " + average);
                    txtAvg.Text = average.ToString();
                    //Console.WriteLine("First element of myData: " + myData[0]);
                }
                else
                {
                    txtScoreTotal.Text = scoreTotal.ToString();
                    myData.Add(int.Parse(txtScore.Text));
                    //scoreCount++;
                    txtScoreCount.Text = myData.Count.ToString();
                    txtAvg.Text = (int.Parse(txtScoreTotal.Text) / int.Parse(txtScoreCount.Text)).ToString();
                    //Console.WriteLine("First element of myData: " + myData[0]);
                }
            }
            
        }

        /*
         * Closes the program upon button click
         */

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * Event handler for btnAdd_Click event handler that adds value in txtScore if the 'Enter' key is pressed while highlighting the add button on the form.
         */

        private void EnterPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }

        /*
         * Event handler for btnExit_Click event handler that adds value in txtScore if the 'Escape' (or ESC) key is pressed while highlighting the exit button on the form.
         */

        private void EscPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                btnExit_Click(sender, e);
            }
        }

        /*
         * Event hanlder that takes care of resetting every textbox, 
         * list and class variable values to default and sets focus onto 
         * txtScore for a new series of inputs from the user.
         */

        private void btnClrScores_Click(object sender, EventArgs e)
        {
            scoreTotal = 0;
            //scoreCount = 0;
            txtScore.Text = "";
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtScore.Text = "";
            txtAvg.Text = "";
            myData = new List<int>();
            txtScore.Focus();
        }

        /*
         * Event handler for 'Display Scores' button that sorts myData list and displays 
         * in a message box the ordered elements of the list (least to greatest) 
         * and the count of elements in the list.
         * 
         * First checks if the list is empty:
         *  -If empty, the form will notify the user to enter scores in order for this button to display scores that have been entered
         *  -Otherwise, the form will display list the first 20 scores (and only 20) along with its count or notify the user that
         *   only the first 20 scores will be displayed if there are more than 20 scores inputted by the user in a message box.
         *   
         *  At the end of this method, txtScore is focused for the convenience of future inputs from the user.
         */

        private void btnDisplayScores_Click(object sender, EventArgs e)
        {
            String numDisplay = "";
            myData.Sort();
            int counter = 0;
            bool isEmpty = !myData.Any();
            if (isEmpty)
            {
                MessageBox.Show("Enter scores into the form to begin!");
            }
            foreach (int i in myData)
            {
                numDisplay += i.ToString() + "\n";
                //MessageBox.Show(numDisplay, "Sorted Scores");
                counter++;
                if (myData.Count >= 20)
                {
                    MessageBox.Show("This example will only display the first 20 scores!");
                    break;
                }
                else if(counter == myData.Count)
                {
                    MessageBox.Show(numDisplay, "Sorted Scores: " + myData.Count);
                    break;
                }
            }
            txtScore.Focus();
        }
    }
}

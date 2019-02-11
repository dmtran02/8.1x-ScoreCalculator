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

    /*
     * !! FINISH THE LAST PART OF THIS LAB !!
     *  --Remove the score count increments for we now have a list of integers (#12)
     */

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private static int scoreTotal = 0;
        private static int scoreCount = 0;
        private static List<int> myData = new List<int>();
        private static int counter = 0; // for debugging scoreCount

        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = txtScore;
            //Console.WriteLine("myData Size: " + myData.Length);
        }

        private void btnAdd_Click(object sender, EventArgs e) // fix score total global to hold txtscoretotal.text
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
                    scoreCount++;
                    txtScoreCount.Text = scoreCount.ToString();
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
                    scoreCount++;
                    txtScoreCount.Text = scoreCount.ToString();
                    txtAvg.Text = (int.Parse(txtScoreTotal.Text) / int.Parse(txtScoreCount.Text)).ToString();
                    //Console.WriteLine("First element of myData: " + myData[0]);
                }
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnterPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void EscPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                btnExit_Click(sender, e);
            }
        }

        private void btnClrScores_Click(object sender, EventArgs e)
        {
            scoreTotal = 0;
            scoreCount = 0;
            txtScore.Text = "";
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtScore.Text = "";
            txtAvg.Text = "";
            myData = new List<int>();
            txtScore.Focus();
        }

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
                if (counter >= 20)
                {
                    MessageBox.Show("This example will only display the first 20 scores!");
                    break;
                }
                else if(counter == scoreCount)
                {
                    MessageBox.Show(numDisplay, "Sorted Scores: " + counter);
                    break;
                }
            }
            txtScore.Focus();
        }
    }
}

//INITIAL DOCUMENTATION
//Developer Name: Varsan Jeyakkumar

//Development Proposal Write Up Date: 2024-06-04
//Development Start Date: 2024-06-05
//Project Submission (Release): 2024-06-17

//Title: Deal or No Arrow

//Purpose: To design a single player game of deal or no deal modified with movable c

/*Game Objective
This game is a modified version of “Deal or No Deal”, with a different format to select boxes. 
In my game, there are some briefcases stacked along the opposite edge along with a cannon facing horizontally. 
Based on the power applied by the user, briefcases are selected by where the cannonball lands (which box it touches). 
Each round, calculations determine an offer for the user, in terms of points, which the user can accept or reject. 
In the end, they can choose to accept the final offer or open their briefcase. 
The total number of points is saved in a text file.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deal_Or_No_Arrow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Form 1 Buttons
        private void btnStart_Click(object sender, EventArgs e)
        {
            //Start Button - Leads to the Game
            if (LOGIN.strUserName == null)
            {
                LOGIN login = new LOGIN();
                this.Hide();
                login.Show();
            }
            else
            {
                GameBoard board = new GameBoard();
                this.Hide();
                board.Show();
            }

        }

        private void btnInfo1_Click(object sender, EventArgs e)
        {
            //Info Button - Form to the information regarding the game (eg. developer, credits, etc.)
            lblDate info = new lblDate();
            this.Hide();
            info.Show();
        }

        private void btnHelp1_Click(object sender, EventArgs e)
        {
            //Help Button - Form to the guide regarding how the game
            Help help = new Help();
            this.Hide();
            help.Show();
            
        }

        private void btnLeaderboard1_Click(object sender, EventArgs e)
        {
            //Leaderboard Button - Shows the leaderboard regarding the people who play the game 
            Rank rank = new Rank();
            this.Hide();
            rank.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //exits the game
        }
    }
}

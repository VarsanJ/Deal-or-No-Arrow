//Title: Ranking and Stats
//Purpose: To use data saved from past gameplays to display stats (eg. Number of Total Players) to the user
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deal_Or_No_Arrow
{
    public partial class Rank : Form
    {
        public Rank()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1(); //creates menu to open
            this.Hide(); //hides current window
            menu.Show(); //shows the menu
        }

        private void Rank_Load(object sender, EventArgs e)
        {
            //Creates the arrays for the rankings and the line counter
            string[] strNames;
            int[] intScores;
            int intLines = 0;
            string strValue = "";

            //Creates the file reader variable, counts the number of lines, and closes the file
            StreamReader reader = File.OpenText("rankings.txt");
            string strInput = null;
            while ((strInput = reader.ReadLine()) != null)
            {
                intLines++;
            }
            reader.Close();

            //Declares the arrays with their sizes in order to arrange the variables
            strNames = new string[intLines];
            intScores = new int[intLines];

            //Assigns the values to the arrays by splitting the string based on the comma
            reader = File.OpenText("rankings.txt");
            for (int i = 0; i < intLines; i++)
            {
                strValue = reader.ReadLine();
                strNames[i] = strValue.Substring(0, strValue.IndexOf(","));
                intScores[i] = Int32.Parse(strValue.Substring(strValue.IndexOf(",") + 1));
            }

            //Determines the number of people to earn 10000 score and the number of people to play game, and ammends the display to reflect that
            this.lblNumPlayGame.Text = $"{intLines}"; //number of lines in file = input
            int intTenK = 0;
            for (int i = 0; i  < intLines; i++)
            {
                if (intScores[i] == 10000)
                {
                    intTenK++;
                }
            }
            this.lblNumber.Text = $"{intTenK}"; //updates the label

            //Sorts the arrays of scores in order to determine user with highest and the lowest scores
            int intTemp;
            string strTemp;
            for (int i = 0; i < intLines; i++)
            {
                for (int j = 0; j < intLines - 1; j++) 
                { 
                    if (intScores[j] > intScores[j+1] )
                    {
                        intTemp = intScores[j]; //bubble sorts the grades
                        intScores[j] = intScores[j + 1];
                        intScores[j + 1] = intTemp;

                        strTemp = strNames[j]; //bubble sorts the names
                        strNames[j] = strNames[j+1];
                        strNames[j+1] = strTemp;    
                    }
                }
            }

            //Assigns values to the corresponding variables          
            try
            {
                this.lblLowestName.Text = $"{strNames[0]}";
                this.lblHighestName.Text = $"{strNames[strNames.Length - 1]}";

                this.lblLowestPoints.Text = $"{intScores[0]} points";
                this.lblHighestPoints.Text = $"{intScores[strNames.Length - 1]} points";
            }
            catch
            {
                this.lblLowestName.Text = "N/A";
                this.lblHighestName.Text = "N/A";

                this.lblLowestPoints.Text = "N/A";
                this.lblHighestPoints.Text = "N/A";
            }

            if (LOGIN.strUserName == null)
            { //if does not exist, makes it invisible
                this.lblYou.Visible = false;
                this.lblNameYou.Visible = false;
                this.lblPointsYou.Visible = false;
            }
            else
            { //updates the values if they do exist
                this.lblNameYou.Text = $"{LOGIN.strUserName}";
                this.lblPointsYou.Text = $"{TheEnd.intBest}";
            }
            
        }
    }
}

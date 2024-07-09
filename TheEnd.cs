//TITLE: Ending
//PURPOSE: To facilitate the display of final score, allow for saving the score, and to proceed back to menu
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
    public partial class TheEnd : Form
    {
        public static double dblFinalAmount; //final amount
        public static int intBest;
        
        public TheEnd()
        {
            InitializeComponent();
        }

        private void TheEnd_Load(object sender, EventArgs e)
        {
            this.lblBriefcaseVal.Text = $"{GameBoard.intBriefcaseSelectedValue} points";
            this.lblEarnedPts.Text = $"{(int)GameBoard.dblOffer} points";
            dblFinalAmount = (int)GameBoard.dblOffer;
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            //returns to the menu
            Form1 menu = new Form1();
            this.Hide();
            GameBoard board = new GameBoard();
            board.Close();
            menu.Show();
        }

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            //Variable declaration
            bool boolIsExist = false;
            int intIsExist = 0;
            int intLines = 0;
            string strInput = "";
            string strName = LOGIN.strUserName;

            //File Reading and past information collection
            StreamReader streamReader = File.OpenText("rankings.txt");
            while ((strInput = streamReader.ReadLine()) != null)
            {
                intLines++;
            }
            streamReader.Close();
            streamReader = File.OpenText("rankings.txt");
            for (int i = 0; i < intLines; i++)  //checks if the user already exists
            {
                strInput = streamReader.ReadLine();
                if (strInput.Substring(0, strInput.IndexOf(","))  == strName) //checks for a match
                {
                    boolIsExist = true;
                    intIsExist = Int32.Parse(strInput.Substring(strInput.IndexOf(",") + 1)); //assigns a value
                    break;
                }
            }
            streamReader.Close();

            //Checks for repetition and changes if necessary
            if (boolIsExist == true)
            {
                if (intIsExist >= dblFinalAmount) //No need to change 
                {
                    MessageBox.Show($"User {strName} already exists with a score of {strInput.Substring(strInput.IndexOf(",") + 1)}!\nThis score is greater than or equal to your current score of {dblFinalAmount}");
                    this.btnSaveScore.Enabled = false; //disables further saving since the score is already saved
                    intBest = intIsExist;
                }
                else //need to change exists
                {
                    streamReader = File.OpenText("rankings.txt");
                    string[] strNames = new string[intLines];
                    int[] intScores = new int[intLines];
                    string strValue;
                    for (int i = 0; i < intLines; i++) //moves to the array
                    {
                        strValue = streamReader.ReadLine();
                        strNames[i] = strValue.Substring(0, strValue.IndexOf(","));
                        intScores[i] = Int32.Parse(strValue.Substring(strValue.IndexOf(",") + 1));
                    }
                    for (int i = 0; i < intLines; i++)
                    {
                        if (strNames[i] == strName)
                        {
                            intScores[i] = (int)dblFinalAmount; //changes the file
                        }
                    }
                    streamReader.Close();

                    //Rewrites the whole file
                    FileInfo fileInfo = new FileInfo("rankings.txt");
                    StreamWriter streamWriter = fileInfo.CreateText();
                    for (int i = 0;i < intLines; i++)
                    {
                        streamWriter.WriteLine($"{strNames[i]},{intScores[i]}"); //rewrites the contents from the saved array
                    }
                    streamWriter.Close();


                    MessageBox.Show("Score has been saved!");
                    intBest = (int)dblFinalAmount;

                    this.btnSaveScore.Enabled = false;
                }

            }
            else
            {
                StreamWriter streamWriter = new StreamWriter("rankings.txt", true); //Allows to write in the file
                streamWriter.WriteLine($"{LOGIN.strUserName},{dblFinalAmount}"); //Adds the information to the file
                streamWriter.Close(); //closes the file
                this.btnSaveScore.Enabled = false; //disables further saving since the score is already saved
                MessageBox.Show("Score has been saved!");
                intBest = (int)dblFinalAmount;
            }
            
        }
    }
} 

//Title: GameBoard
//Purpose: The code for the main game, including selections for briefcases, displays for the user, graphics and offers from the banker.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deal_Or_No_Arrow
{
    public partial class GameBoard : Form
    {
        public GameBoard()
        {
            InitializeComponent();
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            this.lblGameInstruction.Text = strUserName + ", Please select briefcase!";
            this.lblPtsOffer.Visible = false;
            this.btnDeal.Visible = false;
            this.btnNoDeal.Visible = false;
            pcbBriefcase1.Enabled = true;
            pcbBriefcase2.Enabled = true;
            pcbBriefCase3.Enabled = true;
            pcbBriefcase4.Enabled = true;
            pcbBriefcase5.Enabled = true;
            pcbBriefcase6.Enabled = true;
            pcbBriefcase7.Enabled = true;
            pcbBriefcase8.Enabled = true;
            lblBrief1.Enabled = true;
            lblBrief2.Enabled = true;   
            lblBrief3.Enabled = true;
            lblBrief4.Enabled = true;
            lblBrief5.Enabled = true;
            lblBrief6.Enabled = true;
            lblBrief7.Enabled = true;
            lblBrief8.Enabled = true;
        }
        
        /*
        CREATION OF VARIABLES

        Creates and assigns values to the variables that are to be used throughout the game
        */
        public static Random randomclass = new Random(); //creates a random to be used if needed
        public static int[] intAllValues = { 1, 2, 25, 50, 100, 500, 1000, 10000 }; //produces all of the values
        public static int[] intActiveValues = { 1, 2, 25, 50, 100, 500, 1000, 10000 };
        public static int[] intSortedValues = new int[8];
        public static int[] intSortedValuesExcludeChosen = new int[8]; //used to determine which briefcase was chosen
        public static int[] intRemainedValues = new int[8]; //used to make offers
        public static int intNumBriefCases = 8;
        public static int intActiveBriefCases = 8;
        public static int intSelected = 0;
        public static int intBriefcaseSelectedValue = -99;
        public static int intMove = 3;
        public static bool boolFirstChosen = false;
        public static int intSelectedBriefcase;
        public static double dblOffer = 0; 

        //Randomly assigns random variables to each spot on the array
        public static int intCounter = 1;
        public static bool[] boolFirstEight = { false, false, false, false, false, false, false, false };
        public static bool[] boolChoosen = { false, false, false, false, false, false, false };

        //Variable For Each of the Three Rounds of Choosing\
        public static bool[] boolRounds = { false, false, false };

        string strUserName = LOGIN.strUserName;

        //Location and Geographic Variables
        public static int intBallLeftOriginal = 0, intBallTopOriginal = 0;

        /*
        INITIAL USER BRIEFCASE CHOICE

        At the start of the game, the user must select a briefcase. This collects that briefcase.
        */
        private void pcbBriefcase1_Click(object sender, EventArgs e)
        {
            if (boolFirstChosen == false)
            {
                intSelected = 1;
                Arrangement();
                Setup();
                //resets the image to reflect it being chosen
                pcbBriefcase1.BackgroundImage = null;
                pcbBriefcase1.BackColor = Color.Green;
                lblBrief1.Text = "CHOSEN";
            }
            else
            {

            }
            
        }

        private void pcbBriefcase2_Click(object sender, EventArgs e)
        {
            if (boolFirstChosen == false)
            {
                intSelected = 2;
                Arrangement();
                Setup();
                //resets the image to reflect it being chosen
                pcbBriefcase2.BackgroundImage = null;
                pcbBriefcase2.BackColor = Color.Green;
                lblBrief2.Text = "CHOSEN";
            }
            else 
            { 
            
            }
            
        }

        private void pcbBriefCase3_Click(object sender, EventArgs e)
        {
            if (boolFirstChosen == false)
            {
                intSelected = 3;
                Arrangement();
                Setup();
                //resets the image to reflect it being chosen
                pcbBriefCase3.BackgroundImage = null;
                pcbBriefCase3.BackColor = Color.Green;
                lblBrief3.Text = "CHOSEN";
            }
            else
            {

            }
            

        }

        private void pcbBriefcase4_Click(object sender, EventArgs e)
        {
            if (boolFirstChosen == false)
            {
                intSelected = 4;
                Arrangement();
                Setup();
                //resets the image to reflect it being chosen
                pcbBriefcase4.BackgroundImage = null;
                pcbBriefcase4.BackColor = Color.Green;
                lblBrief4.Text = "CHOSEN";
            }
            else
            {

            }
            
        }

        private void pcbBriefcase5_Click(object sender, EventArgs e)
        {
            if (boolFirstChosen == false)
            {
                intSelected = 5;
                Arrangement();
                Setup();
                //resets the image to reflect it being chosen
                pcbBriefcase5.BackgroundImage = null;
                pcbBriefcase5.BackColor = Color.Green;
                lblBrief5.Text = "CHOSEN";
            }
            else
            {

            }
            
        }

        private void pcbBriefcase6_Click(object sender, EventArgs e)
        {
            if (boolFirstChosen == false)
            {
                intSelected = 6;
                Arrangement();
                Setup();
                //resets the image to reflect it being chosen
                pcbBriefcase6.BackgroundImage = null;
                pcbBriefcase6.BackColor = Color.Green;
                lblBrief6.Text = "CHOSEN";
            }
            else
            {

            }
            
        }

        private void pcbBriefcase7_Click(object sender, EventArgs e)
        {
            if (boolFirstChosen == false)
            {
                intSelected = 7;
                Arrangement();
                Setup();
                //resets the image to reflect it being chosen
                pcbBriefcase7.BackgroundImage = null;
                pcbBriefcase7.BackColor = Color.Green;
                lblBrief7.Text = "CHOSEN";
            }
            else
            {

            }
            
        }

        private void pcbBriefcase8_Click(object sender, EventArgs e)
        {
            if (boolFirstChosen == false)
            {
                intSelected = 8;
                Arrangement();
                Setup();
                //resets the image to reflect it being chosen
                pcbBriefcase8.BackgroundImage = null;
                pcbBriefcase8.BackColor = Color.Green;
                lblBrief8.Text = "CHOSEN";
            }
            else
            {

            }
            
        }

        private void lblBrief1_Click(object sender, EventArgs e)
        {
            if (boolFirstChosen == false)
            {
                intSelected = 1;
                Arrangement();
                Setup();
                //resets the image to reflect it being chosen
                pcbBriefcase1.BackgroundImage = null;
                pcbBriefcase1.BackColor = Color.Green;
                lblBrief1.Text = "CHOSEN";
            }
            else
            {

            }
            
        }

        private void lblBrief2_Click(object sender, EventArgs e)
        {
            if (boolFirstChosen == false)
            {
                intSelected = 2;
                Arrangement();
                Setup();
                //resets the image to reflect it being chosen
                pcbBriefcase2.BackgroundImage = null;
                pcbBriefcase2.BackColor = Color.Green;
                lblBrief2.Text = "CHOSEN";
            }
            else
            {

            }
            

        }

        private void lblBrief3_Click(object sender, EventArgs e)
        {
            if (boolFirstChosen == false)
            {
                intSelected = 3;
                Arrangement();
                Setup();
                //resets the image to reflect it being chosen
                pcbBriefCase3.BackgroundImage = null;
                pcbBriefCase3.BackColor = Color.Green;
                lblBrief3.Text = "CHOSEN";
            }
            else
            {

            }
            

        }

        private void lblBrief4_Click(object sender, EventArgs e)
        {
            if (boolFirstChosen == false)
            {
                intSelected = 4;
                Arrangement();
                Setup();
                //resets the image to reflect it being chosen
                pcbBriefcase4.BackgroundImage = null;
                pcbBriefcase4.BackColor = Color.Green;
                lblBrief4.Text = "CHOSEN";
            }
            else
            {

            }
            

        }

        private void lblBrief5_Click(object sender, EventArgs e)
        {
            if (boolFirstChosen == false)
            {
                intSelected = 5;
                Arrangement();
                Setup();
                //resets the image to reflect it being chosen
                pcbBriefcase5.BackgroundImage = null;
                pcbBriefcase5.BackColor = Color.Green;
                lblBrief5.Text = "CHOSEN";
            }
            else
            {

            }
            

        }

        private void lblBrief6_Click(object sender, EventArgs e)
        {
            if (boolFirstChosen == false)
            {
                intSelected = 6;
                Arrangement();
                Setup();
                //resets the image to reflect it being chosen
                pcbBriefcase6.BackgroundImage = null;
                pcbBriefcase6.BackColor = Color.Green;
                lblBrief6.Text = "CHOSEN";
            }
            else
            {

            }
            

        }

        private void lblBrief7_Click(object sender, EventArgs e)
        {
            if (boolFirstChosen == false)
            {
                intSelected = 7;
                Arrangement();
                Setup();
                //resets the image to reflect it being chosen
                pcbBriefcase7.BackgroundImage = null;
                pcbBriefcase7.BackColor = Color.Green;
                lblBrief7.Text = "CHOSEN";
            }
            else
            {

            }
            

        }

        private void lblBrief8_Click(object sender, EventArgs e)
        {
            if (boolFirstChosen == false)
            {
                intSelected = 8;
                Arrangement();
                Setup();
                //resets the image to reflect it being chosen
                pcbBriefcase8.BackgroundImage = null;
                pcbBriefcase8.BackColor = Color.Green;
                lblBrief8.Text = "CHOSEN";
            }
            else
            {

            }
            

        }

        //Arrangement and Setup
        public void Arrangement()
        {
            //Randomization using a for loop in order to randomize all the values
            for (int i = 0; i < intSortedValues.Length; i++)
            {
                while (true)
                {
                    int intRan = randomclass.Next(0, 8);
                    if (boolFirstEight[intRan] == false) //assigns that value to the new function
                    {
                        intSortedValues[i] = intAllValues[intRan];
                        boolFirstEight[intRan] = true;
                        break;
                    }
                }               
            }

            //Collects the value of the briefcase selected
            intBriefcaseSelectedValue = intSortedValues[intSelected - 1];

            //Moves the to the records of original sorted, where chosen value assigned a sentinal number
            for (int i = 0; i < intSortedValues.Length; i++)
            {
                intSortedValuesExcludeChosen[i] = intSortedValues[i];
            }

            //In the list except the chosen value, the selected value is declared as -99
            intSortedValuesExcludeChosen[intSelected - 1] = -99;

            //Moves the choosable numbers into the array of remaining numbers
            for (int i = 0; i < intRemainedValues.Length; i++)
            {
                intRemainedValues[i] = intSortedValuesExcludeChosen[i];
            }

            //Creates a temporary array to store all remaining values except the one chosen by the user
            int[] intTemp = new int[intRemainedValues.Length - 1];
            int intIndex = 0;
            for (int j = 0; j < intRemainedValues.Length; j++)
            {
                if (intRemainedValues[j] > 0)
                {
                    intTemp[intIndex] = intRemainedValues[j];
                    intIndex++;
                }
            }

            //Recreates the new array and moves the values back into the array
            intRemainedValues = new int[intTemp.Length];
            for (int j = 0; j < intTemp.Length; j++)
            {
                intRemainedValues[j] = intTemp[j];
            }


            /*
             CODE BELOW IS FOR TESTING PURPOSES ONLY
            */
            //MessageBox.Show($"{intBriefcaseSelectedValue} Chosen");
            /*
            for (int i = 0; i < intSortedValues.Length; i++)
            {
                MessageBox.Show($"{intSortedValues[i]} sorted");
            }
            
            for (int i = 0; i < intSortedValuesExcludeChosen.Length; i++)
            {
                MessageBox.Show($"{intSortedValuesExcludeChosen[i]} altered");
            }
            for (int i = 0; i < intRemainedValues.Length; i++)
            {
                MessageBox.Show($"{intRemainedValues[i]} remaining");
            }
            */
            /*
             CODE ABOVE IS FOR TESTING PURPOSES ONLY
            */


        }

        public void Setup()
        {
            //Assigns the initial positions of the ball to reset to after each fire is performed
            intBallLeftOriginal = this.pcbBall.Left;
            intBallTopOriginal = this.pcbBall.Top;
            
            //Disables the selection of new briefcases since one has already been chosen
            pcbBriefcase1.Enabled = false; 
            pcbBriefcase2.Enabled = false;
            pcbBriefCase3.Enabled = false;
            pcbBriefcase4.Enabled = false;
            pcbBriefcase5.Enabled = false;
            pcbBriefcase6.Enabled = false;
            pcbBriefcase7.Enabled = false;
            pcbBriefcase8.Enabled = false;
            lblBrief1.Enabled = false;
            lblBrief2.Enabled = false;
            lblBrief3.Enabled = false;
            lblBrief4.Enabled = false;
            lblBrief5.Enabled = false;
            lblBrief6.Enabled = false;
            lblBrief7.Enabled = false;
            lblBrief8.Enabled = false;

            this.btnFire.Enabled = true;
            this.lblGameInstruction.Text = strUserName + $", Fire at {intMove} briefcases!";
        }


        //These equations are the big-5 in kinematics, and is used to determine the acceleration of the object.
        public int intHorizontalAcceleration(int intVelocityInitial, int intTime, int intDisplacement)
        {
            int intHorizontalAcceleration = 0; //var declared
            intHorizontalAcceleration = (2 * (intDisplacement - (intVelocityInitial * intTime))) / (intTime * intTime); //rearranged big 5
            return intHorizontalAcceleration; //returns the acceleration
        }


        //User firing the ball
        private void btnFire_Click(object sender, EventArgs e)
        {
            //Declares the variables needed for the big 5
            int intHAcceleration = 0;
            int intHVelocity = 0;

            //When the user fires
            this.btnFire.Enabled = false;
            if (boolRounds[0] == false) //first round
            {
                for (int i = 0; i < intMove; i++) //for the designated number of moves
                {
                    //SELECTION
                    int intChooosing = randomclass.Next(0, intRemainedValues.Length); //selects a value from remaining values
                    int intSelectedValue = intRemainedValues[intChooosing]; //determines the selected value
                    int intTime = 200;
                    RemoveRemaining(intSelectedValue);
                    //looks for the value 
                    for (int intFinder = 0; intFinder < intSortedValues.Length; intFinder++)
                    {
                        //MessageBox.Show($"B{intFinder}");
                        if (intSortedValuesExcludeChosen[intFinder] == intSelectedValue)
                        {
                            intSelectedBriefcase = intFinder; //determines the briefcase number

                            //the movement

                            if (intSelectedBriefcase == 1)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 2)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 3)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 4)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 5)
                            {   
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 6)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 7)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 8)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }   

                            while (true) //vertical component
                            {
                                if (intSelectedBriefcase == 0)
                                {
                                    break;
                                }
                                if (intSelectedBriefcase == 1)
                                {
                                    this.pcbBall.Top = this.pcbBriefcase2.Top;
                                    break;
                                }
                                if (intSelectedBriefcase == 2)
                                {
                                    this.pcbBall.Top = this.pcbBriefCase3.Top;
                                    break;
                                }
                                if (intSelectedBriefcase == 3)
                                {
                                    this.pcbBall.Top = this.pcbBriefcase4.Top;
                                    break;                   
                                }                            
                                if (intSelectedBriefcase == 4)
                                {
                                    this.pcbBall.Top = this.pcbBriefcase5.Top;
                                    break;                   
                                }                            
                                if (intSelectedBriefcase == 5)
                                {
                                    this.pcbBall.Top = this.pcbBriefcase6.Top;
                                    break;                   
                                }                            
                                if (intSelectedBriefcase == 6)
                                {
                                    this.pcbBall.Top = this.pcbBriefcase7.Top;
                                    break;                   
                                }                            
                                if (intSelectedBriefcase == 7)
                                {
                                    this.pcbBall.Top = this.pcbBriefcase8.Top;
                                    break;
                                }
                                                                
                            }

                            while (true) //horizontal component
                            {
                                this.pcbBall.Left += intHVelocity + 1;
                                intHVelocity += intHAcceleration;

                                if (this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase1.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase2.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefCase3.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase4.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase5.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase6.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase7.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase8.Bounds))
                                {
                                    this.pcbBall.Left = intBallLeftOriginal;
                                    this.pcbBall.Top = intBallTopOriginal;
                                    intHAcceleration = 0;
                                    intHVelocity = 0;
                                    break;
                                }


                            }

                            SelectedBriefcaseChanger(intSelectedBriefcase, intSortedValuesExcludeChosen[intFinder]);
                            intSortedValuesExcludeChosen[intFinder] = -99;
                            break;
                        }                     
                    }
                    //removes the value from the remaining value
                    int[] intTemp = new int[intRemainedValues.Length - 1];
                    int intIndex = 0;
                    for (int j = 0; j < intRemainedValues.Length; j++)
                    {
                        if (intRemainedValues[j] != intSelectedValue)
                        {
                            intTemp[intIndex] = intRemainedValues[j]; 
                            intIndex++;
                        }
                    }
                    intRemainedValues = new int[intTemp.Length];
                    for (int j = 0;j < intTemp.Length;j++)
                    {
                        intRemainedValues[j] = intTemp[j];
                    }
                }

                boolRounds[0] = true;
                intMove = 2;
                //Generation of the new user offer
                BankersOffer();
            }
            else if (boolRounds[1] == false) //second round
            {
                for (int i = 0; i < intMove; i++) //for the designated number of moves
                {
                    //SELECTION
                    int intChooosing = randomclass.Next(0, intRemainedValues.Length); //selects a value from remaining values
                    int intSelectedValue = intRemainedValues[intChooosing]; //determines the selected value
                    RemoveRemaining(intSelectedValue);
                    //looks for the value 
                    for (int intFinder = 0; intFinder < intSortedValues.Length; intFinder++)
                    {
                        int intTime = 8;
                        if (intSortedValuesExcludeChosen[intFinder] == intSelectedValue)
                        {
                            intSelectedBriefcase = intFinder;
                            //the movement

                            if (intSelectedBriefcase == 1)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 2)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 3)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 4)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 5)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 6)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 7)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 8)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }

                            while (true) //vertical component
                            {
                                if (intSelectedBriefcase == 0)
                                {
                                    break;
                                }
                                if (intSelectedBriefcase == 1)
                                {
                                    this.pcbBall.Top = this.pcbBriefcase2.Top;
                                    break;
                                }
                                if (intSelectedBriefcase == 2)
                                {
                                    this.pcbBall.Top = this.pcbBriefCase3.Top;
                                    break;
                                }
                                if (intSelectedBriefcase == 3)
                                {
                                    this.pcbBall.Top = this.pcbBriefcase4.Top;
                                    break;
                                }
                                if (intSelectedBriefcase == 4)
                                {
                                    this.pcbBall.Top = this.pcbBriefcase5.Top;
                                    break;
                                }
                                if (intSelectedBriefcase == 5)
                                {
                                    this.pcbBall.Top = this.pcbBriefcase6.Top;
                                    break;
                                }
                                if (intSelectedBriefcase == 6)
                                {
                                    this.pcbBall.Top = this.pcbBriefcase7.Top;
                                    break;
                                }
                                if (intSelectedBriefcase == 7)
                                {
                                    this.pcbBall.Top = this.pcbBriefcase8.Top;
                                    break;
                                }

                            }

                            while (true) //horizontal component
                            {
                                this.pcbBall.Left += intHVelocity + 1;
                                intHVelocity += intHAcceleration;

                                if (this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase1.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase2.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefCase3.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase4.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase5.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase6.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase7.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase8.Bounds))
                                {
                                    this.pcbBall.Left = intBallLeftOriginal;
                                    this.pcbBall.Top = intBallTopOriginal;
                                    intHAcceleration = 0;
                                    intHVelocity = 0;
                                    break;
                                }


                            }

                            //movement end
                            SelectedBriefcaseChanger(intSelectedBriefcase, intSortedValuesExcludeChosen[intFinder]);
                            intSortedValuesExcludeChosen[intFinder] = -99;
                            break;
                        }
                    }
                    //removes the value from the remaining value
                    int[] intTemp = new int[intRemainedValues.Length - 1];
                    int intIndex = 0;
                    for (int j = 0; j < intRemainedValues.Length; j++)
                    {
                        if (intRemainedValues[j] != intSelectedValue)
                        {
                            intTemp[intIndex] = intRemainedValues[j];
                            intIndex++;
                        }
                    }
                    intRemainedValues = new int[intTemp.Length];
                    for (int j = 0; j < intTemp.Length; j++)
                    {
                        intRemainedValues[j] = intTemp[j];
                    }
                }

                boolRounds[1] = true;
                intMove = 1;
                //Generation of the new user offer
                BankersOffer();
            }
            else if (boolRounds[2] == false) //third round
            {
                for (int i = 0; i < intMove; i++) //for the designated number of moves
                {
                    //SELECTION
                    int intChooosing = randomclass.Next(0, intRemainedValues.Length); //selects a value from remaining values
                    int intSelectedValue = intRemainedValues[intChooosing]; //determines the selected value
                    RemoveRemaining(intSelectedValue);
                    //looks for the value 
                    for (int intFinder = 0; intFinder < intSortedValues.Length; intFinder++)
                    {
                        int intTime = 8;
                        //MessageBox.Show($"B{intFinder}");
                        if (intSortedValuesExcludeChosen[intFinder] == intSelectedValue)
                        {
                            intSelectedBriefcase = intFinder;
                            //the movement

                            if (intSelectedBriefcase == 1)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 2)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 3)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 4)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 5)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 6)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 7)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }
                            if (intSelectedBriefcase == 8)
                            {
                                intHAcceleration = intHorizontalAcceleration(0, intTime, this.pcbBriefcase1.Left - this.pcbBall.Left);
                            }

                            while (true) //vertical component
                            {
                                if (intSelectedBriefcase == 0)
                                {
                                    break;
                                }
                                if (intSelectedBriefcase == 1)
                                {
                                    this.pcbBall.Top = this.pcbBriefcase2.Top;
                                    break;
                                }
                                if (intSelectedBriefcase == 2)
                                {
                                    this.pcbBall.Top = this.pcbBriefCase3.Top;
                                    break;
                                }
                                if (intSelectedBriefcase == 3)
                                {
                                    this.pcbBall.Top = this.pcbBriefcase4.Top;
                                    break;
                                }
                                if (intSelectedBriefcase == 4)
                                {
                                    this.pcbBall.Top = this.pcbBriefcase5.Top;
                                    break;
                                }
                                if (intSelectedBriefcase == 5)
                                {
                                    this.pcbBall.Top = this.pcbBriefcase6.Top;
                                    break;
                                }
                                if (intSelectedBriefcase == 6)
                                {
                                    this.pcbBall.Top = this.pcbBriefcase7.Top;
                                    break;
                                }
                                if (intSelectedBriefcase == 7)
                                {
                                    this.pcbBall.Top = this.pcbBriefcase8.Top;
                                    break;
                                }

                            }

                            while (true) //horizontal component
                            {
                                this.pcbBall.Left += intHVelocity + 1;
                                intHVelocity += intHAcceleration;

                                if (this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase1.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase2.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefCase3.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase4.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase5.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase6.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase7.Bounds) || this.pcbBall.Bounds.IntersectsWith(this.pcbBriefcase8.Bounds))
                                {
                                    this.pcbBall.Left = intBallLeftOriginal;
                                    this.pcbBall.Top = intBallTopOriginal;
                                    intHAcceleration = 0;
                                    intHVelocity = 0;
                                    break;
                                }


                            }

                            //movement end
                            SelectedBriefcaseChanger(intSelectedBriefcase, intSortedValuesExcludeChosen[intFinder]);
                            intSortedValuesExcludeChosen[intFinder] = -99;
                            break;
                        }
                    }
                    //removes the value from the remaining value
                    int[] intTemp = new int[intRemainedValues.Length - 1];
                    int intIndex = 0;
                    for (int j = 0; j < intRemainedValues.Length; j++)
                    {
                        if (intRemainedValues[j] != intSelectedValue)
                        {
                            intTemp[intIndex] = intRemainedValues[j];
                            intIndex++;
                        }
                    }
                    intRemainedValues = new int[intTemp.Length];
                    for (int j = 0; j < intTemp.Length; j++)
                    {
                        intRemainedValues[j] = intTemp[j];
                    }
                }


                boolRounds[2] = true;
                intMove = 0;
                BankersOffer();
            }
        }

        public void ExitReset()
        {
            //var changes
            intNumBriefCases = 8;
            intActiveBriefCases = 8;
            intSelected = 0;
            intBriefcaseSelectedValue = -99;
            intMove = 3;
            boolFirstChosen = false;
            dblOffer = 0;
            intCounter = 1;

            //Resets for arrays
            intActiveValues[0] = 1;
            intActiveValues[1] = 2;
            intActiveValues[2] = 25;
            intActiveValues[3] = 50;
            intActiveValues[4] = 100;
            intActiveValues[5] = 500;
            intActiveValues[6] = 1000;
            intActiveValues[7] = 10000;
            intSortedValues = new int[8];
            intSortedValuesExcludeChosen = new int[8];
            intRemainedValues = new int[8];
            boolFirstEight[0] = false;
            boolFirstEight[1] = false;
            boolFirstEight[2] = false;
            boolFirstEight[3] = false;
            boolFirstEight[4] = false;
            boolFirstEight[5] = false;
            boolFirstEight[6] = false;
            boolFirstEight[7] = false;
            boolChoosen[0] = false;
            boolChoosen[1] = false;
            boolChoosen[2] = false;
            boolChoosen[3] = false;
            boolChoosen[4] = false;
            boolChoosen[5] = false;
            boolChoosen[6] = false;
            boolRounds[0] = false;
            boolRounds[1] = false;
            boolRounds[2] = false;

    }

    //Provides User With Their Offer, which they can either accept or reject
    public void BankersOffer()
        {
            //Changes visibility and enabled properties
            this.lblPtsOffer.Visible = true;
            this.btnDeal.Visible = true;
            this.btnNoDeal.Visible = true;
            this.btnFire.Enabled = false;
            dblOffer = 0; //resets offer
            //Collects the user offer 
            for (int i = 0; i < intRemainedValues.Length; i++) 
            {
                dblOffer += intRemainedValues[i];
            }
            dblOffer += intBriefcaseSelectedValue;
            dblOffer = dblOffer / (intRemainedValues.Length + 1);;
            this.lblPtsOffer.Text = $"{(int)dblOffer} points";
            this.lblGameInstruction.Text = "Accept or reject your offer";
        }
        //Selection of Deal or No Deal according to the user 
        private void btnDeal_Click(object sender, EventArgs e) //Deal has been selected by the user
        {
            TheEnd theEnd = new TheEnd();
            this.Close();
            theEnd.Show();


            ExitReset();
        }

        private void btnNoDeal_Click(object sender, EventArgs e)
        {
            //Hidden again and fire enabled to resume 
            this.lblPtsOffer.Visible = false;
            this.btnDeal.Visible = false;
            this.btnNoDeal.Visible = false;
            this.btnFire.Enabled = true;
            this.lblGameInstruction.Text = strUserName + $", Fire at {intMove} briefcases!";
            if (intRemainedValues.Length < 2) //In this case, the user's briefcase is their final amount and is set
            {
                dblOffer = intBriefcaseSelectedValue;
                TheEnd theEnd = new TheEnd();
                this.Close();
                theEnd.Show();

                ExitReset();
            }

        }

        

        //Removes the remaining values from the Remaining List to help user gameboard
        public int RemoveRemaining(int intRemove)
        {
            if (intRemove == 1)
            {
                lbl1.Visible = false;
            }
            else if (intRemove == 2)
            {
                lbl2.Visible = false;
            }
            else if (intRemove == 25)
            {
                lbl25.Visible = false;
            }
            else if (intRemove == 50)
            {
                lbl50.Visible = false;
            }
            else if (intRemove == 100)
            {
                lbl100.Visible = false;
            }
            else if (intRemove == 500)
            {
                lbl500.Visible = false;
            }
            else if (intRemove == 1000)
            {
                lbl1000.Visible = false;
            }
            else if (intRemove == 10000)
            {
                lbl10000.Visible = false;
            }
            return 0;
        }

        private void pcbBall_Click(object sender, EventArgs e)
        {
            
        }

        //Changes the appearance of the selected briefcase
        public int SelectedBriefcaseChanger(int intBriefcase, int intValue)
        {
            if (intBriefcase == 0)
            {
                pcbBriefcase1.BackgroundImage = null;
                pcbBriefcase1.BackColor = Color.Yellow;
                lblBrief1.BackColor = Color.Yellow;
                lblBrief1.ForeColor = Color.Red;
                lblBrief1.Text = $"{intValue}";
            }
            else if (intBriefcase == 1)
            {
                pcbBriefcase2.BackgroundImage = null;
                pcbBriefcase2.BackColor = Color.Yellow;
                lblBrief2.BackColor = Color.Yellow;
                lblBrief2.ForeColor = Color.Red;
                lblBrief2.Text = $"{intValue}";
            }
            else if (intBriefcase == 2)
            {
                pcbBriefCase3.BackgroundImage = null;
                pcbBriefCase3.BackColor = Color.Yellow;
                lblBrief3.BackColor = Color.Yellow;
                lblBrief3.ForeColor = Color.Red;
                lblBrief3.Text = $"{intValue}";
            }
            else if (intBriefcase == 3)
            {
                pcbBriefcase4.BackgroundImage = null;
                pcbBriefcase4.BackColor = Color.Yellow;
                lblBrief4.BackColor = Color.Yellow;
                lblBrief4.ForeColor = Color.Red;
                lblBrief4.Text = $"{intValue}";
            }
            else if (intBriefcase == 4)
            {
                pcbBriefcase5.BackgroundImage = null;
                pcbBriefcase5.BackColor = Color.Yellow;
                lblBrief5.BackColor = Color.Yellow;
                lblBrief5.ForeColor = Color.Red;
                lblBrief5.Text = $"{intValue}";
            }
            else if (intBriefcase == 5)
            {
                pcbBriefcase6.BackgroundImage = null;
                pcbBriefcase6.BackColor = Color.Yellow;
                lblBrief6.BackColor = Color.Yellow;
                lblBrief6.ForeColor = Color.Red;
                lblBrief6.Text = $"{intValue}";
            }
            else if (intBriefcase == 6)
            {
                pcbBriefcase7.BackgroundImage = null;
                pcbBriefcase7.BackColor = Color.Yellow;
                lblBrief7.ForeColor = Color.Red;
                lblBrief7.BackColor = Color.Yellow;
                lblBrief7.Text = $"{intValue}";
            }
            else if (intBriefcase == 7)
            {
                pcbBriefcase8.BackgroundImage = null;
                pcbBriefcase8.BackColor = Color.Yellow;
                lblBrief8.BackColor = Color.Yellow;
                lblBrief8.ForeColor = Color.Red;
                lblBrief8.Text = $"{intValue}";
            }
            return 0;
        }

        
    }
}

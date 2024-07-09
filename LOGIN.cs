//Title: Login
//Purpose: To make profiles for a user if needed
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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        //Variable Declaration
        public static string strUserName; //declares the string name
        public static Random randomGuestNum = new Random();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            strUserName = this.txtCreate.Text; //stores the username
            if (strUserName == "" || strUserName == " ")
            {
                strUserName = "GUEST" + randomGuestNum.Next(10000,100000); //stores the username
            }
            else
            {
                strUserName = this.txtCreate.Text; //stores the username
                if (strUserName.Length > 10)
                {
                    strUserName = strUserName.Substring(0,10); //reduces length of the string
                }
            }         
            
            MessageBox.Show(strUserName + "\n\nUser has been created for the game!"); //displays as a message box
            GameBoard board = new GameBoard();
            this.Hide();
            board.Show();
        }

        private void lblNew_Click(object sender, EventArgs e)
        {

        }

        private void txtCreate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

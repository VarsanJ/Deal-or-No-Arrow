//Title: Help
//Purpose: To display gameplay help to the user
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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1(); //creates menu to open
            this.Hide(); //hides current window
            menu.Show(); //shows the menu
        }

       
    }
}

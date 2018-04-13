using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MortgageCalculator
{
    public partial class frmMortgageResources : Form
    {   //This is the code for the form that displays the resources used in making the Mortgage calculator.
        public frmMortgageResources()
        {
            InitializeComponent();
        }

        private void pbBankRate_Click(object sender, EventArgs e)
        {   //This makes it so when the user clicks the picture of Bankrate, it links to a webpage.
            Process.Start("https://www.bankrate.com/calculators/mortgages/mortgage-calculator.aspx#testid=10413875559_control");
        }

        private void pbWikiHow_Click(object sender, EventArgs e)
        {   //This makes it so when the user clicks the picture of WikiHow, it links to a webpage.
            Process.Start("https://www.wikihow.com/Calculate-Mortgage-Payments");
        }
    }
}

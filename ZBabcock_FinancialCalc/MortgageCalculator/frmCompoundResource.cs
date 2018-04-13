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
    public partial class frmCompoundResource : Form
    {
        public frmCompoundResource()
        {
            InitializeComponent();
        }

        private void pbInvestorGov_Click(object sender, EventArgs e)
        {   //This makes it so when the user clicks the picture of Investor.gov, it links to a webpage.
            Process.Start("https://www.investor.gov/additional-resources/free-financial-planning-tools/compound-interest-calculator");
        }

        private void pbCalculatorSite_Click(object sender, EventArgs e)
        {    //This makes it so when the user clicks the picture of TheCalculatorSite, it links to a webpage.
            Process.Start("https://www.thecalculatorsite.com/articles/finance/compound-interest-formula.php");
        }
    }
}

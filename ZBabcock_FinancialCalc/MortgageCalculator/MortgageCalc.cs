using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortgageCalculator
{
    public partial class frmMortgage : Form
    {
        public frmMortgage()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                var output = Financial.Mortgage(txtInitial.Text, txtDown.Text, txtLoanAmt.Text, txtLoanLength.Text, txtInterest.Text);
                otxtMonth.Text = output.Item1;
                otxtPayoff.Text = output.Item2;
                otxtIntTotal.Text = output.Item3;
                otxtAbsTotal.Text = output.Item4;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInitial.Text = "";
            txtDown.Text = "";
            txtLoanAmt.Text = "";
            txtLoanLength.Text = "";
            txtInterest.Text = "";
            otxtMonth.Text = "";
            otxtPayoff.Text = "";
            otxtIntTotal.Text = "";
            otxtAbsTotal.Text = "";
            
            this.DialogResult = DialogResult.None;
        }
    }
}

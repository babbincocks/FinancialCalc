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
    public partial class frmCompound : Form
    {
        public frmCompound()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double total = 0;
                double principal = double.Parse(txtInitial.Text);
                double interest = double.Parse(txtInterest.Text) / 100;
                double deposit = double.Parse(txtMonthDepo.Text);
                int years = int.Parse(txtYears.Text);
                int compound = 0;
                double depositTotal = 0;

                if (cbCompoundRates.SelectedItem.ToString() == "Annually")
                {

                    compound = 1;
                }
                else if (cbCompoundRates.SelectedItem.ToString() == "Semi-Annually")
                {
                    compound = 2;
                }
                else if (cbCompoundRates.SelectedItem.ToString() == "Quarterly")
                {
                    compound = 4;
                }
                else if (cbCompoundRates.SelectedItem.ToString() == "Monthly")
                {
                    compound = 12;
                }
                else if (cbCompoundRates.SelectedItem.ToString() == "Daily")
                {
                    compound = 365;
                }

                total = principal * Math.Pow((1 + (interest / compound)), (compound * years));
                depositTotal = deposit * ((Math.Pow(1 + (interest / compound), compound * years) - 1) / (interest / compound));
                total += depositTotal;
                txtOutput.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtInitial.Text = "";
                txtInterest.Text = "";
                txtMonthDepo.Text = "";
                txtYears.Text = "";
                txtOutput.Text = "";

                cbCompoundRates.ResetText();
                cbCompoundRates.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mortgageCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

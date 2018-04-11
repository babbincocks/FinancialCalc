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
                if (txtInitial.Text == "" || txtInterest.Text == "" || txtMonthDepo.Text == "" 
                    || txtYears.Text == "" || cbCompoundRates.SelectedIndex == -1)
                {
                    throw new Exception("Please fill in all white text boxes with information, so a proper calculation can be done.");
                }

                else
                {
                    string a = Financial.CompoundInterest(txtInitial.Text, txtInterest.Text, txtMonthDepo.Text, txtYears.Text, cbCompoundRates.SelectedItem.ToString());

                    txtOutput.Text = a;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                this.DialogResult = DialogResult.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Close();
        }


    }
}

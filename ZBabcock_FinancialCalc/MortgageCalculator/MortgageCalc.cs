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
{       //This is the code for the Mortgage Calculator form.
    public partial class frmMortgage : Form
    {
        public frmMortgage()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { //This is the code for the Exit button in the menu strip. It's function is obvious.
            this.Close();
        }

        

        private void btnCalc_Click(object sender, EventArgs e)
        {       //This is the code for the Calculate button near the bottom right corner.
            try
            {
                /*
                To begin, a variable is declared that uses the Mortgage function in the Financial class.
                It's declared as a var data type, as it's going to be handling a tuple, due to
                the nature of the program. It will return four different values, which are assigned to
                the output text boxes that I desire: the first item is the monthly payment amount, 
                the second item is the payoff date, the third is the total interest, and the fourth
                is the absolute total.
                */
                var output = Financial.Mortgage(txtInitial.Text, txtDown.Text, txtLoanAmt.Text, txtLoanLength.Text, txtInterest.Text, txtLoanStart.Text);
                otxtMonth.Text = output.Item1;
                otxtPayoff.Text = output.Item2;
                otxtIntTotal.Text = output.Item3;
                otxtAbsTotal.Text = output.Item4;

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
                //This is the code for the Clear button in the bottom right corner of the form.
                //It simply sets the text value of all text boxes in the form to a null string.
                txtInitial.Text = "";
                txtDown.Text = "";
                txtLoanAmt.Text = "";
                txtLoanLength.Text = "";
                txtInterest.Text = "";
                txtLoanStart.Text = "";
                otxtMonth.Text = "";
                otxtPayoff.Text = "";
                otxtIntTotal.Text = "";
                otxtAbsTotal.Text = "";

                //A strange glitch arises, I think due to this form being a modal form created
                //after the main form. The glitch is that when the Clear button is clicked, the
                //form is closed. This command fixes that.
               DialogResult = DialogResult.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoanSuggest_Click(object sender, EventArgs e)
        {       //This is the code for the "Suggest Down and Loan" button in the Factors group
            //box. The purpose of this button is to suggest a loan amount and/or a down payment
            //based on the initial amount the user put in.
            try
            {
                //First we check to see if the user has even put anything in the Initial Amount text
                //field. If not, this exception is thrown.
                if (txtInitial.Text == "")
                {
                    DialogResult = DialogResult.None;
                    throw new Exception("You need to have at least an initial amount to calculate" +
                        " a down payment and a loan amount." + Environment.NewLine + Environment.NewLine + 
                        "If you are uncertain what an initial amount is considered, examples of such would " +
                        "be the full price of a house or a car.");
                    
                }

                /*
                 To determine what is done, the state of the text boxes is checked. If both the 
                 Down Payment text box and the Loan Amount text box are null, then it calculates
                 a typical down payment (20% of the initial amount), and from there, a loan amount
                 is surmised from subtracting our new down payment from the initial amount.
                 */
                if (txtDown.Text == "" && txtLoanAmt.Text == "")
                {
                    double downSuggest = double.Parse(txtInitial.Text) * 0.2;
                    txtDown.Text = downSuggest.ToString();

                    double loanSuggest = double.Parse(txtInitial.Text) - double.Parse(txtDown.Text);
                    txtLoanAmt.Text = loanSuggest.ToString();
                }
                /*
                 If only the Loan Amount text box is null, the first step of the previous scenario
                 is skipped, and a loan amount is calculated by subtracting the down payment from the
                 initial amount.
                 */
                else if (txtDown.Text != "" && txtLoanAmt.Text == "")
                {
                    double loanSuggest = double.Parse(txtInitial.Text) - double.Parse(txtDown.Text);
                    txtLoanAmt.Text = loanSuggest.ToString();
                }
                /*
                 If both the Down Payment text box and the Loan Amount text box are filled, it is
                 assumed that the user wants a different suggestion than what they've already put in,
                 so the same calculation is done as if there was no information put in.
                 */
                else if (txtDown.Text != "" && txtLoanAmt.Text != "")
                {
                    double downSuggest = double.Parse(txtInitial.Text) * 0.2;
                    txtDown.Text = downSuggest.ToString();

                    double loanSuggest = double.Parse(txtInitial.Text) - double.Parse(txtDown.Text);
                    txtLoanAmt.Text = loanSuggest.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMortgageResources a = new frmMortgageResources();
            a.ShowDialog();
        }
    }
}

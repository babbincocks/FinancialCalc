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
    {   //This is the code for the Compound Interest Calculator form.
        public frmCompound()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {       //This is the code for what happens when the user clicks the "Calculate" button.
            try
            {   /*
                To start off, the program first checks to see if all controls that the user needs to
                put data into actually has data put into it: all text boxes check to see if their
                current value is a null value, and the combo box for the compounding rate checks to
                see if the current index is -1, as that's the index chosen when nothing has been chosen.
                */
                if (txtInitial.Text == "" || txtInterest.Text == "" || txtMonthDepo.Text == "" 
                    || txtYears.Text == "" || cbCompoundRates.SelectedIndex == -1)
                {
                    //If any controls haven't been interacted with, it throws this exception, telling the user what to do.
                    throw new Exception("Please fill in all white text boxes with information, so a proper calculation can be done.");
                }

                else
                {
                    //If everything is fine and filled out, the values the user put in are put into the 
                    //Compound Interest function that I created, and the value it returns is put into a 
                    //string variable called "a".
                    string a = Financial.CompoundInterest(txtInitial.Text, txtInterest.Text, txtMonthDepo.Text, txtYears.Text, cbCompoundRates.SelectedItem.ToString());

                    //The text field that displays the output then shows the value of a.
                    txtOutput.Text = a;

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {       //This is the code for what happens when the user clicks the "Clear" button.
            try
            {
                //Pretty basic stuff: the text values of all of the text boxes are set to a null string.
                txtInitial.Text = "";
                txtInterest.Text = "";
                txtMonthDepo.Text = "";
                txtYears.Text = "";
                txtOutput.Text = "";
                /*
                The combo box for the Compounding rate has two actions performed on it: first the text field
                is reset, so the user doesn't see a box with an entry supposedly chosen, and then the item index
                that is currently chosen is set to the value -1 (which is the value for when nothing has been chosen
                yet).
                */
                cbCompoundRates.ResetText();
                cbCompoundRates.SelectedIndex = -1;

                /*
                This last bit of code resolves a glitch that came up whenever the "Clear" button
                was clicked. Before, the form would close when Clear was clicked, due to the form
                coming up as the modal form. I'm not 100% certain why it happened, but this resolves
                the issue.
                */
                this.DialogResult = DialogResult.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This is just what hitting Exit in the menu bar does. I don't think I really need to explain it.
            Close();
        }

        private void resourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////This is for the menu bar, specifically the "Resources" option. Clicking that will open a new form that will display Resources used
            //in the making of this part of the program.
            frmCompoundResource a = new frmCompoundResource();
            a.ShowDialog();
        }
    }
}

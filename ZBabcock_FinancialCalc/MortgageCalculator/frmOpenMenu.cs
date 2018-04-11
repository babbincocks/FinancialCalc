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
    public partial class frmOpenMenu : Form
    {
        public frmOpenMenu()
        {
            InitializeComponent();
        }

        private void btnCompound_Click(object sender, EventArgs e)
        {
            try
            {
                //This is very simple; this just creates a new, modal window of the Compound 
                //Interest form when the "Compound Interest Calculator" button is clicked.

                frmCompound a = new frmCompound();
                a.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMortgage_Click(object sender, EventArgs e)
        {
            try
            {
                //This creates a new, modal window of the Mortgage Calculator form
                //when the "Mortgage Calculator" button is clicked.

                frmMortgage a = new frmMortgage();
                a.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

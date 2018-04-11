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

        private void compoundInterestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCompound a = new frmCompound();
            a.ShowDialog();
            this.Close();
        }
    }
}

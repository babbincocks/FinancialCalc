namespace MortgageCalculator
{
    partial class frmMortgage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMortgageBar = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.gbAttributes = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoanLength = new System.Windows.Forms.TextBox();
            this.txtLoanAmt = new System.Windows.Forms.TextBox();
            this.txtDown = new System.Windows.Forms.TextBox();
            this.txtInitial = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.otxtAbsTotal = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.otxtPayoff = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.otxtIntTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.otxtMonth = new System.Windows.Forms.TextBox();
            this.msMortgageBar.SuspendLayout();
            this.gbAttributes.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMortgageBar
            // 
            this.msMortgageBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.msMortgageBar.Location = new System.Drawing.Point(0, 0);
            this.msMortgageBar.Name = "msMortgageBar";
            this.msMortgageBar.Size = new System.Drawing.Size(435, 24);
            this.msMortgageBar.TabIndex = 0;
            this.msMortgageBar.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Absolute Total";
            // 
            // gbAttributes
            // 
            this.gbAttributes.Controls.Add(this.txtInterest);
            this.gbAttributes.Controls.Add(this.label5);
            this.gbAttributes.Controls.Add(this.label3);
            this.gbAttributes.Controls.Add(this.label4);
            this.gbAttributes.Controls.Add(this.label2);
            this.gbAttributes.Controls.Add(this.label1);
            this.gbAttributes.Controls.Add(this.txtLoanLength);
            this.gbAttributes.Controls.Add(this.txtLoanAmt);
            this.gbAttributes.Controls.Add(this.txtDown);
            this.gbAttributes.Controls.Add(this.txtInitial);
            this.gbAttributes.Location = new System.Drawing.Point(12, 65);
            this.gbAttributes.Name = "gbAttributes";
            this.gbAttributes.Size = new System.Drawing.Size(239, 242);
            this.gbAttributes.TabIndex = 22;
            this.gbAttributes.TabStop = false;
            this.gbAttributes.Text = "Factors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Yearly Interest Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Amount Loaned";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Loan Length (in months)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Down Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Initial Amount";
            // 
            // txtLoanLength
            // 
            this.txtLoanLength.Location = new System.Drawing.Point(13, 161);
            this.txtLoanLength.Name = "txtLoanLength";
            this.txtLoanLength.Size = new System.Drawing.Size(96, 20);
            this.txtLoanLength.TabIndex = 3;
            // 
            // txtLoanAmt
            // 
            this.txtLoanAmt.Location = new System.Drawing.Point(13, 113);
            this.txtLoanAmt.Name = "txtLoanAmt";
            this.txtLoanAmt.Size = new System.Drawing.Size(96, 20);
            this.txtLoanAmt.TabIndex = 2;
            // 
            // txtDown
            // 
            this.txtDown.Location = new System.Drawing.Point(13, 65);
            this.txtDown.Name = "txtDown";
            this.txtDown.Size = new System.Drawing.Size(96, 20);
            this.txtDown.TabIndex = 1;
            // 
            // txtInitial
            // 
            this.txtInitial.Location = new System.Drawing.Point(13, 19);
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Size = new System.Drawing.Size(96, 20);
            this.txtInitial.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(341, 314);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 36);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(253, 314);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(82, 36);
            this.btnCalc.TabIndex = 20;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // otxtAbsTotal
            // 
            this.otxtAbsTotal.Location = new System.Drawing.Point(285, 271);
            this.otxtAbsTotal.Name = "otxtAbsTotal";
            this.otxtAbsTotal.ReadOnly = true;
            this.otxtAbsTotal.Size = new System.Drawing.Size(119, 20);
            this.otxtAbsTotal.TabIndex = 19;
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(13, 203);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(96, 20);
            this.txtInterest.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Pay-off Date";
            // 
            // otxtPayoff
            // 
            this.otxtPayoff.Location = new System.Drawing.Point(285, 150);
            this.otxtPayoff.Name = "otxtPayoff";
            this.otxtPayoff.ReadOnly = true;
            this.otxtPayoff.Size = new System.Drawing.Size(119, 20);
            this.otxtPayoff.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Total Interest";
            // 
            // otxtIntTotal
            // 
            this.otxtIntTotal.Location = new System.Drawing.Point(285, 209);
            this.otxtIntTotal.Name = "otxtIntTotal";
            this.otxtIntTotal.ReadOnly = true;
            this.otxtIntTotal.Size = new System.Drawing.Size(119, 20);
            this.otxtIntTotal.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(300, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Monthly Payment";
            // 
            // otxtMonth
            // 
            this.otxtMonth.Location = new System.Drawing.Point(285, 87);
            this.otxtMonth.Name = "otxtMonth";
            this.otxtMonth.ReadOnly = true;
            this.otxtMonth.Size = new System.Drawing.Size(119, 20);
            this.otxtMonth.TabIndex = 28;
            // 
            // frmMortgage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 362);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.otxtMonth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.otxtIntTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.otxtPayoff);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbAttributes);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.otxtAbsTotal);
            this.Controls.Add(this.msMortgageBar);
            this.MainMenuStrip = this.msMortgageBar;
            this.Name = "frmMortgage";
            this.Text = "MortgageCalc";
            this.msMortgageBar.ResumeLayout(false);
            this.msMortgageBar.PerformLayout();
            this.gbAttributes.ResumeLayout(false);
            this.gbAttributes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMortgageBar;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbAttributes;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoanLength;
        private System.Windows.Forms.TextBox txtLoanAmt;
        private System.Windows.Forms.TextBox txtDown;
        private System.Windows.Forms.TextBox txtInitial;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox otxtAbsTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox otxtPayoff;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox otxtIntTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox otxtMonth;
    }
}
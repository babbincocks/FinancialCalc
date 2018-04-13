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
            this.txtInterest = new System.Windows.Forms.TextBox();
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
            this.label7 = new System.Windows.Forms.Label();
            this.otxtPayoff = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.otxtIntTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.otxtMonth = new System.Windows.Forms.TextBox();
            this.txtLoanStart = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLoanSuggest = new System.Windows.Forms.Button();
            this.resourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.msMortgageBar.Size = new System.Drawing.Size(563, 24);
            this.msMortgageBar.TabIndex = 0;
            this.msMortgageBar.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resourcesToolStripMenuItem,
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
            this.label6.Location = new System.Drawing.Point(415, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Absolute Total";
            // 
            // gbAttributes
            // 
            this.gbAttributes.Controls.Add(this.btnLoanSuggest);
            this.gbAttributes.Controls.Add(this.label12);
            this.gbAttributes.Controls.Add(this.label11);
            this.gbAttributes.Controls.Add(this.txtLoanStart);
            this.gbAttributes.Controls.Add(this.label10);
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
            this.gbAttributes.Location = new System.Drawing.Point(24, 93);
            this.gbAttributes.Name = "gbAttributes";
            this.gbAttributes.Size = new System.Drawing.Size(309, 285);
            this.gbAttributes.TabIndex = 22;
            this.gbAttributes.TabStop = false;
            this.gbAttributes.Text = "Factors";
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(13, 204);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(96, 20);
            this.txtInterest.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Yearly Interest Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Amount Loaned";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Loan Length (in months)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Down Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Initial Amount";
            // 
            // txtLoanLength
            // 
            this.txtLoanLength.Location = new System.Drawing.Point(13, 160);
            this.txtLoanLength.Name = "txtLoanLength";
            this.txtLoanLength.Size = new System.Drawing.Size(96, 20);
            this.txtLoanLength.TabIndex = 4;
            // 
            // txtLoanAmt
            // 
            this.txtLoanAmt.Location = new System.Drawing.Point(13, 114);
            this.txtLoanAmt.Name = "txtLoanAmt";
            this.txtLoanAmt.Size = new System.Drawing.Size(96, 20);
            this.txtLoanAmt.TabIndex = 3;
            // 
            // txtDown
            // 
            this.txtDown.Location = new System.Drawing.Point(13, 66);
            this.txtDown.Name = "txtDown";
            this.txtDown.Size = new System.Drawing.Size(96, 20);
            this.txtDown.TabIndex = 1;
            // 
            // txtInitial
            // 
            this.txtInitial.Location = new System.Drawing.Point(13, 21);
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Size = new System.Drawing.Size(96, 20);
            this.txtInitial.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(456, 342);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 36);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(368, 342);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(82, 36);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // otxtAbsTotal
            // 
            this.otxtAbsTotal.BackColor = System.Drawing.Color.Silver;
            this.otxtAbsTotal.Location = new System.Drawing.Point(396, 303);
            this.otxtAbsTotal.Name = "otxtAbsTotal";
            this.otxtAbsTotal.ReadOnly = true;
            this.otxtAbsTotal.Size = new System.Drawing.Size(119, 20);
            this.otxtAbsTotal.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Pay-off Date";
            // 
            // otxtPayoff
            // 
            this.otxtPayoff.BackColor = System.Drawing.Color.Silver;
            this.otxtPayoff.Location = new System.Drawing.Point(396, 182);
            this.otxtPayoff.Name = "otxtPayoff";
            this.otxtPayoff.ReadOnly = true;
            this.otxtPayoff.Size = new System.Drawing.Size(119, 20);
            this.otxtPayoff.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Total Interest";
            // 
            // otxtIntTotal
            // 
            this.otxtIntTotal.BackColor = System.Drawing.Color.Silver;
            this.otxtIntTotal.Location = new System.Drawing.Point(396, 241);
            this.otxtIntTotal.Name = "otxtIntTotal";
            this.otxtIntTotal.ReadOnly = true;
            this.otxtIntTotal.Size = new System.Drawing.Size(119, 20);
            this.otxtIntTotal.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Monthly Payment";
            // 
            // otxtMonth
            // 
            this.otxtMonth.BackColor = System.Drawing.Color.Silver;
            this.otxtMonth.Location = new System.Drawing.Point(396, 119);
            this.otxtMonth.Name = "otxtMonth";
            this.otxtMonth.ReadOnly = true;
            this.otxtMonth.Size = new System.Drawing.Size(119, 20);
            this.otxtMonth.TabIndex = 9;
            // 
            // txtLoanStart
            // 
            this.txtLoanStart.Location = new System.Drawing.Point(13, 247);
            this.txtLoanStart.Name = "txtLoanStart";
            this.txtLoanStart.Size = new System.Drawing.Size(96, 20);
            this.txtLoanStart.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(115, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 33);
            this.label10.TabIndex = 17;
            this.label10.Text = "Loan Start Date (YYYY-MM-DD)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(50, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 25);
            this.label12.TabIndex = 20;
            this.label12.Text = "=";
            // 
            // btnLoanSuggest
            // 
            this.btnLoanSuggest.Location = new System.Drawing.Point(203, 59);
            this.btnLoanSuggest.Name = "btnLoanSuggest";
            this.btnLoanSuggest.Size = new System.Drawing.Size(91, 42);
            this.btnLoanSuggest.TabIndex = 2;
            this.btnLoanSuggest.Text = "Suggest Down and Loan";
            this.btnLoanSuggest.UseVisualStyleBackColor = true;
            this.btnLoanSuggest.Click += new System.EventHandler(this.btnLoanSuggest_Click);
            // 
            // resourcesToolStripMenuItem
            // 
            this.resourcesToolStripMenuItem.Name = "resourcesToolStripMenuItem";
            this.resourcesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resourcesToolStripMenuItem.Text = "Resources";
            this.resourcesToolStripMenuItem.Click += new System.EventHandler(this.resourcesToolStripMenuItem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(183, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 27);
            this.lblTitle.TabIndex = 30;
            this.lblTitle.Text = "Mortgage Calculator";
            // 
            // frmMortgage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(563, 405);
            this.Controls.Add(this.lblTitle);
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
        private System.Windows.Forms.TextBox txtLoanStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLoanSuggest;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem resourcesToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
    }
}
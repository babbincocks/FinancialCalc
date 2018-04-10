﻿namespace MortgageCalculator
{
    partial class frmCompound
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
            this.txtInitial = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.txtMonthDepo = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCompoundRates = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbAttributes = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mortgageCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAttributes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInitial
            // 
            this.txtInitial.Location = new System.Drawing.Point(13, 19);
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Size = new System.Drawing.Size(96, 20);
            this.txtInitial.TabIndex = 0;
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(13, 65);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(96, 20);
            this.txtInterest.TabIndex = 1;
            // 
            // txtMonthDepo
            // 
            this.txtMonthDepo.Location = new System.Drawing.Point(13, 113);
            this.txtMonthDepo.Name = "txtMonthDepo";
            this.txtMonthDepo.Size = new System.Drawing.Size(96, 20);
            this.txtMonthDepo.TabIndex = 2;
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(13, 161);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(96, 20);
            this.txtYears.TabIndex = 3;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(254, 139);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(119, 20);
            this.txtOutput.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(273, 174);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(82, 36);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(273, 232);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 36);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Interest Rate";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(117, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Avg. Additional Deposit / Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "# of Years";
            // 
            // cbCompoundRates
            // 
            this.cbCompoundRates.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCompoundRates.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCompoundRates.Items.AddRange(new object[] {
            "Annually",
            "Semi-Annually",
            "Quarterly",
            "Monthly",
            "Daily"});
            this.cbCompoundRates.Location = new System.Drawing.Point(13, 203);
            this.cbCompoundRates.Name = "cbCompoundRates";
            this.cbCompoundRates.Size = new System.Drawing.Size(96, 21);
            this.cbCompoundRates.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Yearly Compound Rate";
            // 
            // gbAttributes
            // 
            this.gbAttributes.Controls.Add(this.label5);
            this.gbAttributes.Controls.Add(this.label3);
            this.gbAttributes.Controls.Add(this.cbCompoundRates);
            this.gbAttributes.Controls.Add(this.label4);
            this.gbAttributes.Controls.Add(this.label2);
            this.gbAttributes.Controls.Add(this.label1);
            this.gbAttributes.Controls.Add(this.txtYears);
            this.gbAttributes.Controls.Add(this.txtMonthDepo);
            this.gbAttributes.Controls.Add(this.txtInterest);
            this.gbAttributes.Controls.Add(this.txtInitial);
            this.gbAttributes.Location = new System.Drawing.Point(12, 29);
            this.gbAttributes.Name = "gbAttributes";
            this.gbAttributes.Size = new System.Drawing.Size(236, 242);
            this.gbAttributes.TabIndex = 16;
            this.gbAttributes.TabStop = false;
            this.gbAttributes.Text = "Factors";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(385, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.fileToolStripMenuItem.Text = "Options";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mortgageCalculatorToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // mortgageCalculatorToolStripMenuItem
            // 
            this.mortgageCalculatorToolStripMenuItem.Name = "mortgageCalculatorToolStripMenuItem";
            this.mortgageCalculatorToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.mortgageCalculatorToolStripMenuItem.Text = "Mortgage Calculator";
            this.mortgageCalculatorToolStripMenuItem.Click += new System.EventHandler(this.mortgageCalculatorToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmCompound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 347);
            this.Controls.Add(this.gbAttributes);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCompound";
            this.Text = "Compound Interest";
            this.gbAttributes.ResumeLayout(false);
            this.gbAttributes.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInitial;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.TextBox txtMonthDepo;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCompoundRates;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbAttributes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mortgageCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

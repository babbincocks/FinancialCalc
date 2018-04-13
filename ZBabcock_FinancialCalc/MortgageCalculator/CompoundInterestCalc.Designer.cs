namespace MortgageCalculator
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
            this.msCompoundBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.resourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbAttributes.SuspendLayout();
            this.msCompoundBar.SuspendLayout();
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
            this.txtOutput.Location = new System.Drawing.Point(266, 155);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(119, 20);
            this.txtOutput.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(285, 190);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(82, 36);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(285, 248);
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
            "Monthly"});
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
            this.gbAttributes.Location = new System.Drawing.Point(12, 42);
            this.gbAttributes.Name = "gbAttributes";
            this.gbAttributes.Size = new System.Drawing.Size(236, 242);
            this.gbAttributes.TabIndex = 16;
            this.gbAttributes.TabStop = false;
            this.gbAttributes.Text = "Factors";
            // 
            // msCompoundBar
            // 
            this.msCompoundBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.msCompoundBar.Location = new System.Drawing.Point(0, 0);
            this.msCompoundBar.Name = "msCompoundBar";
            this.msCompoundBar.Size = new System.Drawing.Size(397, 24);
            this.msCompoundBar.TabIndex = 17;
            this.msCompoundBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resourcesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.fileToolStripMenuItem.Text = "Options";
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
            this.label6.Location = new System.Drawing.Point(296, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Final Total";
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
            this.lblTitle.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(262, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(121, 78);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Compound Interest Calculator";
            // 
            // frmCompound
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(397, 339);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbAttributes);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.msCompoundBar);
            this.HelpButton = true;
            this.MainMenuStrip = this.msCompoundBar;
            this.Name = "frmCompound";
            this.Text = "Compound Interest";
            this.gbAttributes.ResumeLayout(false);
            this.gbAttributes.PerformLayout();
            this.msCompoundBar.ResumeLayout(false);
            this.msCompoundBar.PerformLayout();
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
        private System.Windows.Forms.MenuStrip msCompoundBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem resourcesToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
    }
}


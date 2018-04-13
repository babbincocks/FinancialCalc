namespace MortgageCalculator
{
    partial class frmCompoundResource
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
            this.pbCalculatorSite = new System.Windows.Forms.PictureBox();
            this.pbInvestorGov = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalculatorSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInvestorGov)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCalculatorSite
            // 
            this.pbCalculatorSite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCalculatorSite.Image = global::MortgageCalculator.Properties.Resources.TheCalculatorSite;
            this.pbCalculatorSite.Location = new System.Drawing.Point(12, 127);
            this.pbCalculatorSite.Name = "pbCalculatorSite";
            this.pbCalculatorSite.Size = new System.Drawing.Size(257, 140);
            this.pbCalculatorSite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCalculatorSite.TabIndex = 1;
            this.pbCalculatorSite.TabStop = false;
            this.pbCalculatorSite.Click += new System.EventHandler(this.pbCalculatorSite_Click);
            // 
            // pbInvestorGov
            // 
            this.pbInvestorGov.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbInvestorGov.Image = global::MortgageCalculator.Properties.Resources.InvestorGov;
            this.pbInvestorGov.Location = new System.Drawing.Point(12, 12);
            this.pbInvestorGov.Name = "pbInvestorGov";
            this.pbInvestorGov.Size = new System.Drawing.Size(327, 92);
            this.pbInvestorGov.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInvestorGov.TabIndex = 0;
            this.pbInvestorGov.TabStop = false;
            this.pbInvestorGov.Click += new System.EventHandler(this.pbInvestorGov_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Links to a different calculator for determining compound interest.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 58);
            this.label2.TabIndex = 3;
            this.label2.Text = "Links to a very useful and thorough explanation on how to properly calculate comp" +
    "ound interest and monthly additions to such.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(265, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 140);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(345, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 92);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // frmCompoundResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(466, 349);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbCalculatorSite);
            this.Controls.Add(this.pbInvestorGov);
            this.Name = "frmCompoundResource";
            this.Text = "Compound Interest Resources";
            ((System.ComponentModel.ISupportInitialize)(this.pbCalculatorSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInvestorGov)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbInvestorGov;
        private System.Windows.Forms.PictureBox pbCalculatorSite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
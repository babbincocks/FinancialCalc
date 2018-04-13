namespace MortgageCalculator
{
    partial class frmMortgageResources
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
            this.pbWikiHow = new System.Windows.Forms.PictureBox();
            this.pbBankRate = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWikiHow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBankRate)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWikiHow
            // 
            this.pbWikiHow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbWikiHow.Image = global::MortgageCalculator.Properties.Resources.WikiHow;
            this.pbWikiHow.Location = new System.Drawing.Point(20, 199);
            this.pbWikiHow.Name = "pbWikiHow";
            this.pbWikiHow.Size = new System.Drawing.Size(275, 115);
            this.pbWikiHow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWikiHow.TabIndex = 1;
            this.pbWikiHow.TabStop = false;
            this.pbWikiHow.Click += new System.EventHandler(this.pbWikiHow_Click);
            // 
            // pbBankRate
            // 
            this.pbBankRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbBankRate.Image = global::MortgageCalculator.Properties.Resources.BankRate;
            this.pbBankRate.Location = new System.Drawing.Point(20, 27);
            this.pbBankRate.Name = "pbBankRate";
            this.pbBankRate.Size = new System.Drawing.Size(298, 96);
            this.pbBankRate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBankRate.TabIndex = 0;
            this.pbBankRate.TabStop = false;
            this.pbBankRate.Click += new System.EventHandler(this.pbBankRate_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(324, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 94);
            this.label1.TabIndex = 2;
            this.label1.Text = "This links to a mortgage calculator that was quite useful, and provided quite a b" +
    "it of information on the different aspects of paying a mortgage and a loan.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(301, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 94);
            this.label2.TabIndex = 3;
            this.label2.Text = "This links to WikiHow, everyone\'s favorite source of knowledge. It provided me th" +
    "e formula for calculating monthly payments, which let me calculate everything el" +
    "se.";
            // 
            // frmMortgageResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(466, 349);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbWikiHow);
            this.Controls.Add(this.pbBankRate);
            this.Name = "frmMortgageResources";
            this.Text = "Mortgage Resources";
            ((System.ComponentModel.ISupportInitialize)(this.pbWikiHow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBankRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBankRate;
        private System.Windows.Forms.PictureBox pbWikiHow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWikiHow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBankRate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 88);
            this.label1.TabIndex = 2;
            this.label1.Text = "This links to a mortgage calculator that was quite useful, and provided quite a b" +
    "it of information on the different aspects of paying a mortgage and a loan.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 94);
            this.label2.TabIndex = 3;
            this.label2.Text = "This links to WikiHow, everyone\'s favorite source of knowledge. It provided me th" +
    "e formula for calculating monthly payments, which let me calculate everything el" +
    "se.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(318, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 102);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(294, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 122);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // frmMortgageResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(484, 349);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbWikiHow);
            this.Controls.Add(this.pbBankRate);
            this.Name = "frmMortgageResources";
            this.Text = "Mortgage Resources";
            ((System.ComponentModel.ISupportInitialize)(this.pbWikiHow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBankRate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBankRate;
        private System.Windows.Forms.PictureBox pbWikiHow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
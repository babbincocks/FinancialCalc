namespace MortgageCalculator
{
    partial class frmOpenMenu
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
            this.btnCompound = new System.Windows.Forms.Button();
            this.btnMortgage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompound
            // 
            this.btnCompound.Location = new System.Drawing.Point(22, 51);
            this.btnCompound.Name = "btnCompound";
            this.btnCompound.Size = new System.Drawing.Size(101, 42);
            this.btnCompound.TabIndex = 0;
            this.btnCompound.Text = "Compound Interest Calculator";
            this.btnCompound.UseVisualStyleBackColor = true;
            this.btnCompound.Click += new System.EventHandler(this.btnCompound_Click);
            // 
            // btnMortgage
            // 
            this.btnMortgage.Location = new System.Drawing.Point(169, 51);
            this.btnMortgage.Name = "btnMortgage";
            this.btnMortgage.Size = new System.Drawing.Size(101, 42);
            this.btnMortgage.TabIndex = 1;
            this.btnMortgage.Text = "Mortgage Calculator";
            this.btnMortgage.UseVisualStyleBackColor = true;
            this.btnMortgage.Click += new System.EventHandler(this.btnMortgage_Click);
            // 
            // frmOpenMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 137);
            this.Controls.Add(this.btnMortgage);
            this.Controls.Add(this.btnCompound);
            this.Name = "frmOpenMenu";
            this.Text = "Selection Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompound;
        private System.Windows.Forms.Button btnMortgage;
    }
}
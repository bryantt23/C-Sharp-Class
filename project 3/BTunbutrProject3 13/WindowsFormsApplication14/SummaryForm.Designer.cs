namespace WindowsFormsApplication14
{
    partial class SummaryForm
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
            this.summarySubTotal = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // summarySubTotal
            // 
            this.summarySubTotal.AutoSize = true;
            this.summarySubTotal.Location = new System.Drawing.Point(58, 69);
            this.summarySubTotal.Name = "summarySubTotal";
            this.summarySubTotal.Size = new System.Drawing.Size(0, 13);
            this.summarySubTotal.TabIndex = 0;
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Location = new System.Drawing.Point(34, 37);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(0, 13);
            this.summaryLabel.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(154, 211);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(98, 34);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.summarySubTotal);
            this.Name = "SummaryForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label summarySubTotal;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.Button okButton;
    }
}
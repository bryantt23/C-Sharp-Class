namespace WindowsFormsApplication14
{
    partial class Form1
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
            this.partsChargesLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.RichTextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.jobNumberLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.hoursOfLaborTextBox = new System.Windows.Forms.RichTextBox();
            this.hoursOfLaborLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.subtotalInfoLabel = new System.Windows.Forms.Label();
            this.salesTaxInfoLabel = new System.Windows.Forms.Label();
            this.totalInfoLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobLabel = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.newCustomerButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // partsChargesLabel
            // 
            this.partsChargesLabel.AutoSize = true;
            this.partsChargesLabel.Location = new System.Drawing.Point(22, 116);
            this.partsChargesLabel.Name = "partsChargesLabel";
            this.partsChargesLabel.Size = new System.Drawing.Size(77, 13);
            this.partsChargesLabel.TabIndex = 11;
            this.partsChargesLabel.Text = "Parts Repaired";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(116, 75);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(100, 25);
            this.customerNameTextBox.TabIndex = 10;
            this.customerNameTextBox.Text = "";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(22, 78);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.customerNameLabel.TabIndex = 8;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // jobNumberLabel
            // 
            this.jobNumberLabel.AutoSize = true;
            this.jobNumberLabel.Location = new System.Drawing.Point(22, 40);
            this.jobNumberLabel.Name = "jobNumberLabel";
            this.jobNumberLabel.Size = new System.Drawing.Size(64, 13);
            this.jobNumberLabel.TabIndex = 7;
            this.jobNumberLabel.Text = "Job Number";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(22, 208);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(46, 13);
            this.subtotalLabel.TabIndex = 17;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // hoursOfLaborTextBox
            // 
            this.hoursOfLaborTextBox.Location = new System.Drawing.Point(116, 151);
            this.hoursOfLaborTextBox.Name = "hoursOfLaborTextBox";
            this.hoursOfLaborTextBox.Size = new System.Drawing.Size(100, 25);
            this.hoursOfLaborTextBox.TabIndex = 15;
            this.hoursOfLaborTextBox.Text = "";
            // 
            // hoursOfLaborLabel
            // 
            this.hoursOfLaborLabel.AutoSize = true;
            this.hoursOfLaborLabel.Location = new System.Drawing.Point(22, 154);
            this.hoursOfLaborLabel.Name = "hoursOfLaborLabel";
            this.hoursOfLaborLabel.Size = new System.Drawing.Size(77, 13);
            this.hoursOfLaborLabel.TabIndex = 13;
            this.hoursOfLaborLabel.Text = "Hours of Labor";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(22, 277);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 21;
            this.totalLabel.Text = "Total";
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Location = new System.Drawing.Point(22, 239);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(54, 13);
            this.salesTaxLabel.TabIndex = 19;
            this.salesTaxLabel.Text = "Sales Tax";
            // 
            // subtotalInfoLabel
            // 
            this.subtotalInfoLabel.AutoSize = true;
            this.subtotalInfoLabel.Location = new System.Drawing.Point(113, 208);
            this.subtotalInfoLabel.Name = "subtotalInfoLabel";
            this.subtotalInfoLabel.Size = new System.Drawing.Size(0, 13);
            this.subtotalInfoLabel.TabIndex = 22;
            // 
            // salesTaxInfoLabel
            // 
            this.salesTaxInfoLabel.AutoSize = true;
            this.salesTaxInfoLabel.Location = new System.Drawing.Point(113, 239);
            this.salesTaxInfoLabel.Name = "salesTaxInfoLabel";
            this.salesTaxInfoLabel.Size = new System.Drawing.Size(0, 13);
            this.salesTaxInfoLabel.TabIndex = 23;
            // 
            // totalInfoLabel
            // 
            this.totalInfoLabel.AutoSize = true;
            this.totalInfoLabel.Location = new System.Drawing.Point(113, 277);
            this.totalInfoLabel.Name = "totalInfoLabel";
            this.totalInfoLabel.Size = new System.Drawing.Size(0, 13);
            this.totalInfoLabel.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(421, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.filesToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.newCustomerToolStripMenuItem,
            this.summaryToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.editToolStripMenuItem.Text = "&Tools";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.calculateToolStripMenuItem.Text = "&Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newCustomerToolStripMenuItem.Text = "&New Customer";
            this.newCustomerToolStripMenuItem.Click += new System.EventHandler(this.newCustomerToolStripMenuItem_Click);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.summaryToolStripMenuItem.Text = "&Summary";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // jobLabel
            // 
            this.jobLabel.AutoSize = true;
            this.jobLabel.Location = new System.Drawing.Point(113, 40);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(0, 13);
            this.jobLabel.TabIndex = 26;
            this.jobLabel.Click += new System.EventHandler(this.jobLabel_Click);
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Items.AddRange(new object[] {
            "Battery",
            "Engine",
            "Sparkplugs",
            "Wipers"});
            this.groupComboBox.Location = new System.Drawing.Point(116, 113);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(100, 21);
            this.groupComboBox.TabIndex = 27;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(286, 66);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(118, 37);
            this.calculateButton.TabIndex = 28;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // newCustomerButton
            // 
            this.newCustomerButton.Location = new System.Drawing.Point(286, 116);
            this.newCustomerButton.Name = "newCustomerButton";
            this.newCustomerButton.Size = new System.Drawing.Size(118, 37);
            this.newCustomerButton.TabIndex = 29;
            this.newCustomerButton.Text = "&New Customer";
            this.newCustomerButton.UseVisualStyleBackColor = true;
            this.newCustomerButton.Click += new System.EventHandler(this.newCustomerToolStripMenuItem_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(286, 169);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(118, 37);
            this.summaryButton.TabIndex = 30;
            this.summaryButton.Text = "&Summary";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 335);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.newCustomerButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.jobLabel);
            this.Controls.Add(this.totalInfoLabel);
            this.Controls.Add(this.salesTaxInfoLabel);
            this.Controls.Add(this.subtotalInfoLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.salesTaxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.hoursOfLaborTextBox);
            this.Controls.Add(this.hoursOfLaborLabel);
            this.Controls.Add(this.partsChargesLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.jobNumberLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bryant’s Auto Repair Shop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label partsChargesLabel;
        private System.Windows.Forms.RichTextBox customerNameTextBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label jobNumberLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.RichTextBox hoursOfLaborTextBox;
        private System.Windows.Forms.Label hoursOfLaborLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label subtotalInfoLabel;
        private System.Windows.Forms.Label salesTaxInfoLabel;
        private System.Windows.Forms.Label totalInfoLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button newCustomerButton;
        private System.Windows.Forms.Button summaryButton;
    }
}


namespace WindowsFormsApplication13
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.orderTextBox = new System.Windows.Forms.TextBox();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.largeRadioButton = new System.Windows.Forms.RadioButton();
            this.extraLargeRadioButton = new System.Windows.Forms.RadioButton();
            this.xxlRadioButton = new System.Windows.Forms.RadioButton();
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.noSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.monogramCheckBox = new System.Windows.Forms.CheckBox();
            this.pocketCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shirtPriceLabel = new System.Windows.Forms.Label();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.shirtPriceTextBox = new System.Windows.Forms.TextBox();
            this.orderTotalTextBox = new System.Windows.Forms.TextBox();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.clearOrderButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderCompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.Button();
            this.orderCompleteButton = new System.Windows.Forms.Button();
            this.summaryOfAllOrdersButton = new System.Windows.Forms.Button();
            this.sizeGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer &Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Order Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Quantity";
            // 
            // customerTextBox
            // 
            this.customerTextBox.Location = new System.Drawing.Point(130, 39);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(104, 20);
            this.customerTextBox.TabIndex = 1;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(130, 119);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(104, 20);
            this.quantityTextBox.TabIndex = 3;
            // 
            // orderTextBox
            // 
            this.orderTextBox.Location = new System.Drawing.Point(130, 77);
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.Size = new System.Drawing.Size(104, 20);
            this.orderTextBox.TabIndex = 2;
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Location = new System.Drawing.Point(16, 19);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(50, 17);
            this.smallRadioButton.TabIndex = 0;
            this.smallRadioButton.TabStop = true;
            this.smallRadioButton.Text = "Sm&all";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(16, 42);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(62, 17);
            this.mediumRadioButton.TabIndex = 1;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "&Medium";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // largeRadioButton
            // 
            this.largeRadioButton.AutoSize = true;
            this.largeRadioButton.Location = new System.Drawing.Point(16, 65);
            this.largeRadioButton.Name = "largeRadioButton";
            this.largeRadioButton.Size = new System.Drawing.Size(52, 17);
            this.largeRadioButton.TabIndex = 2;
            this.largeRadioButton.TabStop = true;
            this.largeRadioButton.Text = "Lar&ge";
            this.largeRadioButton.UseVisualStyleBackColor = true;
            // 
            // extraLargeRadioButton
            // 
            this.extraLargeRadioButton.AutoSize = true;
            this.extraLargeRadioButton.Location = new System.Drawing.Point(16, 88);
            this.extraLargeRadioButton.Name = "extraLargeRadioButton";
            this.extraLargeRadioButton.Size = new System.Drawing.Size(79, 17);
            this.extraLargeRadioButton.TabIndex = 3;
            this.extraLargeRadioButton.TabStop = true;
            this.extraLargeRadioButton.Text = "&Extra Large";
            this.extraLargeRadioButton.UseVisualStyleBackColor = true;
            // 
            // xxlRadioButton
            // 
            this.xxlRadioButton.AutoSize = true;
            this.xxlRadioButton.Location = new System.Drawing.Point(16, 111);
            this.xxlRadioButton.Name = "xxlRadioButton";
            this.xxlRadioButton.Size = new System.Drawing.Size(45, 17);
            this.xxlRadioButton.TabIndex = 4;
            this.xxlRadioButton.TabStop = true;
            this.xxlRadioButton.Text = "XX&L";
            this.xxlRadioButton.UseVisualStyleBackColor = true;
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Controls.Add(this.noSizeRadioButton);
            this.sizeGroupBox.Controls.Add(this.xxlRadioButton);
            this.sizeGroupBox.Controls.Add(this.extraLargeRadioButton);
            this.sizeGroupBox.Controls.Add(this.largeRadioButton);
            this.sizeGroupBox.Controls.Add(this.mediumRadioButton);
            this.sizeGroupBox.Controls.Add(this.smallRadioButton);
            this.sizeGroupBox.Location = new System.Drawing.Point(15, 176);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(122, 151);
            this.sizeGroupBox.TabIndex = 0;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Size";
            // 
            // noSizeRadioButton
            // 
            this.noSizeRadioButton.AutoSize = true;
            this.noSizeRadioButton.Checked = true;
            this.noSizeRadioButton.Location = new System.Drawing.Point(54, 128);
            this.noSizeRadioButton.Name = "noSizeRadioButton";
            this.noSizeRadioButton.Size = new System.Drawing.Size(62, 17);
            this.noSizeRadioButton.TabIndex = 11;
            this.noSizeRadioButton.TabStop = true;
            this.noSizeRadioButton.Text = "invisible";
            this.noSizeRadioButton.UseVisualStyleBackColor = true;
            this.noSizeRadioButton.Visible = false;
            // 
            // monogramCheckBox
            // 
            this.monogramCheckBox.AutoSize = true;
            this.monogramCheckBox.Location = new System.Drawing.Point(16, 23);
            this.monogramCheckBox.Name = "monogramCheckBox";
            this.monogramCheckBox.Size = new System.Drawing.Size(76, 17);
            this.monogramCheckBox.TabIndex = 12;
            this.monogramCheckBox.Text = "Mono&gram";
            this.monogramCheckBox.UseVisualStyleBackColor = true;
            // 
            // pocketCheckBox
            // 
            this.pocketCheckBox.AutoSize = true;
            this.pocketCheckBox.Location = new System.Drawing.Point(16, 47);
            this.pocketCheckBox.Name = "pocketCheckBox";
            this.pocketCheckBox.Size = new System.Drawing.Size(60, 17);
            this.pocketCheckBox.TabIndex = 13;
            this.pocketCheckBox.Text = "Poc&ket";
            this.pocketCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pocketCheckBox);
            this.groupBox1.Controls.Add(this.monogramCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(156, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 96);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // shirtPriceLabel
            // 
            this.shirtPriceLabel.AutoSize = true;
            this.shirtPriceLabel.Location = new System.Drawing.Point(153, 314);
            this.shirtPriceLabel.Name = "shirtPriceLabel";
            this.shirtPriceLabel.Size = new System.Drawing.Size(55, 13);
            this.shirtPriceLabel.TabIndex = 15;
            this.shirtPriceLabel.Text = "Shirt Price";
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.AutoSize = true;
            this.orderTotalLabel.Location = new System.Drawing.Point(153, 347);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(60, 13);
            this.orderTotalLabel.TabIndex = 16;
            this.orderTotalLabel.Text = "Order Total";
            // 
            // shirtPriceTextBox
            // 
            this.shirtPriceTextBox.Location = new System.Drawing.Point(238, 314);
            this.shirtPriceTextBox.Name = "shirtPriceTextBox";
            this.shirtPriceTextBox.ReadOnly = true;
            this.shirtPriceTextBox.Size = new System.Drawing.Size(104, 20);
            this.shirtPriceTextBox.TabIndex = 13;
            this.shirtPriceTextBox.TabStop = false;
            // 
            // orderTotalTextBox
            // 
            this.orderTotalTextBox.Location = new System.Drawing.Point(238, 347);
            this.orderTotalTextBox.Name = "orderTotalTextBox";
            this.orderTotalTextBox.ReadOnly = true;
            this.orderTotalTextBox.Size = new System.Drawing.Size(104, 20);
            this.orderTotalTextBox.TabIndex = 18;
            this.orderTotalTextBox.TabStop = false;
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.Location = new System.Drawing.Point(369, 210);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(118, 21);
            this.addToOrderButton.TabIndex = 6;
            this.addToOrderButton.Text = "&Add to Order";
            this.addToOrderButton.UseVisualStyleBackColor = true;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // clearOrderButton
            // 
            this.clearOrderButton.Location = new System.Drawing.Point(369, 242);
            this.clearOrderButton.Name = "clearOrderButton";
            this.clearOrderButton.Size = new System.Drawing.Size(118, 21);
            this.clearOrderButton.TabIndex = 7;
            this.clearOrderButton.Text = "&Clear Order";
            this.clearOrderButton.UseVisualStyleBackColor = true;
            this.clearOrderButton.Click += new System.EventHandler(this.clearOrderButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(510, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.summaryToolStripMenuItem.Text = "&Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryOfAllOrdersButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToOrderToolStripMenuItem,
            this.clearOrderToolStripMenuItem,
            this.orderCompleteToolStripMenuItem});
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.saleToolStripMenuItem.Text = "&Sale";
            // 
            // addToOrderToolStripMenuItem
            // 
            this.addToOrderToolStripMenuItem.Name = "addToOrderToolStripMenuItem";
            this.addToOrderToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addToOrderToolStripMenuItem.Text = "&Add to Order";
            this.addToOrderToolStripMenuItem.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // clearOrderToolStripMenuItem
            // 
            this.clearOrderToolStripMenuItem.Name = "clearOrderToolStripMenuItem";
            this.clearOrderToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.clearOrderToolStripMenuItem.Text = "&Clear Order";
            this.clearOrderToolStripMenuItem.Click += new System.EventHandler(this.clearOrderButton_Click);
            // 
            // orderCompleteToolStripMenuItem
            // 
            this.orderCompleteToolStripMenuItem.Name = "orderCompleteToolStripMenuItem";
            this.orderCompleteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.orderCompleteToolStripMenuItem.Text = "&Order Complete";
            this.orderCompleteToolStripMenuItem.Click += new System.EventHandler(this.orderCompleteButton_Click);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(369, 338);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(118, 21);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // orderCompleteButton
            // 
            this.orderCompleteButton.Enabled = false;
            this.orderCompleteButton.Location = new System.Drawing.Point(369, 274);
            this.orderCompleteButton.Name = "orderCompleteButton";
            this.orderCompleteButton.Size = new System.Drawing.Size(118, 21);
            this.orderCompleteButton.TabIndex = 22;
            this.orderCompleteButton.Text = "Or&der Complete Button";
            this.orderCompleteButton.UseVisualStyleBackColor = true;
            this.orderCompleteButton.Click += new System.EventHandler(this.orderCompleteButton_Click);
            // 
            // summaryOfAllOrdersButton
            // 
            this.summaryOfAllOrdersButton.Enabled = false;
            this.summaryOfAllOrdersButton.Location = new System.Drawing.Point(369, 306);
            this.summaryOfAllOrdersButton.Name = "summaryOfAllOrdersButton";
            this.summaryOfAllOrdersButton.Size = new System.Drawing.Size(118, 21);
            this.summaryOfAllOrdersButton.TabIndex = 23;
            this.summaryOfAllOrdersButton.Text = "&Summary of All Orders";
            this.summaryOfAllOrdersButton.UseVisualStyleBackColor = true;
            this.summaryOfAllOrdersButton.Click += new System.EventHandler(this.summaryOfAllOrdersButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 434);
            this.Controls.Add(this.summaryOfAllOrdersButton);
            this.Controls.Add(this.orderCompleteButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearOrderButton);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.orderTotalTextBox);
            this.Controls.Add(this.shirtPriceTextBox);
            this.Controls.Add(this.orderTotalLabel);
            this.Controls.Add(this.shirtPriceLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sizeGroupBox);
            this.Controls.Add(this.orderTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.customerTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cool Boards";
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox orderTextBox;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton largeRadioButton;
        private System.Windows.Forms.RadioButton extraLargeRadioButton;
        private System.Windows.Forms.RadioButton xxlRadioButton;
        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.CheckBox monogramCheckBox;
        private System.Windows.Forms.CheckBox pocketCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label shirtPriceLabel;
        private System.Windows.Forms.Label orderTotalLabel;
        private System.Windows.Forms.TextBox shirtPriceTextBox;
        private System.Windows.Forms.TextBox orderTotalTextBox;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.Button clearOrderButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderCompleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton noSizeRadioButton;
        private System.Windows.Forms.Button orderCompleteButton;
        private System.Windows.Forms.Button summaryOfAllOrdersButton;
    }
}


﻿namespace WindowsFormsApplication1
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
            this.partNumberTextBox = new System.Windows.Forms.TextBox();
            this.partNumberLabel = new System.Windows.Forms.Label();
            this.lookUpButton = new System.Windows.Forms.Button();
            this.cccPartNumberLabel = new System.Windows.Forms.Label();
            this.cccPartNumberTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.phoneListBox = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.brandListBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // partNumberTextBox
            // 
            this.partNumberTextBox.Location = new System.Drawing.Point(115, 82);
            this.partNumberTextBox.Name = "partNumberTextBox";
            this.partNumberTextBox.Size = new System.Drawing.Size(91, 20);
            this.partNumberTextBox.TabIndex = 3;
            // 
            // partNumberLabel
            // 
            this.partNumberLabel.AutoSize = true;
            this.partNumberLabel.Location = new System.Drawing.Point(43, 85);
            this.partNumberLabel.Name = "partNumberLabel";
            this.partNumberLabel.Size = new System.Drawing.Size(66, 13);
            this.partNumberLabel.TabIndex = 4;
            this.partNumberLabel.Text = "Part Number";
            // 
            // lookUpButton
            // 
            this.lookUpButton.Location = new System.Drawing.Point(46, 292);
            this.lookUpButton.Name = "lookUpButton";
            this.lookUpButton.Size = new System.Drawing.Size(75, 35);
            this.lookUpButton.TabIndex = 5;
            this.lookUpButton.Text = "Look Up";
            this.lookUpButton.UseVisualStyleBackColor = true;
            this.lookUpButton.Click += new System.EventHandler(this.lookUpButton_Click);
            // 
            // cccPartNumberLabel
            // 
            this.cccPartNumberLabel.AutoSize = true;
            this.cccPartNumberLabel.Location = new System.Drawing.Point(43, 363);
            this.cccPartNumberLabel.Name = "cccPartNumberLabel";
            this.cccPartNumberLabel.Size = new System.Drawing.Size(90, 13);
            this.cccPartNumberLabel.TabIndex = 6;
            this.cccPartNumberLabel.Text = "CCC Part Number";
            // 
            // cccPartNumberTextBox
            // 
            this.cccPartNumberTextBox.Location = new System.Drawing.Point(150, 360);
            this.cccPartNumberTextBox.Name = "cccPartNumberTextBox";
            this.cccPartNumberTextBox.Size = new System.Drawing.Size(91, 20);
            this.cccPartNumberTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // phoneListBox
            // 
            this.phoneListBox.FormattingEnabled = true;
            this.phoneListBox.Location = new System.Drawing.Point(247, 244);
            this.phoneListBox.Name = "phoneListBox";
            this.phoneListBox.Size = new System.Drawing.Size(164, 134);
            this.phoneListBox.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(291, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 10;
            // 
            // brandListBox
            // 
            this.brandListBox.FormattingEnabled = true;
            this.brandListBox.Items.AddRange(new object[] {
            "Brand A",
            "Brand C",
            "Brand X"});
            this.brandListBox.Location = new System.Drawing.Point(46, 158);
            this.brandListBox.Name = "brandListBox";
            this.brandListBox.Size = new System.Drawing.Size(75, 56);
            this.brandListBox.TabIndex = 11;
            this.brandListBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 69);
            this.textBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AcceptButton = this.lookUpButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 431);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.brandListBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.phoneListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cccPartNumberTextBox);
            this.Controls.Add(this.cccPartNumberLabel);
            this.Controls.Add(this.lookUpButton);
            this.Controls.Add(this.partNumberLabel);
            this.Controls.Add(this.partNumberTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox partNumberTextBox;
        private System.Windows.Forms.Label partNumberLabel;
        private System.Windows.Forms.Button lookUpButton;
        private System.Windows.Forms.Label cccPartNumberLabel;
        private System.Windows.Forms.TextBox cccPartNumberTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox phoneListBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox brandListBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}


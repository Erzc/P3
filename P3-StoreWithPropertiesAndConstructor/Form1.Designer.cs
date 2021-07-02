
namespace P3_StoreWithPropertiesAndConstructor
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
            this.orderNumberLabel = new System.Windows.Forms.Label();
            this.orderNumberTextBox = new System.Windows.Forms.TextBox();
            this.numberOfItemsLabel = new System.Windows.Forms.Label();
            this.numberOfItemsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.penRadioButton = new System.Windows.Forms.RadioButton();
            this.mugRadioButton = new System.Windows.Forms.RadioButton();
            this.usbRadioButton = new System.Windows.Forms.RadioButton();
            this.textToEngraveLabel = new System.Windows.Forms.Label();
            this.textToEngraveTextBox = new System.Windows.Forms.TextBox();
            this.logoCheckBox = new System.Windows.Forms.CheckBox();
            this.numberOfColorsLabel = new System.Windows.Forms.Label();
            this.numberOfColorsTextBox = new System.Windows.Forms.TextBox();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderNumberLabel
            // 
            this.orderNumberLabel.AutoSize = true;
            this.orderNumberLabel.Location = new System.Drawing.Point(25, 25);
            this.orderNumberLabel.Name = "orderNumberLabel";
            this.orderNumberLabel.Size = new System.Drawing.Size(73, 13);
            this.orderNumberLabel.TabIndex = 0;
            this.orderNumberLabel.Text = "Order Number";
            // 
            // orderNumberTextBox
            // 
            this.orderNumberTextBox.Location = new System.Drawing.Point(118, 22);
            this.orderNumberTextBox.Name = "orderNumberTextBox";
            this.orderNumberTextBox.Size = new System.Drawing.Size(150, 20);
            this.orderNumberTextBox.TabIndex = 1;
            // 
            // numberOfItemsLabel
            // 
            this.numberOfItemsLabel.AutoSize = true;
            this.numberOfItemsLabel.Location = new System.Drawing.Point(25, 58);
            this.numberOfItemsLabel.Name = "numberOfItemsLabel";
            this.numberOfItemsLabel.Size = new System.Drawing.Size(83, 13);
            this.numberOfItemsLabel.TabIndex = 2;
            this.numberOfItemsLabel.Text = "Number of items";
            // 
            // numberOfItemsTextBox
            // 
            this.numberOfItemsTextBox.Location = new System.Drawing.Point(118, 58);
            this.numberOfItemsTextBox.Name = "numberOfItemsTextBox";
            this.numberOfItemsTextBox.Size = new System.Drawing.Size(150, 20);
            this.numberOfItemsTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.penRadioButton);
            this.groupBox1.Controls.Add(this.mugRadioButton);
            this.groupBox1.Controls.Add(this.usbRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(118, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Type";
            // 
            // penRadioButton
            // 
            this.penRadioButton.AutoSize = true;
            this.penRadioButton.Location = new System.Drawing.Point(7, 66);
            this.penRadioButton.Name = "penRadioButton";
            this.penRadioButton.Size = new System.Drawing.Size(44, 17);
            this.penRadioButton.TabIndex = 2;
            this.penRadioButton.TabStop = true;
            this.penRadioButton.Text = "Pen";
            this.penRadioButton.UseVisualStyleBackColor = true;
            // 
            // mugRadioButton
            // 
            this.mugRadioButton.AutoSize = true;
            this.mugRadioButton.Location = new System.Drawing.Point(7, 43);
            this.mugRadioButton.Name = "mugRadioButton";
            this.mugRadioButton.Size = new System.Drawing.Size(46, 17);
            this.mugRadioButton.TabIndex = 1;
            this.mugRadioButton.TabStop = true;
            this.mugRadioButton.Text = "Mug";
            this.mugRadioButton.UseVisualStyleBackColor = true;
            // 
            // usbRadioButton
            // 
            this.usbRadioButton.AutoSize = true;
            this.usbRadioButton.Location = new System.Drawing.Point(7, 20);
            this.usbRadioButton.Name = "usbRadioButton";
            this.usbRadioButton.Size = new System.Drawing.Size(47, 17);
            this.usbRadioButton.TabIndex = 0;
            this.usbRadioButton.TabStop = true;
            this.usbRadioButton.Text = "USB";
            this.usbRadioButton.UseVisualStyleBackColor = true;
            // 
            // textToEngraveLabel
            // 
            this.textToEngraveLabel.AutoSize = true;
            this.textToEngraveLabel.Location = new System.Drawing.Point(28, 208);
            this.textToEngraveLabel.Name = "textToEngraveLabel";
            this.textToEngraveLabel.Size = new System.Drawing.Size(110, 13);
            this.textToEngraveLabel.TabIndex = 5;
            this.textToEngraveLabel.Text = "Text to engrave/print:";
            // 
            // textToEngraveTextBox
            // 
            this.textToEngraveTextBox.Location = new System.Drawing.Point(31, 224);
            this.textToEngraveTextBox.Multiline = true;
            this.textToEngraveTextBox.Name = "textToEngraveTextBox";
            this.textToEngraveTextBox.Size = new System.Drawing.Size(237, 43);
            this.textToEngraveTextBox.TabIndex = 6;
            // 
            // logoCheckBox
            // 
            this.logoCheckBox.AutoSize = true;
            this.logoCheckBox.Location = new System.Drawing.Point(118, 274);
            this.logoCheckBox.Name = "logoCheckBox";
            this.logoCheckBox.Size = new System.Drawing.Size(56, 17);
            this.logoCheckBox.TabIndex = 7;
            this.logoCheckBox.Text = "Logo?";
            this.logoCheckBox.UseVisualStyleBackColor = true;
            this.logoCheckBox.CheckedChanged += new System.EventHandler(this.logoCheckBox_CheckedChanged);
            // 
            // numberOfColorsLabel
            // 
            this.numberOfColorsLabel.AutoSize = true;
            this.numberOfColorsLabel.Location = new System.Drawing.Point(28, 306);
            this.numberOfColorsLabel.Name = "numberOfColorsLabel";
            this.numberOfColorsLabel.Size = new System.Drawing.Size(87, 13);
            this.numberOfColorsLabel.TabIndex = 8;
            this.numberOfColorsLabel.Text = "Number of colors";
            this.numberOfColorsLabel.Visible = false;
            // 
            // numberOfColorsTextBox
            // 
            this.numberOfColorsTextBox.Location = new System.Drawing.Point(118, 303);
            this.numberOfColorsTextBox.Name = "numberOfColorsTextBox";
            this.numberOfColorsTextBox.Size = new System.Drawing.Size(150, 20);
            this.numberOfColorsTextBox.TabIndex = 9;
            this.numberOfColorsTextBox.Visible = false;
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(31, 379);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ReadOnly = true;
            this.resultsTextBox.Size = new System.Drawing.Size(237, 133);
            this.resultsTextBox.TabIndex = 10;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(65, 346);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(62, 23);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(161, 346);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(62, 23);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 547);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.numberOfColorsTextBox);
            this.Controls.Add(this.numberOfColorsLabel);
            this.Controls.Add(this.logoCheckBox);
            this.Controls.Add(this.textToEngraveTextBox);
            this.Controls.Add(this.textToEngraveLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numberOfItemsTextBox);
            this.Controls.Add(this.numberOfItemsLabel);
            this.Controls.Add(this.orderNumberTextBox);
            this.Controls.Add(this.orderNumberLabel);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderNumberLabel;
        private System.Windows.Forms.TextBox orderNumberTextBox;
        private System.Windows.Forms.Label numberOfItemsLabel;
        private System.Windows.Forms.TextBox numberOfItemsTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton penRadioButton;
        private System.Windows.Forms.RadioButton mugRadioButton;
        private System.Windows.Forms.RadioButton usbRadioButton;
        private System.Windows.Forms.Label textToEngraveLabel;
        private System.Windows.Forms.TextBox textToEngraveTextBox;
        private System.Windows.Forms.CheckBox logoCheckBox;
        private System.Windows.Forms.Label numberOfColorsLabel;
        private System.Windows.Forms.TextBox numberOfColorsTextBox;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
    }
}


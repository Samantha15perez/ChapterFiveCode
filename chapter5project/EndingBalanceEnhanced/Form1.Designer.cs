namespace EndingBalanceEnhanced
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
            this.detailListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.endingBalanceLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.monthsTextBox = new System.Windows.Forms.TextBox();
            this.startingBalTextBox = new System.Windows.Forms.TextBox();
            this.monthsPromptLabel = new System.Windows.Forms.Label();
            this.startingBalancePromptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // detailListBox
            // 
            this.detailListBox.FormattingEnabled = true;
            this.detailListBox.Location = new System.Drawing.Point(6, 70);
            this.detailListBox.Name = "detailListBox";
            this.detailListBox.Size = new System.Drawing.Size(246, 134);
            this.detailListBox.TabIndex = 30;
            this.detailListBox.SelectedIndexChanged += new System.EventHandler(this.detailListBox_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(178, 258);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 29;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(97, 258);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 28;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(16, 258);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 27;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // endingBalanceLabel
            // 
            this.endingBalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endingBalanceLabel.Location = new System.Drawing.Point(127, 226);
            this.endingBalanceLabel.Name = "endingBalanceLabel";
            this.endingBalanceLabel.Size = new System.Drawing.Size(100, 23);
            this.endingBalanceLabel.TabIndex = 26;
            this.endingBalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.endingBalanceLabel.Click += new System.EventHandler(this.endingBalanceLabel_Click);
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(36, 231);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(85, 13);
            this.outputDescriptionLabel.TabIndex = 25;
            this.outputDescriptionLabel.Text = "Ending Balance:";
            this.outputDescriptionLabel.Click += new System.EventHandler(this.outputDescriptionLabel_Click);
            // 
            // monthsTextBox
            // 
            this.monthsTextBox.Location = new System.Drawing.Point(116, 32);
            this.monthsTextBox.Name = "monthsTextBox";
            this.monthsTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthsTextBox.TabIndex = 24;
            this.monthsTextBox.TextChanged += new System.EventHandler(this.monthsTextBox_TextChanged);
            // 
            // startingBalTextBox
            // 
            this.startingBalTextBox.Location = new System.Drawing.Point(116, 5);
            this.startingBalTextBox.Name = "startingBalTextBox";
            this.startingBalTextBox.Size = new System.Drawing.Size(100, 20);
            this.startingBalTextBox.TabIndex = 23;
            this.startingBalTextBox.TextChanged += new System.EventHandler(this.startingBalTextBox_TextChanged);
            // 
            // monthsPromptLabel
            // 
            this.monthsPromptLabel.AutoSize = true;
            this.monthsPromptLabel.Location = new System.Drawing.Point(13, 35);
            this.monthsPromptLabel.Name = "monthsPromptLabel";
            this.monthsPromptLabel.Size = new System.Drawing.Size(97, 13);
            this.monthsPromptLabel.TabIndex = 22;
            this.monthsPromptLabel.Text = "Number of Months:";
            this.monthsPromptLabel.Click += new System.EventHandler(this.monthsPromptLabel_Click);
            // 
            // startingBalancePromptLabel
            // 
            this.startingBalancePromptLabel.AutoSize = true;
            this.startingBalancePromptLabel.Location = new System.Drawing.Point(22, 9);
            this.startingBalancePromptLabel.Name = "startingBalancePromptLabel";
            this.startingBalancePromptLabel.Size = new System.Drawing.Size(88, 13);
            this.startingBalancePromptLabel.TabIndex = 21;
            this.startingBalancePromptLabel.Text = "Starting Balance:";
            this.startingBalancePromptLabel.Click += new System.EventHandler(this.startingBalancePromptLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 291);
            this.Controls.Add(this.detailListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.endingBalanceLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.monthsTextBox);
            this.Controls.Add(this.startingBalTextBox);
            this.Controls.Add(this.monthsPromptLabel);
            this.Controls.Add(this.startingBalancePromptLabel);
            this.Name = "Form1";
            this.Text = "Ending Balance Enhanced";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox detailListBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label endingBalanceLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.TextBox monthsTextBox;
        private System.Windows.Forms.TextBox startingBalTextBox;
        private System.Windows.Forms.Label monthsPromptLabel;
        private System.Windows.Forms.Label startingBalancePromptLabel;
    }
}



namespace DLExam
{
	partial class Main_Form
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
			this.gradeButton = new System.Windows.Forms.Button();
			this.correctAnswersLabel = new System.Windows.Forms.Label();
			this.incorrectAnswersLabel = new System.Windows.Forms.Label();
			this.incorrectQuestionNumbersLabel = new System.Windows.Forms.Label();
			this.gradeBox = new System.Windows.Forms.TextBox();
			this.gradeLabel = new System.Windows.Forms.Label();
			this.responseBox = new System.Windows.Forms.TextBox();
			this.responseLabel = new System.Windows.Forms.Label();
			this.correctAnswersTextBox = new System.Windows.Forms.TextBox();
			this.incorrectAnswersTextBox = new System.Windows.Forms.TextBox();
			this.incorrectQuestionListBox = new System.Windows.Forms.ListBox();
			this.closeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// gradeButton
			// 
			this.gradeButton.Location = new System.Drawing.Point(54, 46);
			this.gradeButton.Name = "gradeButton";
			this.gradeButton.Size = new System.Drawing.Size(75, 23);
			this.gradeButton.TabIndex = 0;
			this.gradeButton.Text = "Grade";
			this.gradeButton.UseVisualStyleBackColor = true;
			this.gradeButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// correctAnswersLabel
			// 
			this.correctAnswersLabel.AutoSize = true;
			this.correctAnswersLabel.Location = new System.Drawing.Point(25, 112);
			this.correctAnswersLabel.Name = "correctAnswersLabel";
			this.correctAnswersLabel.Size = new System.Drawing.Size(61, 13);
			this.correctAnswersLabel.TabIndex = 3;
			this.correctAnswersLabel.Text = "No. Correct";
			// 
			// incorrectAnswersLabel
			// 
			this.incorrectAnswersLabel.AutoSize = true;
			this.incorrectAnswersLabel.Location = new System.Drawing.Point(103, 112);
			this.incorrectAnswersLabel.Name = "incorrectAnswersLabel";
			this.incorrectAnswersLabel.Size = new System.Drawing.Size(69, 13);
			this.incorrectAnswersLabel.TabIndex = 4;
			this.incorrectAnswersLabel.Text = "No. Incorrect";
			// 
			// incorrectQuestionNumbersLabel
			// 
			this.incorrectQuestionNumbersLabel.AutoSize = true;
			this.incorrectQuestionNumbersLabel.Location = new System.Drawing.Point(188, 112);
			this.incorrectQuestionNumbersLabel.Name = "incorrectQuestionNumbersLabel";
			this.incorrectQuestionNumbersLabel.Size = new System.Drawing.Size(139, 13);
			this.incorrectQuestionNumbersLabel.TabIndex = 6;
			this.incorrectQuestionNumbersLabel.Text = "Incorrect Question Numbers";
			// 
			// gradeBox
			// 
			this.gradeBox.Location = new System.Drawing.Point(219, 46);
			this.gradeBox.Name = "gradeBox";
			this.gradeBox.Size = new System.Drawing.Size(42, 20);
			this.gradeBox.TabIndex = 7;
			// 
			// gradeLabel
			// 
			this.gradeLabel.AutoSize = true;
			this.gradeLabel.Location = new System.Drawing.Point(178, 49);
			this.gradeLabel.Name = "gradeLabel";
			this.gradeLabel.Size = new System.Drawing.Size(39, 13);
			this.gradeLabel.TabIndex = 8;
			this.gradeLabel.Text = "Grade:";
			// 
			// responseBox
			// 
			this.responseBox.Location = new System.Drawing.Point(219, 72);
			this.responseBox.Name = "responseBox";
			this.responseBox.Size = new System.Drawing.Size(70, 20);
			this.responseBox.TabIndex = 9;
			// 
			// responseLabel
			// 
			this.responseLabel.AutoSize = true;
			this.responseLabel.Location = new System.Drawing.Point(188, 75);
			this.responseLabel.Name = "responseLabel";
			this.responseLabel.Size = new System.Drawing.Size(29, 13);
			this.responseLabel.TabIndex = 10;
			this.responseLabel.Text = "You:";
			// 
			// correctAnswersTextBox
			// 
			this.correctAnswersTextBox.Location = new System.Drawing.Point(28, 128);
			this.correctAnswersTextBox.Name = "correctAnswersTextBox";
			this.correctAnswersTextBox.Size = new System.Drawing.Size(58, 20);
			this.correctAnswersTextBox.TabIndex = 11;
			// 
			// incorrectAnswersTextBox
			// 
			this.incorrectAnswersTextBox.Location = new System.Drawing.Point(106, 128);
			this.incorrectAnswersTextBox.Name = "incorrectAnswersTextBox";
			this.incorrectAnswersTextBox.Size = new System.Drawing.Size(66, 20);
			this.incorrectAnswersTextBox.TabIndex = 12;
			// 
			// incorrectQuestionListBox
			// 
			this.incorrectQuestionListBox.FormattingEnabled = true;
			this.incorrectQuestionListBox.Location = new System.Drawing.Point(191, 128);
			this.incorrectQuestionListBox.Name = "incorrectQuestionListBox";
			this.incorrectQuestionListBox.Size = new System.Drawing.Size(136, 290);
			this.incorrectQuestionListBox.TabIndex = 13;
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(142, 447);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 14;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// Main_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 491);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.incorrectQuestionListBox);
			this.Controls.Add(this.incorrectAnswersTextBox);
			this.Controls.Add(this.correctAnswersTextBox);
			this.Controls.Add(this.responseLabel);
			this.Controls.Add(this.responseBox);
			this.Controls.Add(this.gradeLabel);
			this.Controls.Add(this.gradeBox);
			this.Controls.Add(this.incorrectQuestionNumbersLabel);
			this.Controls.Add(this.incorrectAnswersLabel);
			this.Controls.Add(this.correctAnswersLabel);
			this.Controls.Add(this.gradeButton);
			this.Name = "Main_Form";
			this.Text = "Driver\'s License Exam";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button gradeButton;
		private System.Windows.Forms.Label correctAnswersLabel;
		private System.Windows.Forms.Label incorrectAnswersLabel;
		private System.Windows.Forms.Label incorrectQuestionNumbersLabel;
		private System.Windows.Forms.TextBox gradeBox;
		private System.Windows.Forms.Label gradeLabel;
		private System.Windows.Forms.TextBox responseBox;
		private System.Windows.Forms.Label responseLabel;
		private System.Windows.Forms.TextBox correctAnswersTextBox;
		private System.Windows.Forms.TextBox incorrectAnswersTextBox;
		private System.Windows.Forms.ListBox incorrectQuestionListBox;
		private System.Windows.Forms.Button closeButton;
	}
}


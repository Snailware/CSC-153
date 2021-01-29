namespace TotalSales
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
			this.readButton = new System.Windows.Forms.Button();
			this.contentsListBox = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.totalTextBox = new System.Windows.Forms.TextBox();
			this.totalLabel = new System.Windows.Forms.Label();
			this.closeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// readButton
			// 
			this.readButton.Location = new System.Drawing.Point(41, 12);
			this.readButton.Name = "readButton";
			this.readButton.Size = new System.Drawing.Size(75, 23);
			this.readButton.TabIndex = 0;
			this.readButton.Text = "Read";
			this.readButton.UseVisualStyleBackColor = true;
			this.readButton.Click += new System.EventHandler(this.ReadButton_Click);
			// 
			// contentsListBox
			// 
			this.contentsListBox.FormattingEnabled = true;
			this.contentsListBox.Location = new System.Drawing.Point(21, 68);
			this.contentsListBox.Name = "contentsListBox";
			this.contentsListBox.Size = new System.Drawing.Size(120, 95);
			this.contentsListBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(53, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Contents";
			// 
			// totalTextBox
			// 
			this.totalTextBox.Location = new System.Drawing.Point(30, 207);
			this.totalTextBox.Name = "totalTextBox";
			this.totalTextBox.Size = new System.Drawing.Size(100, 20);
			this.totalTextBox.TabIndex = 3;
			this.totalTextBox.Text = "00.00";
			// 
			// totalLabel
			// 
			this.totalLabel.AutoSize = true;
			this.totalLabel.Location = new System.Drawing.Point(62, 191);
			this.totalLabel.Name = "totalLabel";
			this.totalLabel.Size = new System.Drawing.Size(31, 13);
			this.totalLabel.TabIndex = 4;
			this.totalLabel.Text = "Total";
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(41, 247);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 5;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(161, 282);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.totalLabel);
			this.Controls.Add(this.totalTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.contentsListBox);
			this.Controls.Add(this.readButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button readButton;
		private System.Windows.Forms.ListBox contentsListBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox totalTextBox;
		private System.Windows.Forms.Label totalLabel;
		private System.Windows.Forms.Button closeButton;
	}
}


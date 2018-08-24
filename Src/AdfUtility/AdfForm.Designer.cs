namespace AdfUtility
{
	public partial class AdfForm
	{
		#region Fields

		private System.Windows.Forms.TextBox AdfTextBox;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.Button testButton;

		#endregion

		#region Methods

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

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.AdfTextBox = new System.Windows.Forms.TextBox();
			this.testButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// AdfTextBox
			// 
			this.AdfTextBox.Location = new System.Drawing.Point(12, 12);
			this.AdfTextBox.Multiline = true;
			this.AdfTextBox.Name = "AdfTextBox";
			this.AdfTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.AdfTextBox.Size = new System.Drawing.Size(879, 626);
			this.AdfTextBox.TabIndex = 0;
			// 
			// testButton
			// 
			this.testButton.Location = new System.Drawing.Point(734, 675);
			this.testButton.Name = "testButton";
			this.testButton.Size = new System.Drawing.Size(157, 47);
			this.testButton.TabIndex = 1;
			this.testButton.Text = "Set ADF";
			this.testButton.UseVisualStyleBackColor = true;
			this.testButton.Click += new System.EventHandler(this.testButton_Click);
			// 
			// AdfForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(903, 752);
			this.Controls.Add(this.testButton);
			this.Controls.Add(this.AdfTextBox);
			this.Name = "AdfForm";
			this.Text = "AdfForm";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion
	}
}

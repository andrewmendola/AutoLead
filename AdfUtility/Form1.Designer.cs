using AdfLibrary;
using AdfLibrary.Lead;
using AdfLibrary.Vehicle;
using System.Collections.Generic;

namespace AdfUtility
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(40, 24);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(764, 668);
			this.textBox1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(891, 757);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

			var builder = new AdfBuilder(new List<AdfLead>
			{
				new AdfLead(
					new Customer(),
					new Prospect
					{
						LeadId = "123456",
						LeadSource = "",
						LeadType = "Contact",
						RequestDate = System.DateTime.Now,
						Status = AdfLibrary.Prospect.AdfProspectStatus.New
					},
					new Provider(),
					new List<AdfVehicle>
					{
						new AdfVehicle()
					},
					new Vendor())
			});

			textBox1.Text = builder.AdfXDocument.ToString();
		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
	}
}


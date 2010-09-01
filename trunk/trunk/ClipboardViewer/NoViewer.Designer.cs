namespace ClipboardViewer
{
	partial class NoViewer
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Maroon;
			this.label1.Location = new System.Drawing.Point(53, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(204, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "( no viewer is avalible for this data format )";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(116, 73);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(78, 13);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "( roll your own )";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// NoViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label1);
			this.Name = "NoViewer";
			this.Size = new System.Drawing.Size(310, 130);
			this.Load += new System.EventHandler(this.NoViewer_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}

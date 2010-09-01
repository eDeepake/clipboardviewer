namespace ClipboardViewer
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.pnlContent = new System.Windows.Forms.Panel();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.splitMain = new System.Windows.Forms.SplitContainer();
			this.lstFormats = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbViewers = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.chkAlwaysOnTop = new System.Windows.Forms.CheckBox();
			this.lnkAbout = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
			this.splitMain.Panel1.SuspendLayout();
			this.splitMain.Panel2.SuspendLayout();
			this.splitMain.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlContent
			// 
			this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContent.Location = new System.Drawing.Point(0, 21);
			this.pnlContent.Name = "pnlContent";
			this.pnlContent.Size = new System.Drawing.Size(324, 285);
			this.pnlContent.TabIndex = 1;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(6, 6);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 306);
			this.splitter1.TabIndex = 3;
			this.splitter1.TabStop = false;
			// 
			// splitMain
			// 
			this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitMain.Location = new System.Drawing.Point(9, 6);
			this.splitMain.Name = "splitMain";
			// 
			// splitMain.Panel1
			// 
			this.splitMain.Panel1.Controls.Add(this.lstFormats);
			this.splitMain.Panel1.Controls.Add(this.label1);
			// 
			// splitMain.Panel2
			// 
			this.splitMain.Panel2.Controls.Add(this.pnlContent);
			this.splitMain.Panel2.Controls.Add(this.cmbViewers);
			this.splitMain.Size = new System.Drawing.Size(442, 306);
			this.splitMain.SplitterDistance = 114;
			this.splitMain.TabIndex = 6;
			// 
			// lstFormats
			// 
			this.lstFormats.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstFormats.FormattingEnabled = true;
			this.lstFormats.Location = new System.Drawing.Point(0, 21);
			this.lstFormats.Name = "lstFormats";
			this.lstFormats.Size = new System.Drawing.Size(114, 285);
			this.lstFormats.TabIndex = 3;
			this.lstFormats.SelectedIndexChanged += new System.EventHandler(this.lstFormats_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 21);
			this.label1.TabIndex = 4;
			this.label1.Text = "&Data Formats";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmbViewers
			// 
			this.cmbViewers.Dock = System.Windows.Forms.DockStyle.Top;
			this.cmbViewers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbViewers.FormattingEnabled = true;
			this.cmbViewers.Location = new System.Drawing.Point(0, 0);
			this.cmbViewers.Name = "cmbViewers";
			this.cmbViewers.Size = new System.Drawing.Size(324, 21);
			this.cmbViewers.TabIndex = 0;
			this.cmbViewers.SelectedIndexChanged += new System.EventHandler(this.cmbViewers_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.chkAlwaysOnTop);
			this.panel1.Controls.Add(this.lnkAbout);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(6, 312);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(445, 17);
			this.panel1.TabIndex = 7;
			// 
			// chkAlwaysOnTop
			// 
			this.chkAlwaysOnTop.AutoSize = true;
			this.chkAlwaysOnTop.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.chkAlwaysOnTop.Location = new System.Drawing.Point(0, 0);
			this.chkAlwaysOnTop.Name = "chkAlwaysOnTop";
			this.chkAlwaysOnTop.Size = new System.Drawing.Size(410, 17);
			this.chkAlwaysOnTop.TabIndex = 6;
			this.chkAlwaysOnTop.Text = "Always On Top";
			this.chkAlwaysOnTop.UseVisualStyleBackColor = true;
			this.chkAlwaysOnTop.CheckedChanged += new System.EventHandler(this.chkAlwaysOnTop_CheckedChanged);
			// 
			// lnkAbout
			// 
			this.lnkAbout.AutoSize = true;
			this.lnkAbout.Dock = System.Windows.Forms.DockStyle.Right;
			this.lnkAbout.Location = new System.Drawing.Point(410, 0);
			this.lnkAbout.Name = "lnkAbout";
			this.lnkAbout.Size = new System.Drawing.Size(35, 13);
			this.lnkAbout.TabIndex = 0;
			this.lnkAbout.TabStop = true;
			this.lnkAbout.Text = "About";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(457, 335);
			this.Controls.Add(this.splitMain);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMain";
			this.Padding = new System.Windows.Forms.Padding(6);
			this.Text = "Clipboard Viewer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.splitMain.Panel1.ResumeLayout(false);
			this.splitMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
			this.splitMain.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlContent;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.SplitContainer splitMain;
		private System.Windows.Forms.ListBox lstFormats;
		private System.Windows.Forms.ComboBox cmbViewers;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox chkAlwaysOnTop;
		private System.Windows.Forms.LinkLabel lnkAbout;
		private System.Windows.Forms.Label label1;
	}
}


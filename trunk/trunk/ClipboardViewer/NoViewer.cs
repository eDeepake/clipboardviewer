using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using ClipboardViewer.Properties;

namespace ClipboardViewer
{
	internal partial class NoViewer : UserControl
	{
		public NoViewer()
		{
			InitializeComponent();
		}

		private void NoViewer_Load(object sender, EventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Resources.RollViewUrl);
		}
	}
}

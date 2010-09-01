//
//  Clipboard Viewer
//  Created by Noah Coad on 8/29/2010 with the company of Radoslav Ivanov
//
//  Enables the user to view the contents of the clipboard
//  See the project's home page at http://clipboardviewer.codeplex.com/
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClipboardViewer.Properties;
using System.Diagnostics;
using System.IO;

namespace ClipboardViewer
{
	internal partial class frmMain : Form
	{
		#region Local Variables
		private PluginManager plugins = new PluginManager();
		private Settings settings = Settings.Default;
		private ClipboardChangeNotifier clipChange = null;
		#endregion

		#region Constructor
		public frmMain()
		{
			InitializeComponent();
		}
		#endregion

		#region Event Handlers
		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Save settings across sessions
			settings.AlwaysOnTop = chkAlwaysOnTop.Checked;
			settings.SplitterDistance = splitMain.SplitterDistance;
			settings.PluginDirectories = settings.PluginDirectories;
			settings.Save();

			// Uninstall the clipboard hook
			clipChange.Uninstall();
		}
		private void frmMain_Load(object sender, EventArgs e)
		{
			// Reload user settings
			settings.Reload();
			chkAlwaysOnTop.Checked = settings.AlwaysOnTop;
			if (settings.SplitterDistance > -1) splitMain.SplitterDistance = settings.SplitterDistance;

			// Give focus to the list of formats by default
			lstFormats.Focus();

			// Load the list of plugins
			string[] dirs = settings.PluginDirectories.Split('|').Select(a => a.Replace("=", Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath))).ToArray();
			plugins.LoadPlugins(dirs);

			// Create, activate, and listen to the clipboard change notifications
			clipChange = new ClipboardChangeNotifier();
			clipChange.ClipboardChanged += new EventHandler(clipChange_ClipboardChanged);
			clipChange.AssignHandle(this.Handle);
			clipChange.Install();
		}

		private void clipChange_ClipboardChanged(object sender, EventArgs e)
		{
			// Clipboard contents changed, show the new list of data formats
			RefreshClipboardFormats();
		}

		private void chkAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
		{
			// Make the main form always stay on top of other windows if checked
			this.TopMost = chkAlwaysOnTop.Checked;
		}
		private void lnkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Resources.AboutUrl);

		}
		private void lstFormats_SelectedIndexChanged(object sender, EventArgs e)
		{
			ShowSelectedDataFormatViewer();
		}
		private void cmbViewers_SelectedIndexChanged(object sender, EventArgs e)
		{
			ShowSelectedViewer();
		}
		#endregion

		#region Local Methods
		private void RefreshClipboardFormats()
		{
			// Retrieve the list of avalible data formats in the clipboard
			string[] formats = Clipboard.GetDataObject().GetFormats();

			// Save the user's last selected format
			string LastSelectedFormat = lstFormats.SelectedItem as string;

			// Clear and repopulate the list of avalible data formats
			lstFormats.Items.Clear();
			lstFormats.Items.AddRange(formats);

			// Re-select the user's last chosen data format if it still exists
			if (LastSelectedFormat != null && lstFormats.Items.Contains(LastSelectedFormat))
				lstFormats.SelectedItem = LastSelectedFormat;

			// If there isn't any selected, choose the first
			if (lstFormats.SelectedIndex == -1 && lstFormats.Items.Count > 0) lstFormats.SelectedIndex = 0;

			// Show the viewer for the currently selected format
			ShowSelectedDataFormatViewer();
		}
		private void ShowSelectedDataFormatViewer()
		{
			// A new format was selected from the list of formats, show its data viewer
			ShowDataViewers(lstFormats.SelectedItem as string);
		}
		private void ShowDataViewers(string Format)
		{
			// Clear the current content viewer
			pnlContent.Controls.Clear();
			cmbViewers.Visible = false;

			// If there isn't a data format to view, just abandon
			if (Format == null) return;

			// Find a viewer for this type of data
			List<ViewerInfo> viewers = plugins.ProcessContentType(Format, a => Clipboard.GetData(a));

			// Add the viewers to the selection of viewers
			cmbViewers.Items.Clear();
			cmbViewers.Items.AddRange(viewers.ToArray());
			if (cmbViewers.Items.Count > 0) cmbViewers.SelectedIndex = 0;
			cmbViewers.Visible = cmbViewers.Items.Count > 1;

			ShowSelectedViewer();
		}
		private void ShowSelectedViewer()
		{
			ShowViewer(cmbViewers.SelectedItem as ViewerInfo);
		}
		private void ShowViewer(ViewerInfo viewer)
		{
			// Either use a control provided by the viewer, or the default
			Control c = null;
			if (viewer == null || viewer.Control == null) c = new NoViewer();
			else c = viewer.Control;

			// If a view was found, show the control
			pnlContent.Controls.Clear();
			pnlContent.Controls.Add(c); c.Dock = DockStyle.Fill;
		}
		#endregion
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClipboardViewer.TestPlugins
{
	public class WinExplorerFiles : ClipboardViewer.IContentViewer
	{
		public ViewerInfo ProcessClipboardDataType(string DataFormat, Func<string, object> GetData)
		{
			if (DataFormat == "FileDrop")
			{
				string[] files = GetData(DataFormat) as string[];
				ListBox list = new ListBox();
				list.Items.AddRange(files);
				return new ViewerInfo { Name = "Windows Explorer Files", Control = list };
			}

			return null;
		}
	}
}

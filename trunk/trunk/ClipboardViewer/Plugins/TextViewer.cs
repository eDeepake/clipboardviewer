using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClipboardViewer
{
	internal class TextViewer : IContentViewer
	{
		public ViewerInfo ProcessClipboardDataType(string DataFormat, Func<string, object> GetData)
		{
			if ((new string[] { DataFormats.Text, DataFormats.UnicodeText, DataFormats.StringFormat, DataFormats.OemText, DataFormats.Html, DataFormats.Rtf }).Contains(DataFormat))
				return new ViewerInfo { Name = "Plain Text", Control = new TextBox { Text = GetData(DataFormat).ToString(), Multiline = true, ScrollBars = ScrollBars.Both, WordWrap = false } };

			return null;
		}
	}
}

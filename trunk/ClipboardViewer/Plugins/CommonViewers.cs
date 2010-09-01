using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClipboardViewer
{
	internal class CommonViewers : IContentViewer
	{
		public ViewerInfo ProcessClipboardDataType(string DataFormat, Func<string, object> GetData)
		{
			if (DataFormat == DataFormats.Rtf)
				return new ViewerInfo { Name = "Rich Text", Control = new RichTextBox { Rtf = GetData(DataFormat) as string } };

			if (DataFormat == DataFormats.Html)
				return new ViewerInfo { Name = "IE HTML", Control = new WebBrowser { DocumentText = GetData(DataFormat) as string } };

			return null;
		}
	}
}

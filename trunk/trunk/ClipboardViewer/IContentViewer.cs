using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClipboardViewer
{
	public interface IContentViewer
	{
		ViewerInfo ProcessClipboardDataType(string DataFormat, Func<string, object> GetData);
	}
}

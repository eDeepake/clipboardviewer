using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClipboardViewer
{
	public class ViewerInfo
	{
		public string Name { get; set; }
		public Control Control { get; set; }
		
		public override string ToString()
		{ return Name; }
	}
}

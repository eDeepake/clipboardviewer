using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ClipboardViewer
{
	internal class ImageViewer : IContentViewer
	{
		public ViewerInfo ProcessClipboardDataType(string DataFormat, Func<string, object> GetData)
		{
			if (DataFormat == DataFormats.Bitmap || DataFormat == typeof(Bitmap).ToString())
				return new ViewerInfo { Name = "Bitmap", Control = new PictureBox { SizeMode = PictureBoxSizeMode.Zoom, Image = (Bitmap) GetData(DataFormat) } };

			return null;
		}
	}
}

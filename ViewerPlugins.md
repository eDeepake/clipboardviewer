Clipboard Viewer uses a simple plugin model to expand the types of clipboard data format content it is able to display to the user.  For example, a simple data format viewer would be able to display an image (already included in the project, BitmapViewer.cs).  All of the viewers currently in the project are using the plugin model and you can easily add more.

To create a new data format viewer:
  1. Create a new class library (.dll) project
  1. Add references to the main ClipboardViewer.exe assembly and System.Windows.Forms
  1. Create a class that implements the interface ClipboardViewer.IContentViewer
    1. Check the DataFormat to see if it's a format your viewer will support
    1. Call GetData(DataFormat) to retrieve the data from the clipboard
    1. Create a Control (eg: TextBox, PictureBox, ListBox, etc) to display the content
    1. Return that control
  1. Either copy your .dll to the directory with ClipboardViewer.exe OR add a path to the ClipboardViewer.exe config file to scan your output directory for plugins
  1. Build the project and deploy the .dll to the same directory as ClipboardViewer.exe
  1. run the app!

For an example of this, see the project: <need to provide an example, for now just see the main source code listing>

**If you make a plugin, please share it!**  Just shoot me an email, noah@coad.net, or make a request to join the project and add it in.  thanks
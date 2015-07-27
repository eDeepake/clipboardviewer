Allows the user to view the contents of the clipboard in various formats.

**Install the program now: [setup.msi](http://clipboardviewer.googlecode.com/svn/trunk/trunk/Setup/Debug/Setup.msi)**

## Overview ##
The clipboard is capable of storing various data formats to represent what was copied.  When you copy some text from Microsoft Word, it stores 13 different representations, including RTF, HTML, plain text, etc.  Clipboard Viewer is used for viewing these formats and how they're stored in the clipboard.  It supports an plugin model for adding additional data format viewers.

## Features ##
**Data Format Viewer Plugin Model**

Since any arbitrary data format can be stored in the clipboard, it is necessary to be able to easily add a new way to visualize a particular data format.  Clipboard Viewer supports viewing more formats than what is just ships with using an a plugin model where you can simple create a new content viewer for a data format.  In fact all the viewers built in are just plugins using the same interfaces.  You can add new viewers for data formats already supported as well, such as an improved image viewer that would let you save the image. To roll your own viewer, see [ViewerPlugins](ViewerPlugins.md)

**Built-in Data Format Viewers**
  * Text - capable of viewing plain text, System.Text, Unicode text, HTML source code, RTF source, etc
  * HTML - Uses the Internet Explorer WebBrowser control to render the HTML in the clipboard
  * RTF - Uses the .NET RichTextBox control to view formatted text
  * Bitmap - A simple image view


## About the Windows Clipboard ##
The Windows clipboard is capable of holding various formats or representations of a data.  For example, when you copy a paragraph from Microsoft Word, the clipboard actually contains several different data formats to represent what was copied to the clipboard, including these formats:
  * Rich Text Format - RTF formatted data that can be pasted into most other programs supporting rich text
  * HTML Format - An HTML encoding of the data
  * Text - Plain text without any formatting
  * 9 other formats - For various purposes such as the native MS Word format and more

## Screen Shots ##
Code copied from Microsoft Visual Studio

![http://clipboardviewer.googlecode.com/svn/trunk/images/ClipboardViewer-Sample-VSCode.png](http://clipboardviewer.googlecode.com/svn/trunk/images/ClipboardViewer-Sample-VSCode.png)




An image copied from Paint.NET

![http://clipboardviewer.googlecode.com/svn/trunk/images/ClipboardViewer-Sample-Image.png](http://clipboardviewer.googlecode.com/svn/trunk/images/ClipboardViewer-Sample-Image.png)
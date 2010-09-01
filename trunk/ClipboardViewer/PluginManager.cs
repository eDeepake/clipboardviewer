using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClipboardViewer.Properties;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ClipboardViewer
{
	internal class PluginManager
	{
		List<IContentViewer> plugins = null;

		internal PluginManager()
		{
		}

		private List<IContentViewer> GetPlugins(string[] PluginDirectories)
		{
			Settings s = new Settings(); s.Reload();

			List<IContentViewer> plugins = new List<IContentViewer>();
			List<Assembly> ass = new List<Assembly>() { Assembly.GetExecutingAssembly() };

			// Add addtional types from assemblies in plugin directories that adhear to the plugin interface
			if (PluginDirectories != null)
				foreach (string dir in PluginDirectories)
					if (Directory.Exists(dir))
						foreach (string file in Directory.GetFiles(dir, "*.dll"))
							ass.Add(Assembly.LoadFile(file));

			// Find all the types that implement the plugin interface and load those up
			foreach (Assembly a in ass)
				foreach (Type t in a.GetTypes())
					if (!t.IsAbstract && Array.IndexOf(t.GetInterfaces(), typeof(IContentViewer)) > -1)
						plugins.Add(a.CreateInstance(t.FullName) as IContentViewer);

			// Return the list of supported plugins
			return plugins;
		}

		internal void LoadPlugins(string[] PluginDirectories = null)
		{
			plugins = GetPlugins(PluginDirectories);
		}

		internal List<ViewerInfo> ProcessContentType(string DataFormat, Func<string, object> GetData)
		{
			List<ViewerInfo> viewers = new List<ViewerInfo>();

			// Collect the list of plugins
			if (plugins == null) plugins = GetPlugins(null);

			// Return a list of the supported viewers
			foreach (IContentViewer icv in plugins)
			{
				ViewerInfo vi = icv.ProcessClipboardDataType(DataFormat, GetData);
				if (vi != null) viewers.Add(vi);
			}
			
			return viewers;
		}
	}
}

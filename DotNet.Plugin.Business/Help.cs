using System;

namespace DotNet.Plugin.Business
{
    public class Help : IPlugin
    {
        public string Name
        {
            get
            {
                return "help";
            }
        }

        public string Explanation
        {
            get
            {
                return "This plugin shows all loaded plugins and their explanations";
            }
        }

		public string Category
		{
			get
			{
				return "Utility";
			}
		}

        public void Go(string parameters)
        {
			string currentCategory = "";
            foreach(IPlugin plugin in PluginLoader.Plugins)
            {
				CheckThenWriteCategoryIfNew(ref currentCategory, plugin.Category);
                Console.WriteLine("{0}: {1}", plugin.Name, plugin.Explanation);
            }
            Console.WriteLine("{0}: {1}", "exit", "This command exits the program");
        }

		private void CheckThenWriteCategoryIfNew(ref string currentCategory, string newCategory)
		{
			if (newCategory != currentCategory)
			{
				currentCategory = newCategory;
				WriteCategory(currentCategory);
			}
		}

		private void WriteCategory(string category)
		{
			Console.WriteLine("\n" + category);
			foreach (char c in category)
			{
				Console.Write('-');
			}
			Console.WriteLine("");
		}
    }
}

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

        public void Go(string parameters)
        {
            foreach(IPlugin plugin in PluginLoader.Plugins)
            {
                Console.WriteLine("{0}: {1}", plugin.Name, plugin.Explanation);
            }
            Console.WriteLine("{0}: {1}", "exit", "This command exits the program");
        }
    }
}

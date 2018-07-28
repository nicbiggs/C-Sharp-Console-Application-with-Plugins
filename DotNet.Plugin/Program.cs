using System;
using System.Linq;
using DotNet.Plugin.Business;

namespace DotNet.Plugin
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Starting plugin app...");
            LoadPlugins();
            InterfaceLoop();
        }
		
        static void LoadPlugins()
        {
            try
            {
                PluginLoader loader = new PluginLoader();
                loader.LoadPlugins();
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Plugins couldn't be loaded: {0}", ex.Message));
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        static void InterfaceLoop()
        {
            while (true)
            {
				Console.Write("> ");
				InputHandler();
            }
        }

        static void InputHandler()
        {
            try
            {
                string inputLine = Console.ReadLine();
                ProcessInput(inputLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Caught exception: {0}", ex.Message));
            }

        }

        static void ProcessInput(string inputLine)
        {
            string operationName = inputLine.Split(new char[] { ' ' }).FirstOrDefault();
            if (IsExit(operationName))
            {
                Environment.Exit(0);
            }
            IPlugin plugin = GeneratePlugin(operationName);
            if (plugin != null)
            {
                string parameters = inputLine.Replace(string.Format("{0} ", operationName), string.Empty);
                plugin.Go(parameters);
            }
            else
            {
                Console.WriteLine(string.Format("No plugin found with name '{0}'", operationName));
            }
        }

        static bool IsExit(string operationName)
        {
            return (operationName == "exit");
        }

        static IPlugin GeneratePlugin(string operationName)
        {
            return PluginLoader.Plugins.Where(p => p.Name == operationName).FirstOrDefault();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using DotNet.Plugin.Business;

namespace DotNet.Plugin.StringPlugins
{
    public class StringLength : IPlugin
    {
        public string Name
        {
            get
            {
                return "strlength";
            }
        }

        public string Explanation
        {
            get
            {
                return "Gets a string as a parameter and returns the string length in characters.";
            }
        }

		public string Category
		{
			get
			{
				return "Text";
			}
		}

		public void Go(string parameters)
        {
            Console.WriteLine(parameters.Length);
        }
    }
}

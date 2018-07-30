using System;
using DotNet.Plugin.Business;

namespace DotNet.Plugin.StringPlugins
{
	class SentenceCheck : IPlugin
	{
		public string Name
		{
			get
			{
				return "sentence";
			}
		}

		public string Explanation
		{
			get
			{
				return "Gets a string as a parameter and returns if the string is a proper sentence or not.";
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
			if (parameters.Length > 0)
			{
				HandleSentence(parameters);
			}
			else
			{
				Console.WriteLine("This needs parameters to work!.");
			}
		}

		private void HandleSentence(string sentence)
		{
			SentenceChecker sc = new SentenceChecker(sentence);
			if (sc.IsProperSentence())
			{
				Console.WriteLine("This is a proper sentence.");
			}
			else
			{
				Console.WriteLine(sc.SentenceErrors());
			}
		}
	}
}

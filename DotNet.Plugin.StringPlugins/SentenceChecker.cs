using System.Text;

namespace DotNet.Plugin.StringPlugins
{
	class SentenceChecker
	{
		string Sentence { get; }
		string ProperStartErrorMessage
		{
			get
			{
				return "This sentence needs to start with a capital letter!";
			}
		}

		string EndPunctuationErrorMessage
		{
			get
			{
				return "You need to end a sentence with a period, exclamation point, or question mark!";
			}
		}

		string SpaceErrorMessage
		{
			get
			{
				return "You need to have more than one word in a sentence!";
			}
		}

		public SentenceChecker(string sentence)
		{
			Sentence = sentence;
		}

		public bool IsProperSentence()
		{
			if (HasProperStart() && HasEndPunctuation() && HasSpace())
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private bool HasProperStart()
		{
			if (char.IsUpper(Sentence[0]))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private bool HasEndPunctuation()
		{
			switch (Sentence[Sentence.Length - 1])
			{
				case '.':
				case '!':
				case '?':
					return true;
				default:
					return false;
			}
		}

		private bool HasSpace()
		{
			if (Sentence.Contains(" "))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public string SentenceErrors()
		{
			StringBuilder errors = new StringBuilder();
			if (!HasProperStart())
			{
				errors.AppendLine(ProperStartErrorMessage);
			}
			if (!HasEndPunctuation())
			{
				errors.AppendLine(EndPunctuationErrorMessage);
			}
			if (!HasSpace())
			{
				errors.AppendLine(SpaceErrorMessage);
			}
			return errors.ToString();
		}
	}
}

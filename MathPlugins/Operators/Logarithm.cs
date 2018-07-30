using System;

namespace DotNet.Plugin.MathPlugins.Operators
{
	class Logarithm : Operation
	{

		public override string Name
		{
			get
			{
				return "log";
			}
		}

		public override string Explanation
		{
			get
			{
				return string.Format("{0}\n\t{1}", 
					"Takes the logarithm of the first number with the base of the next number. ", 
					"Then continues to take the log of the result with the next number.");
			}
		}

		public override void OperateOn(ref double firstValue, double secondValue)
		{
			if (firstValue > 0 && secondValue > 1)
			{
				firstValue = Math.Log(firstValue, secondValue);
			}
			else if (firstValue > 0 && secondValue > 0)
			{
				throw new NotFiniteNumberException(
					"You can't use a 1 as the base for a logarithm.");
			}
			else
			{
				throw new NotFiniteNumberException(
					"You can't use a negative or zero number in a logarithm.");
			}
		}
	}
}

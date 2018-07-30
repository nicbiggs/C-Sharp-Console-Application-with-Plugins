using System;
using DotNet.Plugin.Business;

namespace DotNet.Plugin.MathPlugins
{
    public abstract class Operation : IPlugin, IOperation
    {

        public abstract string Name
        {
            get;
        }

        public abstract string Explanation
        {
            get;
        }

		public string Category
		{
			get
			{
				return "Math";
			}
		}

		private double answer;

        public void Go(string parameters)
        {
            bool firstRun = true;
            double[] numbers = LineParser.GetNumbers(parameters);
            foreach (double number in LineParser.GetNumbers(parameters))
            {
                if (firstRun)
                {
                    firstRun = false;
                    answer = number;
                }
                else
                {
                    OperateOn(ref answer, number);
                }
            }

            Console.WriteLine("Answer: " + answer);
        }

        public abstract void OperateOn(ref double firstValue, double secondValue);
    }
}

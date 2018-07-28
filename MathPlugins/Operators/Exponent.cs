using System;

namespace DotNet.Plugin.MathPlugins.Operators
{
    class Exponent : Operation
    {

        public override string Name
        {
            get
            {
                return "exponent";
            }
        }

        public override string Explanation
        {
            get
            {
                return "Raises each listed number to the next listed number's power.";
            }
        }

        public override void OperateOn(ref double firstValue, double secondValue)
        {
            firstValue = Math.Pow(firstValue, secondValue);
        }
    }
}

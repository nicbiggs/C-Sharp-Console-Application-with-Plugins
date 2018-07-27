using System;

namespace DotNet.Plugin.MathPlugins
{
    class Divide : Operation
    {

        public override string Name
        {
            get
            {
                return "divide";
            }
        }

        public override string Explanation
        {
            get
            {
                return "Divides each listed number in order.";
            }
        }

        public override void OperateOn(ref double firstValue, double secondValue)
        {
            if (secondValue != 0)
            {
                firstValue /= secondValue;
            }
            else
            {
                throw new Exception("You can't divide by a zero!");
            }
        }
    }
}

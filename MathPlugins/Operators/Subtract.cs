

namespace DotNet.Plugin.MathPlugins
{
    class Subtract : Operation
    {

        public override string Name
        {
            get
            {
                return "subtract";
            }
        }

        public override string Explanation
        {
            get
            {
                return "Subtracts each listed number in order.";
            }
        }

        public override void OperateOn(ref double firstValue, double secondValue)
        {
            firstValue -= secondValue;
        }
    }
}

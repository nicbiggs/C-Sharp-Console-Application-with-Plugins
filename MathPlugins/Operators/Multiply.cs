

namespace DotNet.Plugin.MathPlugins
{
    class Multiply : Operation
    { 

        public override string Name
        {
            get
            {
                return "multiply";
            }
        }

        public override string Explanation
        {
            get
            {
                return "Multiplies each listed number.";
            }
        }

        public override void OperateOn(ref double firstValue, double secondValue)
        {
            firstValue *= secondValue;
        }
    }
}



namespace DotNet.Plugin.MathPlugins
{
    public class Add : Operation
    {

        public override string Name
        {
            get
            {
                return "add";
            }
        }

        public override string Explanation
        {
            get
            {
                return "Adds together each listed number.";
            }
        }

        public override void OperateOn(ref double firstValue, double secondValue)
        {
            firstValue += secondValue;
        }
    }
}

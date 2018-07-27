

namespace DotNet.Plugin.MathPlugins
{
    interface IOperation
    {
        void OperateOn(ref double firstValue, double secondValue);
    }
}

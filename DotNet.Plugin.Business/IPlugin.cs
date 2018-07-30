

namespace DotNet.Plugin.Business
{
    public interface IPlugin
    {
        string Name { get; }
		string Category { get; }
        string Explanation { get; }
        void Go(string parameters);
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DotNet.Plugin.MathPlugins
{
    internal static class LineParser
    {
        internal static double[] GetNumbers(string parameters)
        {
            string[] textNumbers = GetNumberStrings(parameters);
            List<double> doubles = new List<double>();
            foreach(string value in textNumbers)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    doubles.Add(double.Parse(value));
                }
            }
            return doubles.ToArray();
        }

        private static string[] GetNumberStrings(string parameters)
        {
            return Regex.Split(parameters, @"[^\-?\d\.]+")
                .Where(c => c != "." && c.Trim() != "")
                .ToArray();
        }
    }
}
